// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: CheatTotalWarTimeChangeAns.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Oz
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CheatTotalWarTimeChangeAns : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"error")]
        public OZError Error { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"cur_season_num")]
        public int CurSeasonNum { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"cur_season_open_time")]
        public long CurSeasonOpenTime { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"cur_season_close_time")]
        public long CurSeasonCloseTime { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"cur_season_reward_time")]
        public long CurSeasonRewardTime { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
