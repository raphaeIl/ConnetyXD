// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MissionCollectRewardAns.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from MissionCollectRewardAns.proto</summary>
  public static partial class MissionCollectRewardAnsReflection {

    #region Descriptor
    /// <summary>File descriptor for MissionCollectRewardAns.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MissionCollectRewardAnsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1NaXNzaW9uQ29sbGVjdFJld2FyZEFucy5wcm90bxoNT1pFcnJvci5wcm90",
            "bxoRT1pSZXNDb21tb24ucHJvdG8aFE9aTWlzc2lvbkdyb3VwLnByb3RvInwK",
            "F01pc3Npb25Db2xsZWN0UmV3YXJkQW5zEhcKBWVycm9yGAEgASgLMgguT1pF",
            "cnJvchIgCgpyZXNfY29tbW9uGAIgASgLMgwuT1pSZXNDb21tb24SJgoNbWlz",
            "c2lvbl9ncm91cBgDIAEoCzIPLk9aTWlzc2lvbkdyb3VwQgWqAgJPemIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Oz.OZErrorReflection.Descriptor, global::Oz.OZResCommonReflection.Descriptor, global::Oz.OZMissionGroupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.MissionCollectRewardAns), global::Oz.MissionCollectRewardAns.Parser, new[]{ "Error", "ResCommon", "MissionGroup" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MissionCollectRewardAns : pb::IMessage<MissionCollectRewardAns>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MissionCollectRewardAns> _parser = new pb::MessageParser<MissionCollectRewardAns>(() => new MissionCollectRewardAns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MissionCollectRewardAns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.MissionCollectRewardAnsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionCollectRewardAns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionCollectRewardAns(MissionCollectRewardAns other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      resCommon_ = other.resCommon_ != null ? other.resCommon_.Clone() : null;
      missionGroup_ = other.missionGroup_ != null ? other.missionGroup_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionCollectRewardAns Clone() {
      return new MissionCollectRewardAns(this);
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

    /// <summary>Field number for the "res_common" field.</summary>
    public const int ResCommonFieldNumber = 2;
    private global::Oz.OZResCommon resCommon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZResCommon ResCommon {
      get { return resCommon_; }
      set {
        resCommon_ = value;
      }
    }

    /// <summary>Field number for the "mission_group" field.</summary>
    public const int MissionGroupFieldNumber = 3;
    private global::Oz.OZMissionGroup missionGroup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Oz.OZMissionGroup MissionGroup {
      get { return missionGroup_; }
      set {
        missionGroup_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MissionCollectRewardAns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MissionCollectRewardAns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (!object.Equals(ResCommon, other.ResCommon)) return false;
      if (!object.Equals(MissionGroup, other.MissionGroup)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      if (resCommon_ != null) hash ^= ResCommon.GetHashCode();
      if (missionGroup_ != null) hash ^= MissionGroup.GetHashCode();
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
      if (resCommon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResCommon);
      }
      if (missionGroup_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MissionGroup);
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
      if (resCommon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResCommon);
      }
      if (missionGroup_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MissionGroup);
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
      if (resCommon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResCommon);
      }
      if (missionGroup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionGroup);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MissionCollectRewardAns other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Oz.OZError();
        }
        Error.MergeFrom(other.Error);
      }
      if (other.resCommon_ != null) {
        if (resCommon_ == null) {
          ResCommon = new global::Oz.OZResCommon();
        }
        ResCommon.MergeFrom(other.ResCommon);
      }
      if (other.missionGroup_ != null) {
        if (missionGroup_ == null) {
          MissionGroup = new global::Oz.OZMissionGroup();
        }
        MissionGroup.MergeFrom(other.MissionGroup);
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
          case 18: {
            if (resCommon_ == null) {
              ResCommon = new global::Oz.OZResCommon();
            }
            input.ReadMessage(ResCommon);
            break;
          }
          case 26: {
            if (missionGroup_ == null) {
              MissionGroup = new global::Oz.OZMissionGroup();
            }
            input.ReadMessage(MissionGroup);
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
            if (resCommon_ == null) {
              ResCommon = new global::Oz.OZResCommon();
            }
            input.ReadMessage(ResCommon);
            break;
          }
          case 26: {
            if (missionGroup_ == null) {
              MissionGroup = new global::Oz.OZMissionGroup();
            }
            input.ReadMessage(MissionGroup);
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
