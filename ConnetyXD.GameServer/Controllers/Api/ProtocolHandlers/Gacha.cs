using ConnetyXD.Common.Core;
using ConnetyXD.Common.Utils;
using Oz;

namespace ConnetyXD.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Gacha : ProtocolHandlerBase
    {
        public Gacha(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory)
        {
        }

        [ProtocolHandler(Protocol.SummonListReq)]
        public SummonListAns SummonListHandler(SummonListReq req)
        {
            return PcapUtils.GetPacketFromPcap<SummonListAns>();
        }

        [ProtocolHandler(Protocol.SummonCharReq)]
        public SummonCharAns SummonListHandler(SummonCharReq req)
        {
            SummonCharAns resp = PcapUtils.GetPacketFromPcap<SummonCharAns>();

            foreach (var reward in resp.ResCommon.Rewards[0].Rewards)
            {
                reward.DataType = DataType.T.Char;
                reward.Id = "Char_101_S01_B"; // ssr
                reward.Count = 1;
            }

            return resp;
        }
    }
}
