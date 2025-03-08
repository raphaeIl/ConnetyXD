using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.Json;
using ConnetyXD.Common.Core;
using Google.Protobuf;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Newtonsoft.Json;
using Oz;
using Serilog;
using System.Text.RegularExpressions;
using ConnetyXD.GameServer.Controllers.Api.ProtocolHandlers;
using ConnetyXD.Common.Utils;

namespace ConnetyXD.GameServer
{
    public class GameServer
    {
        public static void Main(string[] args)
        {
            //var mission_get = new MissionGetAns()
            //{
            //    Error = new OZError()
            //    {
            //        Message = "success"
            //    },
            //    MissionGroups =
            //    {
            //        new OZMissionGroup()
            //        {
            //            Id = "GuideMissionGroup_New_User",
            //            Missions =
            //            {
            //                { "GuideMission_New_User_01", new OZMission() { ProgressId = "GuideMission_New_User_01", ProgressCount = 1 } },
            //        }
            //        }
            //    }
            //};

            var packet = PcapUtils.GetPacketFromPcap(Protocol.AccessAns);
            Log.Information(JsonConvert.SerializeObject(packet, Formatting.Indented));

            Log.Information("Starting GameServer...");
            try
            {
                var builder = WebApplication.CreateBuilder(args);

                builder.Services.Configure<KestrelServerOptions>(op =>
                    op.AllowSynchronousIO = true
                );
                builder.Host.UseSerilog();

                builder.Services.AddControllers();
                builder.Services.AddProtocolHandlerFactory();
                builder.Services.AddControllers().AddApplicationPart(Assembly.GetAssembly(typeof(GameServer)));

                var handlerGroups = Assembly.GetAssembly(typeof(ProtocolHandlerFactory))
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(ProtocolHandlerBase)));

                foreach (var handlerGroup in handlerGroups)
                {
                    builder.Services.AddProtocolHandlerGroupByType(handlerGroup);
                }

                var app = builder.Build();

                app.UseAuthorization();
                app.UseSerilogRequestLogging();

                app.MapControllers();
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An unhandled exception occurred during runtime");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
