// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: OZResCommon.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Oz
{

    [global::ProtoBuf.ProtoContract()]
    public partial class OZResCommon : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"alarms")]
        public global::System.Collections.Generic.List<OZAlarm> Alarms { get; set; } = new global::System.Collections.Generic.List<OZAlarm>();

        [global::ProtoBuf.ProtoMember(2, Name = @"rewards")]
        public global::System.Collections.Generic.List<OZRewards> Rewards { get; set; } = new global::System.Collections.Generic.List<OZRewards>();

        [global::ProtoBuf.ProtoMember(3, Name = @"delete_chars")]
        public global::System.Collections.Generic.List<OZChar> DeleteChars { get; set; } = new global::System.Collections.Generic.List<OZChar>();

        [global::ProtoBuf.ProtoMember(4, Name = @"change_chars")]
        public global::System.Collections.Generic.List<OZChar> ChangeChars { get; set; } = new global::System.Collections.Generic.List<OZChar>();

        [global::ProtoBuf.ProtoMember(5, Name = @"delete_items")]
        public global::System.Collections.Generic.List<OZItem> DeleteItems { get; set; } = new global::System.Collections.Generic.List<OZItem>();

        [global::ProtoBuf.ProtoMember(6, Name = @"change_items")]
        public global::System.Collections.Generic.List<OZItem> ChangeItems { get; set; } = new global::System.Collections.Generic.List<OZItem>();

        [global::ProtoBuf.ProtoMember(7, Name = @"delete_points")]
        public global::System.Collections.Generic.List<OZPoint> DeletePoints { get; set; } = new global::System.Collections.Generic.List<OZPoint>();

        [global::ProtoBuf.ProtoMember(8, Name = @"change_points")]
        public global::System.Collections.Generic.List<OZPoint> ChangePoints { get; set; } = new global::System.Collections.Generic.List<OZPoint>();

        [global::ProtoBuf.ProtoMember(9, Name = @"delete_equips")]
        public global::System.Collections.Generic.List<OZEquip> DeleteEquips { get; set; } = new global::System.Collections.Generic.List<OZEquip>();

        [global::ProtoBuf.ProtoMember(10, Name = @"change_equips")]
        public global::System.Collections.Generic.List<OZEquip> ChangeEquips { get; set; } = new global::System.Collections.Generic.List<OZEquip>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
