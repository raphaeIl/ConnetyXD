// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuckyType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from LuckyType.proto</summary>
  public static partial class LuckyTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for LuckyType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuckyTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9MdWNreVR5cGUucHJvdG8qcQoJTHVja3lUeXBlEhIKDkx1Y2t5VHlwZV9O",
            "b25lEAASEwoPTHVja3lUeXBlX0dyZWF0EAESEgoOTHVja3lUeXBlX0dvb2QQ",
            "AhIUChBMdWNreVR5cGVfTm9ybWFsEAMSEQoNTHVja3lUeXBlX01BWBAEQgWq",
            "AgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Oz.LuckyType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LuckyType {
    [pbr::OriginalName("LuckyType_None")] None = 0,
    [pbr::OriginalName("LuckyType_Great")] Great = 1,
    [pbr::OriginalName("LuckyType_Good")] Good = 2,
    [pbr::OriginalName("LuckyType_Normal")] Normal = 3,
    [pbr::OriginalName("LuckyType_MAX")] Max = 4,
  }

  #endregion

}

#endregion Designer generated code
