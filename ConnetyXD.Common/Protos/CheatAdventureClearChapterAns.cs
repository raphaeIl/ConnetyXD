// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheatAdventureClearChapterAns.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from CheatAdventureClearChapterAns.proto</summary>
  public static partial class CheatAdventureClearChapterAnsReflection {

    #region Descriptor
    /// <summary>File descriptor for CheatAdventureClearChapterAns.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheatAdventureClearChapterAnsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDaGVhdEFkdmVudHVyZUNsZWFyQ2hhcHRlckFucy5wcm90bxoNT1pFcnJv",
            "ci5wcm90bxoRT1pBZHZlbnR1cmUucHJvdG8aFU9aS2luZ2RvbU9iamVjdC5w",
            "cm90byKFAQodQ2hlYXRBZHZlbnR1cmVDbGVhckNoYXB0ZXJBbnMSFwoFZXJy",
            "b3IYASABKAsyCC5PWkVycm9yEiAKCmFkdmVudHVyZXMYAiADKAsyDC5PWkFk",
            "dmVudHVyZRIpCg9raW5nZG9tX29iamVjdHMYAyADKAsyEC5PWktpbmdkb21P",
            "YmplY3RCBaoCAk96YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.OZErrorReflection.Descriptor, global::Oz.OZAdventureReflection.Descriptor, global::Oz.OZKingdomObjectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.CheatAdventureClearChapterAns), global::Oz.CheatAdventureClearChapterAns.Parser, new[]{ "Error", "Adventures", "KingdomObjects" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CheatAdventureClearChapterAns : pb::IMessage<CheatAdventureClearChapterAns>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheatAdventureClearChapterAns> _parser = new pb::MessageParser<CheatAdventureClearChapterAns>(() => new CheatAdventureClearChapterAns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheatAdventureClearChapterAns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.CheatAdventureClearChapterAnsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatAdventureClearChapterAns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatAdventureClearChapterAns(CheatAdventureClearChapterAns other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      adventures_ = other.adventures_.Clone();
      kingdomObjects_ = other.kingdomObjects_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatAdventureClearChapterAns Clone() {
      return new CheatAdventureClearChapterAns(this);
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

    /// <summary>Field number for the "adventures" field.</summary>
    public const int AdventuresFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Oz.OZAdventure> _repeated_adventures_codec
        = pb::FieldCodec.ForMessage(18, global::Oz.OZAdventure.Parser);
    private readonly pbc::RepeatedField<global::Oz.OZAdventure> adventures_ = new pbc::RepeatedField<global::Oz.OZAdventure>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Oz.OZAdventure> Adventures {
      get { return adventures_; }
    }

    /// <summary>Field number for the "kingdom_objects" field.</summary>
    public const int KingdomObjectsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Oz.OZKingdomObject> _repeated_kingdomObjects_codec
        = pb::FieldCodec.ForMessage(26, global::Oz.OZKingdomObject.Parser);
    private readonly pbc::RepeatedField<global::Oz.OZKingdomObject> kingdomObjects_ = new pbc::RepeatedField<global::Oz.OZKingdomObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Oz.OZKingdomObject> KingdomObjects {
      get { return kingdomObjects_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheatAdventureClearChapterAns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheatAdventureClearChapterAns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if(!adventures_.Equals(other.adventures_)) return false;
      if(!kingdomObjects_.Equals(other.kingdomObjects_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      hash ^= adventures_.GetHashCode();
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
      adventures_.WriteTo(output, _repeated_adventures_codec);
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
      adventures_.WriteTo(ref output, _repeated_adventures_codec);
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
      size += adventures_.CalculateSize(_repeated_adventures_codec);
      size += kingdomObjects_.CalculateSize(_repeated_kingdomObjects_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheatAdventureClearChapterAns other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Oz.OZError();
        }
        Error.MergeFrom(other.Error);
      }
      adventures_.Add(other.adventures_);
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
            adventures_.AddEntriesFrom(input, _repeated_adventures_codec);
            break;
          }
          case 26: {
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
            adventures_.AddEntriesFrom(ref input, _repeated_adventures_codec);
            break;
          }
          case 26: {
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
