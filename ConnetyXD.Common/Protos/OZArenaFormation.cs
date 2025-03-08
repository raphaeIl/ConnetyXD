// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OZArenaFormation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from OZArenaFormation.proto</summary>
  public static partial class OZArenaFormationReflection {

    #region Descriptor
    /// <summary>File descriptor for OZArenaFormation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OZArenaFormationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZPWkFyZW5hRm9ybWF0aW9uLnByb3RvIm4KEE9aQXJlbmFGb3JtYXRpb24S",
            "EAoIYXJlbmFfaWQYASABKAkSDQoFY2hhcnMYAiADKAkSEwoLZ3VhcmRpYW5f",
            "aWQYAyABKAkSEQoJdXBkYXRlX2F0GAQgASgDEhEKCWNyZWF0ZV9hdBgFIAEo",
            "A0IFqgICT3piBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.OZArenaFormation), global::Oz.OZArenaFormation.Parser, new[]{ "ArenaId", "Chars", "GuardianId", "UpdateAt", "CreateAt" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OZArenaFormation : pb::IMessage<OZArenaFormation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OZArenaFormation> _parser = new pb::MessageParser<OZArenaFormation>(() => new OZArenaFormation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OZArenaFormation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.OZArenaFormationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZArenaFormation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZArenaFormation(OZArenaFormation other) : this() {
      arenaId_ = other.arenaId_;
      chars_ = other.chars_.Clone();
      guardianId_ = other.guardianId_;
      updateAt_ = other.updateAt_;
      createAt_ = other.createAt_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZArenaFormation Clone() {
      return new OZArenaFormation(this);
    }

    /// <summary>Field number for the "arena_id" field.</summary>
    public const int ArenaIdFieldNumber = 1;
    private string arenaId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ArenaId {
      get { return arenaId_; }
      set {
        arenaId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chars" field.</summary>
    public const int CharsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_chars_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> chars_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Chars {
      get { return chars_; }
    }

    /// <summary>Field number for the "guardian_id" field.</summary>
    public const int GuardianIdFieldNumber = 3;
    private string guardianId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GuardianId {
      get { return guardianId_; }
      set {
        guardianId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_at" field.</summary>
    public const int UpdateAtFieldNumber = 4;
    private long updateAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UpdateAt {
      get { return updateAt_; }
      set {
        updateAt_ = value;
      }
    }

    /// <summary>Field number for the "create_at" field.</summary>
    public const int CreateAtFieldNumber = 5;
    private long createAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CreateAt {
      get { return createAt_; }
      set {
        createAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OZArenaFormation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OZArenaFormation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ArenaId != other.ArenaId) return false;
      if(!chars_.Equals(other.chars_)) return false;
      if (GuardianId != other.GuardianId) return false;
      if (UpdateAt != other.UpdateAt) return false;
      if (CreateAt != other.CreateAt) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ArenaId.Length != 0) hash ^= ArenaId.GetHashCode();
      hash ^= chars_.GetHashCode();
      if (GuardianId.Length != 0) hash ^= GuardianId.GetHashCode();
      if (UpdateAt != 0L) hash ^= UpdateAt.GetHashCode();
      if (CreateAt != 0L) hash ^= CreateAt.GetHashCode();
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
      if (ArenaId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ArenaId);
      }
      chars_.WriteTo(output, _repeated_chars_codec);
      if (GuardianId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GuardianId);
      }
      if (UpdateAt != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(UpdateAt);
      }
      if (CreateAt != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(CreateAt);
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
      if (ArenaId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ArenaId);
      }
      chars_.WriteTo(ref output, _repeated_chars_codec);
      if (GuardianId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GuardianId);
      }
      if (UpdateAt != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(UpdateAt);
      }
      if (CreateAt != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(CreateAt);
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
      if (ArenaId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArenaId);
      }
      size += chars_.CalculateSize(_repeated_chars_codec);
      if (GuardianId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GuardianId);
      }
      if (UpdateAt != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UpdateAt);
      }
      if (CreateAt != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CreateAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OZArenaFormation other) {
      if (other == null) {
        return;
      }
      if (other.ArenaId.Length != 0) {
        ArenaId = other.ArenaId;
      }
      chars_.Add(other.chars_);
      if (other.GuardianId.Length != 0) {
        GuardianId = other.GuardianId;
      }
      if (other.UpdateAt != 0L) {
        UpdateAt = other.UpdateAt;
      }
      if (other.CreateAt != 0L) {
        CreateAt = other.CreateAt;
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
            ArenaId = input.ReadString();
            break;
          }
          case 18: {
            chars_.AddEntriesFrom(input, _repeated_chars_codec);
            break;
          }
          case 26: {
            GuardianId = input.ReadString();
            break;
          }
          case 32: {
            UpdateAt = input.ReadInt64();
            break;
          }
          case 40: {
            CreateAt = input.ReadInt64();
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
            ArenaId = input.ReadString();
            break;
          }
          case 18: {
            chars_.AddEntriesFrom(ref input, _repeated_chars_codec);
            break;
          }
          case 26: {
            GuardianId = input.ReadString();
            break;
          }
          case 32: {
            UpdateAt = input.ReadInt64();
            break;
          }
          case 40: {
            CreateAt = input.ReadInt64();
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
