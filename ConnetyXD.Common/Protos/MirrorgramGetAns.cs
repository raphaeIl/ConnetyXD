// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MirrorgramGetAns.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from MirrorgramGetAns.proto</summary>
  public static partial class MirrorgramGetAnsReflection {

    #region Descriptor
    /// <summary>File descriptor for MirrorgramGetAns.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MirrorgramGetAnsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZNaXJyb3JncmFtR2V0QW5zLnByb3RvGg1PWkVycm9yLnByb3RvGhVPWk1p",
            "cnJvcmdyYW1Nc2cucHJvdG8aFk9aTWlycm9yZ3JhbVBvc3QucHJvdG8ijwIK",
            "EE1pcnJvcmdyYW1HZXRBbnMSFwoFZXJyb3IYASABKAsyCC5PWkVycm9yEjEK",
            "CG1lc3NhZ2VzGAIgAygLMh8uTWlycm9yZ3JhbUdldEFucy5NZXNzYWdlc0Vu",
            "dHJ5EisKBXBvc3RzGAMgAygLMhwuTWlycm9yZ3JhbUdldEFucy5Qb3N0c0Vu",
            "dHJ5GkEKDU1lc3NhZ2VzRW50cnkSCwoDa2V5GAEgASgJEh8KBXZhbHVlGAIg",
            "ASgLMhAuT1pNaXJyb3JncmFtTXNnOgI4ARo/CgpQb3N0c0VudHJ5EgsKA2tl",
            "eRgBIAEoCRIgCgV2YWx1ZRgCIAEoCzIRLk9aTWlycm9yZ3JhbVBvc3Q6AjgB",
            "QgWqAgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.OZErrorReflection.Descriptor, global::Oz.OZMirrorgramMsgReflection.Descriptor, global::Oz.OZMirrorgramPostReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.MirrorgramGetAns), global::Oz.MirrorgramGetAns.Parser, new[]{ "Error", "Messages", "Posts" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MirrorgramGetAns : pb::IMessage<MirrorgramGetAns>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MirrorgramGetAns> _parser = new pb::MessageParser<MirrorgramGetAns>(() => new MirrorgramGetAns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MirrorgramGetAns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.MirrorgramGetAnsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MirrorgramGetAns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MirrorgramGetAns(MirrorgramGetAns other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      messages_ = other.messages_.Clone();
      posts_ = other.posts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MirrorgramGetAns Clone() {
      return new MirrorgramGetAns(this);
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

    /// <summary>Field number for the "messages" field.</summary>
    public const int MessagesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Oz.OZMirrorgramMsg>.Codec _map_messages_codec
        = new pbc::MapField<string, global::Oz.OZMirrorgramMsg>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Oz.OZMirrorgramMsg.Parser), 18);
    private readonly pbc::MapField<string, global::Oz.OZMirrorgramMsg> messages_ = new pbc::MapField<string, global::Oz.OZMirrorgramMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Oz.OZMirrorgramMsg> Messages {
      get { return messages_; }
    }

    /// <summary>Field number for the "posts" field.</summary>
    public const int PostsFieldNumber = 3;
    private static readonly pbc::MapField<string, global::Oz.OZMirrorgramPost>.Codec _map_posts_codec
        = new pbc::MapField<string, global::Oz.OZMirrorgramPost>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Oz.OZMirrorgramPost.Parser), 26);
    private readonly pbc::MapField<string, global::Oz.OZMirrorgramPost> posts_ = new pbc::MapField<string, global::Oz.OZMirrorgramPost>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Oz.OZMirrorgramPost> Posts {
      get { return posts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MirrorgramGetAns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MirrorgramGetAns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (!Messages.Equals(other.Messages)) return false;
      if (!Posts.Equals(other.Posts)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      hash ^= Messages.GetHashCode();
      hash ^= Posts.GetHashCode();
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
      messages_.WriteTo(output, _map_messages_codec);
      posts_.WriteTo(output, _map_posts_codec);
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
      messages_.WriteTo(ref output, _map_messages_codec);
      posts_.WriteTo(ref output, _map_posts_codec);
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
      size += messages_.CalculateSize(_map_messages_codec);
      size += posts_.CalculateSize(_map_posts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MirrorgramGetAns other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Oz.OZError();
        }
        Error.MergeFrom(other.Error);
      }
      messages_.MergeFrom(other.messages_);
      posts_.MergeFrom(other.posts_);
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
            messages_.AddEntriesFrom(input, _map_messages_codec);
            break;
          }
          case 26: {
            posts_.AddEntriesFrom(input, _map_posts_codec);
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
            messages_.AddEntriesFrom(ref input, _map_messages_codec);
            break;
          }
          case 26: {
            posts_.AddEntriesFrom(ref input, _map_posts_codec);
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
