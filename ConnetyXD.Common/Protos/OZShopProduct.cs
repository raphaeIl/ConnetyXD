// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OZShopProduct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Oz {

  /// <summary>Holder for reflection information generated from OZShopProduct.proto</summary>
  public static partial class OZShopProductReflection {

    #region Descriptor
    /// <summary>File descriptor for OZShopProduct.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OZShopProductReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNPWlNob3BQcm9kdWN0LnByb3RvIk8KDU9aU2hvcFByb2R1Y3QSEgoKcHJv",
            "ZHVjdF9pZBgBIAEoCRIXCg9wcm9kdWN0X2l0ZW1faWQYAiABKAkSEQoJYnV5",
            "X2NvdW50GAMgASgFQgWqAgJPemIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Oz.OZShopProduct), global::Oz.OZShopProduct.Parser, new[]{ "ProductId", "ProductItemId", "BuyCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OZShopProduct : pb::IMessage<OZShopProduct>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OZShopProduct> _parser = new pb::MessageParser<OZShopProduct>(() => new OZShopProduct());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OZShopProduct> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Oz.OZShopProductReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZShopProduct() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZShopProduct(OZShopProduct other) : this() {
      productId_ = other.productId_;
      productItemId_ = other.productItemId_;
      buyCount_ = other.buyCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OZShopProduct Clone() {
      return new OZShopProduct(this);
    }

    /// <summary>Field number for the "product_id" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private string productId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "product_item_id" field.</summary>
    public const int ProductItemIdFieldNumber = 2;
    private string productItemId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductItemId {
      get { return productItemId_; }
      set {
        productItemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "buy_count" field.</summary>
    public const int BuyCountFieldNumber = 3;
    private int buyCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BuyCount {
      get { return buyCount_; }
      set {
        buyCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OZShopProduct);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OZShopProduct other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (ProductItemId != other.ProductItemId) return false;
      if (BuyCount != other.BuyCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId.Length != 0) hash ^= ProductId.GetHashCode();
      if (ProductItemId.Length != 0) hash ^= ProductItemId.GetHashCode();
      if (BuyCount != 0) hash ^= BuyCount.GetHashCode();
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
      if (ProductId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProductId);
      }
      if (ProductItemId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductItemId);
      }
      if (BuyCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BuyCount);
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
      if (ProductId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProductId);
      }
      if (ProductItemId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductItemId);
      }
      if (BuyCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BuyCount);
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
      if (ProductId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductId);
      }
      if (ProductItemId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductItemId);
      }
      if (BuyCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BuyCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OZShopProduct other) {
      if (other == null) {
        return;
      }
      if (other.ProductId.Length != 0) {
        ProductId = other.ProductId;
      }
      if (other.ProductItemId.Length != 0) {
        ProductItemId = other.ProductItemId;
      }
      if (other.BuyCount != 0) {
        BuyCount = other.BuyCount;
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
            ProductId = input.ReadString();
            break;
          }
          case 18: {
            ProductItemId = input.ReadString();
            break;
          }
          case 24: {
            BuyCount = input.ReadInt32();
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
            ProductId = input.ReadString();
            break;
          }
          case 18: {
            ProductItemId = input.ReadString();
            break;
          }
          case 24: {
            BuyCount = input.ReadInt32();
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
