// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheatTotalWarTimeChangeAns.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from CheatTotalWarTimeChangeAns.proto</summary>
  public static partial class CheatTotalWarTimeChangeAnsReflection {

    #region Descriptor
    /// <summary>File descriptor for CheatTotalWarTimeChangeAns.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheatTotalWarTimeChangeAnsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBDaGVhdFRvdGFsV2FyVGltZUNoYW5nZUFucy5wcm90bxoNT1pFcnJvci5w",
            "cm90byKqAQoaQ2hlYXRUb3RhbFdhclRpbWVDaGFuZ2VBbnMSFwoFZXJyb3IY",
            "ASABKAsyCC5PWkVycm9yEhYKDmN1cl9zZWFzb25fbnVtGAIgASgFEhwKFGN1",
            "cl9zZWFzb25fb3Blbl90aW1lGAMgASgDEh0KFWN1cl9zZWFzb25fY2xvc2Vf",
            "dGltZRgEIAEoAxIeChZjdXJfc2Vhc29uX3Jld2FyZF90aW1lGAUgASgDQgWq",
            "AgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.OZErrorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.CheatTotalWarTimeChangeAns), global::Oz.CheatTotalWarTimeChangeAns.Parser, new[]{ "Error", "CurSeasonNum", "CurSeasonOpenTime", "CurSeasonCloseTime", "CurSeasonRewardTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CheatTotalWarTimeChangeAns : pb::IMessage<CheatTotalWarTimeChangeAns>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheatTotalWarTimeChangeAns> _parser = new pb::MessageParser<CheatTotalWarTimeChangeAns>(() => new CheatTotalWarTimeChangeAns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheatTotalWarTimeChangeAns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.CheatTotalWarTimeChangeAnsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatTotalWarTimeChangeAns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatTotalWarTimeChangeAns(CheatTotalWarTimeChangeAns other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      curSeasonNum_ = other.curSeasonNum_;
      curSeasonOpenTime_ = other.curSeasonOpenTime_;
      curSeasonCloseTime_ = other.curSeasonCloseTime_;
      curSeasonRewardTime_ = other.curSeasonRewardTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatTotalWarTimeChangeAns Clone() {
      return new CheatTotalWarTimeChangeAns(this);
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

    /// <summary>Field number for the "cur_season_num" field.</summary>
    public const int CurSeasonNumFieldNumber = 2;
    private int curSeasonNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CurSeasonNum {
      get { return curSeasonNum_; }
      set {
        curSeasonNum_ = value;
      }
    }

    /// <summary>Field number for the "cur_season_open_time" field.</summary>
    public const int CurSeasonOpenTimeFieldNumber = 3;
    private long curSeasonOpenTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CurSeasonOpenTime {
      get { return curSeasonOpenTime_; }
      set {
        curSeasonOpenTime_ = value;
      }
    }

    /// <summary>Field number for the "cur_season_close_time" field.</summary>
    public const int CurSeasonCloseTimeFieldNumber = 4;
    private long curSeasonCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CurSeasonCloseTime {
      get { return curSeasonCloseTime_; }
      set {
        curSeasonCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "cur_season_reward_time" field.</summary>
    public const int CurSeasonRewardTimeFieldNumber = 5;
    private long curSeasonRewardTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CurSeasonRewardTime {
      get { return curSeasonRewardTime_; }
      set {
        curSeasonRewardTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheatTotalWarTimeChangeAns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheatTotalWarTimeChangeAns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (CurSeasonNum != other.CurSeasonNum) return false;
      if (CurSeasonOpenTime != other.CurSeasonOpenTime) return false;
      if (CurSeasonCloseTime != other.CurSeasonCloseTime) return false;
      if (CurSeasonRewardTime != other.CurSeasonRewardTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      if (CurSeasonNum != 0) hash ^= CurSeasonNum.GetHashCode();
      if (CurSeasonOpenTime != 0L) hash ^= CurSeasonOpenTime.GetHashCode();
      if (CurSeasonCloseTime != 0L) hash ^= CurSeasonCloseTime.GetHashCode();
      if (CurSeasonRewardTime != 0L) hash ^= CurSeasonRewardTime.GetHashCode();
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
      if (CurSeasonNum != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CurSeasonNum);
      }
      if (CurSeasonOpenTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(CurSeasonOpenTime);
      }
      if (CurSeasonCloseTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(CurSeasonCloseTime);
      }
      if (CurSeasonRewardTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(CurSeasonRewardTime);
      }
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
      if (CurSeasonNum != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CurSeasonNum);
      }
      if (CurSeasonOpenTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(CurSeasonOpenTime);
      }
      if (CurSeasonCloseTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(CurSeasonCloseTime);
      }
      if (CurSeasonRewardTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(CurSeasonRewardTime);
      }
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
      if (CurSeasonNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurSeasonNum);
      }
      if (CurSeasonOpenTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurSeasonOpenTime);
      }
      if (CurSeasonCloseTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurSeasonCloseTime);
      }
      if (CurSeasonRewardTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurSeasonRewardTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheatTotalWarTimeChangeAns other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Oz.OZError();
        }
        Error.MergeFrom(other.Error);
      }
      if (other.CurSeasonNum != 0) {
        CurSeasonNum = other.CurSeasonNum;
      }
      if (other.CurSeasonOpenTime != 0L) {
        CurSeasonOpenTime = other.CurSeasonOpenTime;
      }
      if (other.CurSeasonCloseTime != 0L) {
        CurSeasonCloseTime = other.CurSeasonCloseTime;
      }
      if (other.CurSeasonRewardTime != 0L) {
        CurSeasonRewardTime = other.CurSeasonRewardTime;
      }
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
          case 16: {
            CurSeasonNum = input.ReadInt32();
            break;
          }
          case 24: {
            CurSeasonOpenTime = input.ReadInt64();
            break;
          }
          case 32: {
            CurSeasonCloseTime = input.ReadInt64();
            break;
          }
          case 40: {
            CurSeasonRewardTime = input.ReadInt64();
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
          case 16: {
            CurSeasonNum = input.ReadInt32();
            break;
          }
          case 24: {
            CurSeasonOpenTime = input.ReadInt64();
            break;
          }
          case 32: {
            CurSeasonCloseTime = input.ReadInt64();
            break;
          }
          case 40: {
            CurSeasonRewardTime = input.ReadInt64();
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
