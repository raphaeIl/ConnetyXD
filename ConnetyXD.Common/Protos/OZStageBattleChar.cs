// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: OZStageBattleChar.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Oz
{

    [global::ProtoBuf.ProtoContract()]
    public partial class OZStageBattleChar : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"is_death")]
        public bool IsDeath { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"damage_dealt")]
        public long DamageDealt { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"damage_taken")]
        public long DamageTaken { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"max_damage_dealt")]
        public long MaxDamageDealt { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"max_damage_taken")]
        public long MaxDamageTaken { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
