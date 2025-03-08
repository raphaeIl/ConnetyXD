// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OZMission.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from OZMission.proto</summary>
  public static partial class OZMissionReflection {

    #region Descriptor
    /// <summary>File descriptor for OZMission.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OZMissionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9PWk1pc3Npb24ucHJvdG8iZQoJT1pNaXNzaW9uEhMKC2lzX2NvbXBsZXRl",
            "GAEgASgIEhMKC3Byb2dyZXNzX2lkGAMgASgJEhYKDnByb2dyZXNzX3BhcmFt",
            "GAIgASgJEhYKDnByb2dyZXNzX2NvdW50GAQgASgDQgWqAgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.OZMission), global::Oz.OZMission.Parser, new[]{ "IsComplete", "ProgressId", "ProgressParam", "ProgressCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OZMission : pb::IMessage<OZMission>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OZMission> _parser = new pb::MessageParser<OZMission>(() => new OZMission());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OZMission> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.OZMissionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZMission() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZMission(OZMission other) : this() {
      isComplete_ = other.isComplete_;
      progressId_ = other.progressId_;
      progressParam_ = other.progressParam_;
      progressCount_ = other.progressCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZMission Clone() {
      return new OZMission(this);
    }

    /// <summary>Field number for the "is_complete" field.</summary>
    public const int IsCompleteFieldNumber = 1;
    private bool isComplete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsComplete {
      get { return isComplete_; }
      set {
        isComplete_ = value;
      }
    }

    /// <summary>Field number for the "progress_id" field.</summary>
    public const int ProgressIdFieldNumber = 3;
    private string progressId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProgressId {
      get { return progressId_; }
      set {
        progressId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "progress_param" field.</summary>
    public const int ProgressParamFieldNumber = 2;
    private string progressParam_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProgressParam {
      get { return progressParam_; }
      set {
        progressParam_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "progress_count" field.</summary>
    public const int ProgressCountFieldNumber = 4;
    private long progressCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ProgressCount {
      get { return progressCount_; }
      set {
        progressCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OZMission);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OZMission other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsComplete != other.IsComplete) return false;
      if (ProgressId != other.ProgressId) return false;
      if (ProgressParam != other.ProgressParam) return false;
      if (ProgressCount != other.ProgressCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsComplete != false) hash ^= IsComplete.GetHashCode();
      if (ProgressId.Length != 0) hash ^= ProgressId.GetHashCode();
      if (ProgressParam.Length != 0) hash ^= ProgressParam.GetHashCode();
      if (ProgressCount != 0L) hash ^= ProgressCount.GetHashCode();
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
      if (IsComplete != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsComplete);
      }
      if (ProgressParam.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProgressParam);
      }
      if (ProgressId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProgressId);
      }
      if (ProgressCount != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ProgressCount);
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
      if (IsComplete != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsComplete);
      }
      if (ProgressParam.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProgressParam);
      }
      if (ProgressId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProgressId);
      }
      if (ProgressCount != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ProgressCount);
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
      if (IsComplete != false) {
        size += 1 + 1;
      }
      if (ProgressId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProgressId);
      }
      if (ProgressParam.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProgressParam);
      }
      if (ProgressCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ProgressCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OZMission other) {
      if (other == null) {
        return;
      }
      if (other.IsComplete != false) {
        IsComplete = other.IsComplete;
      }
      if (other.ProgressId.Length != 0) {
        ProgressId = other.ProgressId;
      }
      if (other.ProgressParam.Length != 0) {
        ProgressParam = other.ProgressParam;
      }
      if (other.ProgressCount != 0L) {
        ProgressCount = other.ProgressCount;
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
            IsComplete = input.ReadBool();
            break;
          }
          case 18: {
            ProgressParam = input.ReadString();
            break;
          }
          case 26: {
            ProgressId = input.ReadString();
            break;
          }
          case 32: {
            ProgressCount = input.ReadInt64();
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
            IsComplete = input.ReadBool();
            break;
          }
          case 18: {
            ProgressParam = input.ReadString();
            break;
          }
          case 26: {
            ProgressId = input.ReadString();
            break;
          }
          case 32: {
            ProgressCount = input.ReadInt64();
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
