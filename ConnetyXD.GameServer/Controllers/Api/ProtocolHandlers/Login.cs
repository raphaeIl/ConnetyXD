using ConnetyXD.Common.Core;
using Oz;

namespace ConnetyXD.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Login : ProtocolHandlerBase
    {
        public Login(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory)
        {
        }

        [ProtocolHandler(Protocol.MissionGetReq)]
        public MissionGetAns MissionGetHandler(MissionGetReq req)
        {
            var mission_get = new MissionGetAns()
            {
                Error = new OZError()
                {
                    Message = "success"
                },
                MissionGroups =
                {
                    new OZMissionGroup()
                    {
                        Id = "GuideMissionGroup_New_User",
                        Missions =
                        {
                            { "GuideMission_New_User_01", new OZMission() { ProgressId = "GuideMission_New_User_01", ProgressCount = 1 } },
                    }
                    }
                }
            };

            return mission_get;
        }
    }
}