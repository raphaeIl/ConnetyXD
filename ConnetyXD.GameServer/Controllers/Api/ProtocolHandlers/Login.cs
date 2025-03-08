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
            var packet = (AccessAns)PcapUtils.GetPacketFromPcap(Protocol.AccessAns).Packet;

            //packet.LoginInfo.Option.Options = @"{""ConfigDetails"":[{""CategoryType"":0,""DetailsType"":0,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":0,""DetailsType"":1,""Value"":2,""Volume"":1.0,""Disable"":false},{""CategoryType"":0,""DetailsType"":2,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":0,""DetailsType"":3,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":0,""DetailsType"":4,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":1,""DetailsType"":5,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":1,""DetailsType"":6,""Value"":2,""Volume"":1.0,""Disable"":false},{""CategoryType"":2,""DetailsType"":7,""Value"":100,""Volume"":1.0,""Disable"":false},{""CategoryType"":2,""DetailsType"":8,""Value"":50,""Volume"":1.0,""Disable"":false},{""CategoryType"":2,""DetailsType"":9,""Value"":70,""Volume"":1.0,""Disable"":false},{""CategoryType"":2,""DetailsType"":10,""Value"":90,""Volume"":1.0,""Disable"":false},{""CategoryType"":3,""DetailsType"":11,""Value"":1,""Volume"":1.0,""Disable"":false},{""CategoryType"":4,""DetailsType"":12,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":4,""DetailsType"":13,""Value"":0,""Volume"":1.0,""Disable"":false},{""CategoryType"":4,""DetailsType"":14,""Value"":1,""Volume"":1.0,""Disable"":false},{""CategoryType"":4,""DetailsType"":15,""Value"":1,""Volume"":1.0,""Disable"":false},{""CategoryType"":4,""DetailsType"":16,""Value"":1,""Volume"":1.0,""Disable"":false},{""CategoryType"":1,""DetailsType"":17,""Value"":1,""Volume"":1.0,""Disable"":false}]}""";
            return packet;
        }
        
        [ProtocolHandler(Protocol.MissionGetReq)]
        public MissionGetAns MissionGetHandler(MissionGetReq req)
        {
            var packet = PcapUtils.GetPacketFromPcap(Protocol.AccessAns);


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

            var access = new AccessAns()
            {
                IsNew = true,
                LoginInfo = new OZLoginInfo()
                {
                    Reader = new OZReader()
                    {
                        Profiles =
                        {
                            {1, new OZProfile() { Type = ProfileType.T.Birthday, Value = "asdasd" } }
                        }
                    }
                }
            };



            //return mission_get;
            return null;
        }
    }
}