// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheatTotalWarStageChangeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from CheatTotalWarStageChangeReq.proto</summary>
  public static partial class CheatTotalWarStageChangeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for CheatTotalWarStageChangeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheatTotalWarStageChangeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGVhdFRvdGFsV2FyU3RhZ2VDaGFuZ2VSZXEucHJvdG8iQwobQ2hlYXRU",
            "b3RhbFdhclN0YWdlQ2hhbmdlUmVxEg8KB2Jvc3NfaHAYASABKAMSEwoLZXhw",
            "aXJlX3RpbWUYAiABKANCBaoCAk96YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.CheatTotalWarStageChangeReq), global::Oz.CheatTotalWarStageChangeReq.Parser, new[]{ "BossHp", "ExpireTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CheatTotalWarStageChangeReq : pb::IMessage<CheatTotalWarStageChangeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheatTotalWarStageChangeReq> _parser = new pb::MessageParser<CheatTotalWarStageChangeReq>(() => new CheatTotalWarStageChangeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheatTotalWarStageChangeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.CheatTotalWarStageChangeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatTotalWarStageChangeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatTotalWarStageChangeReq(CheatTotalWarStageChangeReq other) : this() {
      bossHp_ = other.bossHp_;
      expireTime_ = other.expireTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatTotalWarStageChangeReq Clone() {
      return new CheatTotalWarStageChangeReq(this);
    }

    /// <summary>Field number for the "boss_hp" field.</summary>
    public const int BossHpFieldNumber = 1;
    private long bossHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BossHp {
      get { return bossHp_; }
      set {
        bossHp_ = value;
      }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 2;
    private long expireTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheatTotalWarStageChangeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheatTotalWarStageChangeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BossHp != other.BossHp) return false;
      if (ExpireTime != other.ExpireTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BossHp != 0L) hash ^= BossHp.GetHashCode();
      if (ExpireTime != 0L) hash ^= ExpireTime.GetHashCode();
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
      if (BossHp != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BossHp);
      }
      if (ExpireTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ExpireTime);
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
      if (BossHp != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BossHp);
      }
      if (ExpireTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ExpireTime);
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
      if (BossHp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BossHp);
      }
      if (ExpireTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheatTotalWarStageChangeReq other) {
      if (other == null) {
        return;
      }
      if (other.BossHp != 0L) {
        BossHp = other.BossHp;
      }
      if (other.ExpireTime != 0L) {
        ExpireTime = other.ExpireTime;
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
          case 8: {
            BossHp = input.ReadInt64();
            break;
          }
          case 16: {
            ExpireTime = input.ReadInt64();
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
          case 8: {
            BossHp = input.ReadInt64();
            break;
          }
          case 16: {
            ExpireTime = input.ReadInt64();
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
