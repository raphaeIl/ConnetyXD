// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: OZPacket.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Oz
{

    [global::ProtoBuf.ProtoContract()]
    public partial class OZPacket : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        public PacketType Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ver")]
        public int Ver { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"im_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ImId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"sid")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sid { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"data")]
        public byte[] Data { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
