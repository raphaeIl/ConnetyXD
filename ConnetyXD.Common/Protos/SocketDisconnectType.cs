// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SocketDisconnectType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from SocketDisconnectType.proto</summary>
  public static partial class SocketDisconnectTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for SocketDisconnectType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SocketDisconnectTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTb2NrZXREaXNjb25uZWN0VHlwZS5wcm90byp1ChRTb2NrZXREaXNjb25u",
            "ZWN0VHlwZRIdChlTb2NrZXREaXNjb25uZWN0VHlwZV9Ob25lEAASHQoZU29j",
            "a2V0RGlzY29ubmVjdFR5cGVfS2ljaxABEh8KG1NvY2tldERpc2Nvbm5lY3RU",
            "eXBlX0V4cGlyZRACQgWqAgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Oz.SocketDisconnectType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SocketDisconnectType {
    [pbr::OriginalName("SocketDisconnectType_None")] None = 0,
    [pbr::OriginalName("SocketDisconnectType_Kick")] Kick = 1,
    [pbr::OriginalName("SocketDisconnectType_Expire")] Expire = 2,
  }

  #endregion

}

#endregion Designer generated code
