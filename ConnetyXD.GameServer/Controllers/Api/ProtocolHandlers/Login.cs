using ConnetyXD.Common.Core;
using ConnetyXD.Common.Utils;
using Oz;

namespace ConnetyXD.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Login : ProtocolHandlerBase
    {
        public Login(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory)
        {
        }

        [ProtocolHandler(Protocol.AccessReq)]
        public AccessAns AccessHandler(AccessReq req)
        {
            var resp = PcapUtils.GetPacketFromPcap<AccessAns>();

            resp.LoginInfo.Points["Point_FreeDia"].Count = long.MaxValue;

            return resp;
        }
    }
}