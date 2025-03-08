// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheatKingdomObjectActionChangeAns.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from CheatKingdomObjectActionChangeAns.proto</summary>
  public static partial class CheatKingdomObjectActionChangeAnsReflection {

    #region Descriptor
    /// <summary>File descriptor for CheatKingdomObjectActionChangeAns.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheatKingdomObjectActionChangeAnsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidDaGVhdEtpbmdkb21PYmplY3RBY3Rpb25DaGFuZ2VBbnMucHJvdG8aDU9a",
            "RXJyb3IucHJvdG8aF0tpbmdkb21PYmplY3RUeXBlLnByb3RvGhVPWktpbmdk",
            "b21BY3Rpb24ucHJvdG8iiAEKIUNoZWF0S2luZ2RvbU9iamVjdEFjdGlvbkNo",
            "YW5nZUFucxIXCgVlcnJvchgBIAEoCzIILk9aRXJyb3ISJwoLb2JqZWN0X3R5",
            "cGUYAiABKA4yEi5LaW5nZG9tT2JqZWN0VHlwZRIhCgdhY3Rpb25zGAMgAygL",
            "MhAuT1pLaW5nZG9tQWN0aW9uQgWqAgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.OZErrorReflection.Descriptor, global::Oz.KingdomObjectTypeReflection.Descriptor, global::Oz.OZKingdomActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.CheatKingdomObjectActionChangeAns), global::Oz.CheatKingdomObjectActionChangeAns.Parser, new[]{ "Error", "ObjectType", "Actions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CheatKingdomObjectActionChangeAns : pb::IMessage<CheatKingdomObjectActionChangeAns>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheatKingdomObjectActionChangeAns> _parser = new pb::MessageParser<CheatKingdomObjectActionChangeAns>(() => new CheatKingdomObjectActionChangeAns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheatKingdomObjectActionChangeAns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.CheatKingdomObjectActionChangeAnsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatKingdomObjectActionChangeAns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatKingdomObjectActionChangeAns(CheatKingdomObjectActionChangeAns other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      objectType_ = other.objectType_;
      actions_ = other.actions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheatKingdomObjectActionChangeAns Clone() {
      return new CheatKingdomObjectActionChangeAns(this);
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

    /// <summary>Field number for the "object_type" field.</summary>
    public const int ObjectTypeFieldNumber = 2;
    private global::Oz.KingdomObjectType objectType_ = global::Oz.KingdomObjectType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.KingdomObjectType ObjectType {
      get { return objectType_; }
      set {
        objectType_ = value;
      }
    }

    /// <summary>Field number for the "actions" field.</summary>
    public const int ActionsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Oz.OZKingdomAction> _repeated_actions_codec
        = pb::FieldCodec.ForMessage(26, global::Oz.OZKingdomAction.Parser);
    private readonly pbc::RepeatedField<global::Oz.OZKingdomAction> actions_ = new pbc::RepeatedField<global::Oz.OZKingdomAction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Oz.OZKingdomAction> Actions {
      get { return actions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheatKingdomObjectActionChangeAns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheatKingdomObjectActionChangeAns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (ObjectType != other.ObjectType) return false;
      if(!actions_.Equals(other.actions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      if (ObjectType != global::Oz.KingdomObjectType.None) hash ^= ObjectType.GetHashCode();
      hash ^= actions_.GetHashCode();
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
      if (ObjectType != global::Oz.KingdomObjectType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ObjectType);
      }
      actions_.WriteTo(output, _repeated_actions_codec);
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
      if (ObjectType != global::Oz.KingdomObjectType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ObjectType);
      }
      actions_.WriteTo(ref output, _repeated_actions_codec);
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
      if (ObjectType != global::Oz.KingdomObjectType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObjectType);
      }
      size += actions_.CalculateSize(_repeated_actions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheatKingdomObjectActionChangeAns other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Oz.OZError();
        }
        Error.MergeFrom(other.Error);
      }
      if (other.ObjectType != global::Oz.KingdomObjectType.None) {
        ObjectType = other.ObjectType;
      }
      actions_.Add(other.actions_);
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
            ObjectType = (global::Oz.KingdomObjectType) input.ReadEnum();
            break;
          }
          case 26: {
            actions_.AddEntriesFrom(input, _repeated_actions_codec);
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
            ObjectType = (global::Oz.KingdomObjectType) input.ReadEnum();
            break;
          }
          case 26: {
            actions_.AddEntriesFrom(ref input, _repeated_actions_codec);
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
