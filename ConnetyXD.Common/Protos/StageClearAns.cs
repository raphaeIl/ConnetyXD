// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StageClearAns.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from StageClearAns.proto</summary>
  public static partial class StageClearAnsReflection {

    #region Descriptor
    /// <summary>File descriptor for StageClearAns.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StageClearAnsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNTdGFnZUNsZWFyQW5zLnByb3RvGg1PWkVycm9yLnByb3RvGhBPWlJlc1N0",
            "YWdlLnByb3RvGhFPWlJlc0NvbW1vbi5wcm90bxoST1pSZXNNaXNzaW9uLnBy",
            "b3RvGg5PWlJlc0V4cC5wcm90bxoVT1pLaW5nZG9tT2JqZWN0LnByb3RvItQG",
            "Cg1TdGFnZUNsZWFyQW5zEhcKBWVycm9yGAEgASgLMgguT1pFcnJvchIeCgly",
            "ZXNfc3RhZ2UYAiABKAsyCy5PWlJlc1N0YWdlEiAKCnJlc19jb21tb24YAyAB",
            "KAsyDC5PWlJlc0NvbW1vbhIiCgtyZXNfbWlzc2lvbhgEIAEoCzINLk9aUmVz",
            "TWlzc2lvbhIdCgpleHBfcmVhZGVyGAUgASgLMgkuT1pSZXNFeHASLwoJZXhw",
            "X2NoYXJzGAYgAygLMhwuU3RhZ2VDbGVhckFucy5FeHBDaGFyc0VudHJ5EjEK",
            "CmhpZ2hfcmFua3MYByADKAsyHS5TdGFnZUNsZWFyQW5zLkhpZ2hSYW5rc0Vu",
            "dHJ5EjEKCmhpZ2hfcnVpbnMYCCADKAsyHS5TdGFnZUNsZWFyQW5zLkhpZ2hS",
            "dWluc0VudHJ5EjMKC2hpZ2hfc3RhZ2VzGAkgAygLMh4uU3RhZ2VDbGVhckFu",
            "cy5IaWdoU3RhZ2VzRW50cnkSNwoNaGlnaF9kdW5nZW9ucxgKIAMoCzIgLlN0",
            "YWdlQ2xlYXJBbnMuSGlnaER1bmdlb25zRW50cnkSOAoOaGlnaF90b3RhbF93",
            "YXIYCyADKAsyIC5TdGFnZUNsZWFyQW5zLkhpZ2hUb3RhbFdhckVudHJ5EikK",
            "D2tpbmdkb21fb2JqZWN0cxgMIAMoCzIQLk9aS2luZ2RvbU9iamVjdBo6Cg1F",
            "eHBDaGFyc0VudHJ5EgsKA2tleRgBIAEoCRIYCgV2YWx1ZRgCIAEoCzIJLk9a",
            "UmVzRXhwOgI4ARowCg5IaWdoUmFua3NFbnRyeRILCgNrZXkYASABKAUSDQoF",
            "dmFsdWUYAiABKAU6AjgBGjAKDkhpZ2hSdWluc0VudHJ5EgsKA2tleRgBIAEo",
            "CRINCgV2YWx1ZRgCIAEoBToCOAEaMQoPSGlnaFN0YWdlc0VudHJ5EgsKA2tl",
            "eRgBIAEoBRINCgV2YWx1ZRgCIAEoCToCOAEaMwoRSGlnaER1bmdlb25zRW50",
            "cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgFOgI4ARozChFIaWdoVG90",
            "YWxXYXJFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAU6AjgBQgWq",
            "AgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.OZErrorReflection.Descriptor, global::Oz.OZResStageReflection.Descriptor, global::Oz.OZResCommonReflection.Descriptor, global::Oz.OZResMissionReflection.Descriptor, global::Oz.OZResExpReflection.Descriptor, global::Oz.OZKingdomObjectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.StageClearAns), global::Oz.StageClearAns.Parser, new[]{ "Error", "ResStage", "ResCommon", "ResMission", "ExpReader", "ExpChars", "HighRanks", "HighRuins", "HighStages", "HighDungeons", "HighTotalWar", "KingdomObjects" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StageClearAns : pb::IMessage<StageClearAns>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StageClearAns> _parser = new pb::MessageParser<StageClearAns>(() => new StageClearAns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StageClearAns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.StageClearAnsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageClearAns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageClearAns(StageClearAns other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      resStage_ = other.resStage_ != null ? other.resStage_.Clone() : null;
      resCommon_ = other.resCommon_ != null ? other.resCommon_.Clone() : null;
      resMission_ = other.resMission_ != null ? other.resMission_.Clone() : null;
      expReader_ = other.expReader_ != null ? other.expReader_.Clone() : null;
      expChars_ = other.expChars_.Clone();
      highRanks_ = other.highRanks_.Clone();
      highRuins_ = other.highRuins_.Clone();
      highStages_ = other.highStages_.Clone();
      highDungeons_ = other.highDungeons_.Clone();
      highTotalWar_ = other.highTotalWar_.Clone();
      kingdomObjects_ = other.kingdomObjects_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageClearAns Clone() {
      return new StageClearAns(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private global::Oz.OZError error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZError Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    /// <summary>Field number for the "res_stage" field.</summary>
    public const int ResStageFieldNumber = 2;
    private global::Oz.OZResStage resStage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZResStage ResStage {
      get { return resStage_; }
      set {
        resStage_ = value;
      }
    }

    /// <summary>Field number for the "res_common" field.</summary>
    public const int ResCommonFieldNumber = 3;
    private global::Oz.OZResCommon resCommon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZResCommon ResCommon {
      get { return resCommon_; }
      set {
        resCommon_ = value;
      }
    }

    /// <summary>Field number for the "res_mission" field.</summary>
    public const int ResMissionFieldNumber = 4;
    private global::Oz.OZResMission resMission_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZResMission ResMission {
      get { return resMission_; }
      set {
        resMission_ = value;
      }
    }

    /// <summary>Field number for the "exp_reader" field.</summary>
    public const int ExpReaderFieldNumber = 5;
    private global::Oz.OZResExp expReader_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZResExp ExpReader {
      get { return expReader_; }
      set {
        expReader_ = value;
      }
    }

    /// <summary>Field number for the "exp_chars" field.</summary>
    public const int ExpCharsFieldNumber = 6;
    private static readonly pbc::MapField<string, global::Oz.OZResExp>.Codec _map_expChars_codec
        = new pbc::MapField<string, global::Oz.OZResExp>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Oz.OZResExp.Parser), 50);
    private readonly pbc::MapField<string, global::Oz.OZResExp> expChars_ = new pbc::MapField<string, global::Oz.OZResExp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Oz.OZResExp> ExpChars {
      get { return expChars_; }
    }

    /// <summary>Field number for the "high_ranks" field.</summary>
    public const int HighRanksFieldNumber = 7;
    private static readonly pbc::MapField<int, int>.Codec _map_highRanks_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 58);
    private readonly pbc::MapField<int, int> highRanks_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<int, int> HighRanks {
      get { return highRanks_; }
    }

    /// <summary>Field number for the "high_ruins" field.</summary>
    public const int HighRuinsFieldNumber = 8;
    private static readonly pbc::MapField<string, int>.Codec _map_highRuins_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 66);
    private readonly pbc::MapField<string, int> highRuins_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> HighRuins {
      get { return highRuins_; }
    }

    /// <summary>Field number for the "high_stages" field.</summary>
    public const int HighStagesFieldNumber = 9;
    private static readonly pbc::MapField<int, string>.Codec _map_highStages_codec
        = new pbc::MapField<int, string>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForString(18, ""), 74);
    private readonly pbc::MapField<int, string> highStages_ = new pbc::MapField<int, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<int, string> HighStages {
      get { return highStages_; }
    }

    /// <summary>Field number for the "high_dungeons" field.</summary>
    public const int HighDungeonsFieldNumber = 10;
    private static readonly pbc::MapField<string, int>.Codec _map_highDungeons_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 82);
    private readonly pbc::MapField<string, int> highDungeons_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> HighDungeons {
      get { return highDungeons_; }
    }

    /// <summary>Field number for the "high_total_war" field.</summary>
    public const int HighTotalWarFieldNumber = 11;
    private static readonly pbc::MapField<string, int>.Codec _map_highTotalWar_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 90);
    private readonly pbc::MapField<string, int> highTotalWar_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> HighTotalWar {
      get { return highTotalWar_; }
    }

    /// <summary>Field number for the "kingdom_objects" field.</summary>
    public const int KingdomObjectsFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Oz.OZKingdomObject> _repeated_kingdomObjects_codec
        = pb::FieldCodec.ForMessage(98, global::Oz.OZKingdomObject.Parser);
    private readonly pbc::RepeatedField<global::Oz.OZKingdomObject> kingdomObjects_ = new pbc::RepeatedField<global::Oz.OZKingdomObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Oz.OZKingdomObject> KingdomObjects {
      get { return kingdomObjects_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StageClearAns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StageClearAns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (!object.Equals(ResStage, other.ResStage)) return false;
      if (!object.Equals(ResCommon, other.ResCommon)) return false;
      if (!object.Equals(ResMission, other.ResMission)) return false;
      if (!object.Equals(ExpReader, other.ExpReader)) return false;
      if (!ExpChars.Equals(other.ExpChars)) return false;
      if (!HighRanks.Equals(other.HighRanks)) return false;
      if (!HighRuins.Equals(other.HighRuins)) return false;
      if (!HighStages.Equals(other.HighStages)) return false;
      if (!HighDungeons.Equals(other.HighDungeons)) return false;
      if (!HighTotalWar.Equals(other.HighTotalWar)) return false;
      if(!kingdomObjects_.Equals(other.kingdomObjects_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      if (resStage_ != null) hash ^= ResStage.GetHashCode();
      if (resCommon_ != null) hash ^= ResCommon.GetHashCode();
      if (resMission_ != null) hash ^= ResMission.GetHashCode();
      if (expReader_ != null) hash ^= ExpReader.GetHashCode();
      hash ^= ExpChars.GetHashCode();
      hash ^= HighRanks.GetHashCode();
      hash ^= HighRuins.GetHashCode();
      hash ^= HighStages.GetHashCode();
      hash ^= HighDungeons.GetHashCode();
      hash ^= HighTotalWar.GetHashCode();
      hash ^= kingdomObjects_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error);
      }
      if (resStage_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResStage);
      }
      if (resCommon_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ResCommon);
      }
      if (resMission_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ResMission);
      }
      if (expReader_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExpReader);
      }
      expChars_.WriteTo(output, _map_expChars_codec);
      highRanks_.WriteTo(output, _map_highRanks_codec);
      highRuins_.WriteTo(output, _map_highRuins_codec);
      highStages_.WriteTo(output, _map_highStages_codec);
      highDungeons_.WriteTo(output, _map_highDungeons_codec);
      highTotalWar_.WriteTo(output, _map_highTotalWar_codec);
      kingdomObjects_.WriteTo(output, _repeated_kingdomObjects_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error);
      }
      if (resStage_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResStage);
      }
      if (resCommon_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ResCommon);
      }
      if (resMission_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ResMission);
      }
      if (expReader_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExpReader);
      }
      expChars_.WriteTo(ref output, _map_expChars_codec);
      highRanks_.WriteTo(ref output, _map_highRanks_codec);
      highRuins_.WriteTo(ref output, _map_highRuins_codec);
      highStages_.WriteTo(ref output, _map_highStages_codec);
      highDungeons_.WriteTo(ref output, _map_highDungeons_codec);
      highTotalWar_.WriteTo(ref output, _map_highTotalWar_codec);
      kingdomObjects_.WriteTo(ref output, _repeated_kingdomObjects_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (error_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      if (resStage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResStage);
      }
      if (resCommon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResCommon);
      }
      if (resMission_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResMission);
      }
      if (expReader_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpReader);
      }
      size += expChars_.CalculateSize(_map_expChars_codec);
      size += highRanks_.CalculateSize(_map_highRanks_codec);
      size += highRuins_.CalculateSize(_map_highRuins_codec);
      size += highStages_.CalculateSize(_map_highStages_codec);
      size += highDungeons_.CalculateSize(_map_highDungeons_codec);
      size += highTotalWar_.CalculateSize(_map_highTotalWar_codec);
      size += kingdomObjects_.CalculateSize(_repeated_kingdomObjects_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StageClearAns other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Oz.OZError();
        }
        Error.MergeFrom(other.Error);
      }
      if (other.resStage_ != null) {
        if (resStage_ == null) {
          ResStage = new global::Oz.OZResStage();
        }
        ResStage.MergeFrom(other.ResStage);
      }
      if (other.resCommon_ != null) {
        if (resCommon_ == null) {
          ResCommon = new global::Oz.OZResCommon();
        }
        ResCommon.MergeFrom(other.ResCommon);
      }
      if (other.resMission_ != null) {
        if (resMission_ == null) {
          ResMission = new global::Oz.OZResMission();
        }
        ResMission.MergeFrom(other.ResMission);
      }
      if (other.expReader_ != null) {
        if (expReader_ == null) {
          ExpReader = new global::Oz.OZResExp();
        }
        ExpReader.MergeFrom(other.ExpReader);
      }
      expChars_.MergeFrom(other.expChars_);
      highRanks_.MergeFrom(other.highRanks_);
      highRuins_.MergeFrom(other.highRuins_);
      highStages_.MergeFrom(other.highStages_);
      highDungeons_.MergeFrom(other.highDungeons_);
      highTotalWar_.MergeFrom(other.highTotalWar_);
      kingdomObjects_.Add(other.kingdomObjects_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (error_ == null) {
              Error = new global::Oz.OZError();
            }
            input.ReadMessage(Error);
            break;
          }
          case 18: {
            if (resStage_ == null) {
              ResStage = new global::Oz.OZResStage();
            }
            input.ReadMessage(ResStage);
            break;
          }
          case 26: {
            if (resCommon_ == null) {
              ResCommon = new global::Oz.OZResCommon();
            }
            input.ReadMessage(ResCommon);
            break;
          }
          case 34: {
            if (resMission_ == null) {
              ResMission = new global::Oz.OZResMission();
            }
            input.ReadMessage(ResMission);
            break;
          }
          case 42: {
            if (expReader_ == null) {
              ExpReader = new global::Oz.OZResExp();
            }
            input.ReadMessage(ExpReader);
            break;
          }
          case 50: {
            expChars_.AddEntriesFrom(input, _map_expChars_codec);
            break;
          }
          case 58: {
            highRanks_.AddEntriesFrom(input, _map_highRanks_codec);
            break;
          }
          case 66: {
            highRuins_.AddEntriesFrom(input, _map_highRuins_codec);
            break;
          }
          case 74: {
            highStages_.AddEntriesFrom(input, _map_highStages_codec);
            break;
          }
          case 82: {
            highDungeons_.AddEntriesFrom(input, _map_highDungeons_codec);
            break;
          }
          case 90: {
            highTotalWar_.AddEntriesFrom(input, _map_highTotalWar_codec);
            break;
          }
          case 98: {
            kingdomObjects_.AddEntriesFrom(input, _repeated_kingdomObjects_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (error_ == null) {
              Error = new global::Oz.OZError();
            }
            input.ReadMessage(Error);
            break;
          }
          case 18: {
            if (resStage_ == null) {
              ResStage = new global::Oz.OZResStage();
            }
            input.ReadMessage(ResStage);
            break;
          }
          case 26: {
            if (resCommon_ == null) {
              ResCommon = new global::Oz.OZResCommon();
            }
            input.ReadMessage(ResCommon);
            break;
          }
          case 34: {
            if (resMission_ == null) {
              ResMission = new global::Oz.OZResMission();
            }
            input.ReadMessage(ResMission);
            break;
          }
          case 42: {
            if (expReader_ == null) {
              ExpReader = new global::Oz.OZResExp();
            }
            input.ReadMessage(ExpReader);
            break;
          }
          case 50: {
            expChars_.AddEntriesFrom(ref input, _map_expChars_codec);
            break;
          }
          case 58: {
            highRanks_.AddEntriesFrom(ref input, _map_highRanks_codec);
            break;
          }
          case 66: {
            highRuins_.AddEntriesFrom(ref input, _map_highRuins_codec);
            break;
          }
          case 74: {
            highStages_.AddEntriesFrom(ref input, _map_highStages_codec);
            break;
          }
          case 82: {
            highDungeons_.AddEntriesFrom(ref input, _map_highDungeons_codec);
            break;
          }
          case 90: {
            highTotalWar_.AddEntriesFrom(ref input, _map_highTotalWar_codec);
            break;
          }
          case 98: {
            kingdomObjects_.AddEntriesFrom(ref input, _repeated_kingdomObjects_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
