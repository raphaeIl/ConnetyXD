// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OZPresetParty.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from OZPresetParty.proto</summary>
  public static partial class OZPresetPartyReflection {

    #region Descriptor
    /// <summary>File descriptor for OZPresetParty.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OZPresetPartyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNPWlByZXNldFBhcnR5LnByb3RvIlgKDU9aUHJlc2V0UGFydHkSEAoIZ3Jv",
            "dXBfbm8YASABKAUSEQoJcHJlc2V0X25vGAIgASgFEhMKC3ByZXNldF9uYW1l",
            "GAMgASgJEg0KBWNoYXJzGAQgAygJQgWqAgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.OZPresetParty), global::Oz.OZPresetParty.Parser, new[]{ "GroupNo", "PresetNo", "PresetName", "Chars" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OZPresetParty : pb::IMessage<OZPresetParty>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OZPresetParty> _parser = new pb::MessageParser<OZPresetParty>(() => new OZPresetParty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OZPresetParty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.OZPresetPartyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZPresetParty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZPresetParty(OZPresetParty other) : this() {
      groupNo_ = other.groupNo_;
      presetNo_ = other.presetNo_;
      presetName_ = other.presetName_;
      chars_ = other.chars_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZPresetParty Clone() {
      return new OZPresetParty(this);
    }

    /// <summary>Field number for the "group_no" field.</summary>
    public const int GroupNoFieldNumber = 1;
    private int groupNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int GroupNo {
      get { return groupNo_; }
      set {
        groupNo_ = value;
      }
    }

    /// <summary>Field number for the "preset_no" field.</summary>
    public const int PresetNoFieldNumber = 2;
    private int presetNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PresetNo {
      get { return presetNo_; }
      set {
        presetNo_ = value;
      }
    }

    /// <summary>Field number for the "preset_name" field.</summary>
    public const int PresetNameFieldNumber = 3;
    private string presetName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PresetName {
      get { return presetName_; }
      set {
        presetName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chars" field.</summary>
    public const int CharsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_chars_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> chars_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Chars {
      get { return chars_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OZPresetParty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OZPresetParty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupNo != other.GroupNo) return false;
      if (PresetNo != other.PresetNo) return false;
      if (PresetName != other.PresetName) return false;
      if(!chars_.Equals(other.chars_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupNo != 0) hash ^= GroupNo.GetHashCode();
      if (PresetNo != 0) hash ^= PresetNo.GetHashCode();
      if (PresetName.Length != 0) hash ^= PresetName.GetHashCode();
      hash ^= chars_.GetHashCode();
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
      if (GroupNo != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(GroupNo);
      }
      if (PresetNo != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PresetNo);
      }
      if (PresetName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PresetName);
      }
      chars_.WriteTo(output, _repeated_chars_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GroupNo != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(GroupNo);
      }
      if (PresetNo != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PresetNo);
      }
      if (PresetName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PresetName);
      }
      chars_.WriteTo(ref output, _repeated_chars_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GroupNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GroupNo);
      }
      if (PresetNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PresetNo);
      }
      if (PresetName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PresetName);
      }
      size += chars_.CalculateSize(_repeated_chars_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OZPresetParty other) {
      if (other == null) {
        return;
      }
      if (other.GroupNo != 0) {
        GroupNo = other.GroupNo;
      }
      if (other.PresetNo != 0) {
        PresetNo = other.PresetNo;
      }
      if (other.PresetName.Length != 0) {
        PresetName = other.PresetName;
      }
      chars_.Add(other.chars_);
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
            GroupNo = input.ReadInt32();
            break;
          }
          case 16: {
            PresetNo = input.ReadInt32();
            break;
          }
          case 26: {
            PresetName = input.ReadString();
            break;
          }
          case 34: {
            chars_.AddEntriesFrom(input, _repeated_chars_codec);
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
            GroupNo = input.ReadInt32();
            break;
          }
          case 16: {
            PresetNo = input.ReadInt32();
            break;
          }
          case 26: {
            PresetName = input.ReadString();
            break;
          }
          case 34: {
            chars_.AddEntriesFrom(ref input, _repeated_chars_codec);
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
