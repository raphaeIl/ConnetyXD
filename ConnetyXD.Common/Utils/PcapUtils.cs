using ConnetyXD.Common.Core;
using Oz;
using ProtoBuf;
using System.Reflection;
using System.Text.Json;

namespace ConnetyXD.Common.Utils
{
    public class PcapUtils : Singleton<PcapUtils>
    {
        public static string DefaultPcapName = "instant_gacha.json";

        public List<OZPacket> Packets { get; set; } = new List<OZPacket>();

        private List<PcapPacket> pcapPackets { get; set; } = new List<PcapPacket>();

        public void Load(string pcapFileName = "")
        {
            if (pcapFileName == "")
            {
                pcapFileName = DefaultPcapName;
            }

            this.LoadPcapFromFile(Path.Combine(AppContext.BaseDirectory, "Resources", pcapFileName));
        }


        public static T GetPacketFromPcap<T>() where T : IExtensible
        {
            Protocol protocol = (Protocol)Enum.Parse(typeof(Protocol), typeof(T).Name);

            return (T)GetPacketFromPcap(protocol).Packet;
        }

        // get the first packet of protocol
        private static OZPacket GetPacketFromPcap(Protocol protocol)
        {
            if (PcapUtils.Instance.Packets.Count == 0)
            {
                PcapUtils.Instance.Load();
            }

            return PcapUtils.Instance.Packets.Where(p => p.Protocol == protocol).FirstOrDefault();
        }

        private void LoadPcapFromFile(string pcapPath)
        {
            string pcapStr = File.ReadAllText(pcapPath);

            pcapPackets = JsonSerializer.Deserialize<List<PcapPacket>>(pcapStr);

            foreach (PcapPacket pcapPacket in pcapPackets)
            {
                if (!pcapPacket.url.Contains("oz/"))
                {
                    continue;
                }

                string url = pcapPacket.url;
                string firstPath = url.Substring(url.IndexOf("oz/") + 1);
                string secondPath = firstPath.Substring(firstPath.IndexOf('/') + 1);
                string path = secondPath.Substring(secondPath.IndexOf('/') + 1);

                string protocolId = $"{Util.ConvertToPascalCase(path)}";

                if (pcapPacket.type == "REQUEST")
                {
                    protocolId += "Req";
                } else
                {
                    protocolId += "Ans";
                }

                Protocol protocol;

                try
                {
                    protocol = (Protocol)Enum.Parse(typeof(Protocol), protocolId);
                } catch (Exception ex)
                {
                    Console.WriteLine("Could not find protocol for path: {path}", path);
                    continue;
                }

                // re-deserialize
                string payloadStr = JsonSerializer.Serialize(pcapPacket.payload);
                Type payloadType = GetRequestPacketTypeByProtocol(protocol);

                //Console.WriteLine(payloadStr);

                IExtensible reqPacket = (IExtensible)JsonSerializer.Deserialize(payloadStr, payloadType, options: SnakeCaseNamingPolicy.SnakeCaseOptions);

                if (reqPacket is null)
                {
                    Console.WriteLine($"Unable to deserialize packet: {protocol.ToString()}");
                }

                //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(reqPacket));
                Console.WriteLine($"Loaded Pcap {protocol.ToString()}");

                Packets.Add(new OZPacket()
                {
                    Protocol = protocol,
                    Packet = reqPacket,
                });
            }
        }

        private Type? GetRequestPacketTypeByProtocol(Protocol msgId)
        {
            // name same as class type
            string msgIdClassName = msgId.ToString();

            Type packetClassType = Assembly.GetAssembly(typeof(LoginReq))!.GetTypes().Where(x => x.Name == msgIdClassName).SingleOrDefault();

            return packetClassType;
        }
    }

    public class OZPacket
    {
        public IExtensible Packet { get; set; }

        public Protocol Protocol { get; set; }
    }

    public class PcapPacket
    {
        public object payload { get; set; }

        public string type { get; set; }

        public string url { get; set; }
        
        public int seq { get; set; }
    }
}
