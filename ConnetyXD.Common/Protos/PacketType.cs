// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: PacketType.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Oz
{

    [global::ProtoBuf.ProtoContract()]
    public enum PacketType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_None")]
        PacketTypeNone = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_ConnectReq")]
        PacketTypeConnectReq = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_ConnectAns")]
        PacketTypeConnectAns = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_DisconnectNoti")]
        PacketTypeDisconnectNoti = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_PingReq")]
        PacketTypePingReq = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_PingAns")]
        PacketTypePingAns = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_KickReq")]
        PacketTypeKickReq = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_KickAns")]
        PacketTypeKickAns = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_BlockReq")]
        PacketTypeBlockReq = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_BlockAns")]
        PacketTypeBlockAns = 9,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_BlockNoti")]
        PacketTypeBlockNoti = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_NoticeReq")]
        PacketTypeNoticeReq = 20,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_NoticeAns")]
        PacketTypeNoticeAns = 21,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_NoticeBr")]
        PacketTypeNoticeBr = 22,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_ChatReq")]
        PacketTypeChatReq = 100,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_ChatAns")]
        PacketTypeChatAns = 101,
        [global::ProtoBuf.ProtoEnum(Name = @"PacketType_ChatBr")]
        PacketTypeChatBr = 102,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
