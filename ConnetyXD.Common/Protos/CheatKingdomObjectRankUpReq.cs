// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheatKingdomObjectRankUpReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from CheatKingdomObjectRankUpReq.proto</summary>
  public static partial class CheatKingdomObjectRankUpReqReflection {

    #region Descriptor
    /// <summary>File descriptor for CheatKingdomObjectRankUpReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheatKingdomObjectRankUpReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGVhdEtpbmdkb21PYmplY3RSYW5rVXBSZXEucHJvdG8aF0tpbmdkb21P",
            "YmplY3RUeXBlLnByb3RvIl0KG0NoZWF0S2luZ2RvbU9iamVjdFJhbmtVcFJl",
            "cRInCgtvYmplY3RfdHlwZRgBIAEoDjISLktpbmdkb21PYmplY3RUeXBlEhUK",
            "DWluY3JlYXNlX3JhbmsYAiABKAVCBaoCAk96YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.KingdomObjectTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.CheatKingdomObjectRankUpReq), global::Oz.CheatKingdomObjectRankUpReq.Parser, new[]{ "ObjectType", "IncreaseRank" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CheatKingdomObjectRankUpReq : pb::IMessage<CheatKingdomObjectRankUpReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheatKingdomObjectRankUpReq> _parser = new pb::MessageParser<CheatKingdomObjectRankUpReq>(() => new CheatKingdomObjectRankUpReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheatKingdomObjectRankUpReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.CheatKingdomObjectRankUpReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatKingdomObjectRankUpReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatKingdomObjectRankUpReq(CheatKingdomObjectRankUpReq other) : this() {
      objectType_ = other.objectType_;
      increaseRank_ = other.increaseRank_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatKingdomObjectRankUpReq Clone() {
      return new CheatKingdomObjectRankUpReq(this);
    }

    /// <summary>Field number for the "object_type" field.</summary>
    public const int ObjectTypeFieldNumber = 1;
    private global::Oz.KingdomObjectType objectType_ = global::Oz.KingdomObjectType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.KingdomObjectType ObjectType {
      get { return objectType_; }
      set {
        objectType_ = value;
      }
    }

    /// <summary>Field number for the "increase_rank" field.</summary>
    public const int IncreaseRankFieldNumber = 2;
    private int increaseRank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IncreaseRank {
      get { return increaseRank_; }
      set {
        increaseRank_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheatKingdomObjectRankUpReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheatKingdomObjectRankUpReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ObjectType != other.ObjectType) return false;
      if (IncreaseRank != other.IncreaseRank) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ObjectType != global::Oz.KingdomObjectType.None) hash ^= ObjectType.GetHashCode();
      if (IncreaseRank != 0) hash ^= IncreaseRank.GetHashCode();
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
      if (ObjectType != global::Oz.KingdomObjectType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ObjectType);
      }
      if (IncreaseRank != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(IncreaseRank);
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
      if (ObjectType != global::Oz.KingdomObjectType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ObjectType);
      }
      if (IncreaseRank != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(IncreaseRank);
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
      if (ObjectType != global::Oz.KingdomObjectType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObjectType);
      }
      if (IncreaseRank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IncreaseRank);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheatKingdomObjectRankUpReq other) {
      if (other == null) {
        return;
      }
      if (other.ObjectType != global::Oz.KingdomObjectType.None) {
        ObjectType = other.ObjectType;
      }
      if (other.IncreaseRank != 0) {
        IncreaseRank = other.IncreaseRank;
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
            ObjectType = (global::Oz.KingdomObjectType) input.ReadEnum();
            break;
          }
          case 16: {
            IncreaseRank = input.ReadInt32();
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
            ObjectType = (global::Oz.KingdomObjectType) input.ReadEnum();
            break;
          }
          case 16: {
            IncreaseRank = input.ReadInt32();
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
