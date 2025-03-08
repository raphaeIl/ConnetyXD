using ConnetyXD.Common.Core;
using ConnetyXD.Common.Utils;
using ConnetyXD.GameServer.Controllers.Api.ProtocolHandlers;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using System.Text;
using ProtoBuf;

namespace ConnetyXD.GameServer.Controllers.Api
{
    [Route("oz/{*path}")] // catch-all segment to capture any route after /oz/game
    public class GatewayController : ControllerBase
    {
        private readonly IProtocolHandlerFactory protocolHandlerFactory;
        private readonly ILogger<GatewayController> logger;

        public GatewayController(IProtocolHandlerFactory _protocolHandlerFactory, ILogger<GatewayController> _logger)
        {
            protocolHandlerFactory = _protocolHandlerFactory;
            logger = _logger;
        }

        // can be either oz/auth or oz/game
        [HttpPost]
        public IResult PostRequest(string path)
        {
            path = path.Substring(path.IndexOf('/') + 1);

            Log.Information("Gateway Post Request from: {path}", path);

            string protocolId = $"{Util.ConvertToPascalCase(path)}Req";
            Protocol protocol;
            Log.Information("protocolId ConvertToPascalCase: " + protocolId);
            try
            {
                protocol = (Protocol)Enum.Parse(typeof(Protocol), protocolId);
            }
            catch (Exception ex)
            {
                Log.Error("Could not find protocol for path: {path}", path);
                return Results.Empty;
            }

            string reqBody;

            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                reqBody = reader.ReadToEnd();
            }

            Log.Information("reqBody: " + reqBody);

            Type reqType = ProtocolHandlerFactory.GetRequestPacketTypeByProtocol(protocol);
            IExtensible reqPacket = (IExtensible)JsonSerializer.Deserialize(reqBody, reqType, options:SnakeCaseNamingPolicy.SnakeCaseOptions);

            // received req
            var respPacket = protocolHandlerFactory.Invoke(protocol, reqPacket);
            
            if (respPacket is null)
            {
                Log.Error("Protocol {protocol} is unimplemented and left unhandled", protocol);
                
                return Results.Empty;
            }

            return Results.Json(respPacket, SnakeCaseNamingPolicy.SnakeCaseOptions);
            //return Results.Text(respPacketStr, "application/json");
        }
    }
}
