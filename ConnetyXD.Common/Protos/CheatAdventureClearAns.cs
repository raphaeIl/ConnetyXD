// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: CheatAdventureClearAns.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Oz
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CheatAdventureClearAns : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"error")]
        public OZError Error { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"adventures")]
        public global::System.Collections.Generic.List<OZAdventure> Adventures { get; set; } = new global::System.Collections.Generic.List<OZAdventure>();

        [global::ProtoBuf.ProtoMember(3, Name = @"kingdom_objects")]
        public global::System.Collections.Generic.List<OZKingdomObject> KingdomObjects { get; set; } = new global::System.Collections.Generic.List<OZKingdomObject>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
