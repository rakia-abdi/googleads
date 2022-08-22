// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/extension_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/extension_type.proto</summary>
  public static partial class ExtensionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/extension_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvZXh0ZW5zaW9uX3R5",
            "cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5lbnVtcyL+AQoR",
            "RXh0ZW5zaW9uVHlwZUVudW0i6AEKDUV4dGVuc2lvblR5cGUSDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESCAoETk9ORRACEgcKA0FQUBADEggKBENB",
            "TEwQBBILCgdDQUxMT1VUEAUSCwoHTUVTU0FHRRAGEgkKBVBSSUNFEAcSDQoJ",
            "UFJPTU9USU9OEAgSDAoIU0lURUxJTksQChIWChJTVFJVQ1RVUkVEX1NOSVBQ",
            "RVQQCxIMCghMT0NBVElPThAMEhYKEkFGRklMSUFURV9MT0NBVElPThANEhEK",
            "DUhPVEVMX0NBTExPVVQQDxIJCgVJTUFHRRAQQuwBCiJjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjExLmVudW1zQhJFeHRlbnNpb25UeXBlUHJvdG9QAVpD",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YxMS9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYxMS5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMVxF",
            "bnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMTo6RW51bXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum), global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeEnum.Types.ExtensionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible data types for an extension in an
  /// extension setting.
  /// </summary>
  public sealed partial class ExtensionTypeEnum : pb::IMessage<ExtensionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExtensionTypeEnum> _parser = new pb::MessageParser<ExtensionTypeEnum>(() => new ExtensionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExtensionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.ExtensionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionTypeEnum(ExtensionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionTypeEnum Clone() {
      return new ExtensionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExtensionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExtensionTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExtensionTypeEnum other) {
      if (other == null) {
        return;
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ExtensionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible data types for an extension in an extension setting.
      /// </summary>
      public enum ExtensionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// None.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 2,
        /// <summary>
        /// App.
        /// </summary>
        [pbr::OriginalName("APP")] App = 3,
        /// <summary>
        /// Call.
        /// </summary>
        [pbr::OriginalName("CALL")] Call = 4,
        /// <summary>
        /// Callout.
        /// </summary>
        [pbr::OriginalName("CALLOUT")] Callout = 5,
        /// <summary>
        /// Message.
        /// </summary>
        [pbr::OriginalName("MESSAGE")] Message = 6,
        /// <summary>
        /// Price.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 7,
        /// <summary>
        /// Promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION")] Promotion = 8,
        /// <summary>
        /// Sitelink.
        /// </summary>
        [pbr::OriginalName("SITELINK")] Sitelink = 10,
        /// <summary>
        /// Structured snippet.
        /// </summary>
        [pbr::OriginalName("STRUCTURED_SNIPPET")] StructuredSnippet = 11,
        /// <summary>
        /// Location.
        /// </summary>
        [pbr::OriginalName("LOCATION")] Location = 12,
        /// <summary>
        /// Affiliate location.
        /// </summary>
        [pbr::OriginalName("AFFILIATE_LOCATION")] AffiliateLocation = 13,
        /// <summary>
        /// Hotel callout
        /// </summary>
        [pbr::OriginalName("HOTEL_CALLOUT")] HotelCallout = 15,
        /// <summary>
        /// Image.
        /// </summary>
        [pbr::OriginalName("IMAGE")] Image = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
