// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/asset_group_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/asset_group_error.proto</summary>
  public static partial class AssetGroupErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/asset_group_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvYXNzZXRfZ3JvdXBf",
            "ZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVycm9ycxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byK+AwoTQXNzZXRHcm91cEVy",
            "cm9yRW51bSKmAwoPQXNzZXRHcm91cEVycm9yEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEhIKDkRVUExJQ0FURV9OQU1FEAISLAooQ0FOTk9UX0FE",
            "RF9BU1NFVF9HUk9VUF9GT1JfQ0FNUEFJR05fVFlQRRADEh0KGU5PVF9FTk9V",
            "R0hfSEVBRExJTkVfQVNTRVQQBBIiCh5OT1RfRU5PVUdIX0xPTkdfSEVBRExJ",
            "TkVfQVNTRVQQBRIgChxOT1RfRU5PVUdIX0RFU0NSSVBUSU9OX0FTU0VUEAYS",
            "IgoeTk9UX0VOT1VHSF9CVVNJTkVTU19OQU1FX0FTU0VUEAcSJAogTk9UX0VO",
            "T1VHSF9NQVJLRVRJTkdfSU1BR0VfQVNTRVQQCBIrCidOT1RfRU5PVUdIX1NR",
            "VUFSRV9NQVJLRVRJTkdfSU1BR0VfQVNTRVQQCRIZChVOT1RfRU5PVUdIX0xP",
            "R09fQVNTRVQQChI8CjhGSU5BTF9VUkxfU0hPUFBJTkdfTUVSQ0hBTlRfSE9N",
            "RV9QQUdFX1VSTF9ET01BSU5TX0RJRkZFUhALQu8BCiJjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjkuZXJyb3JzQhRBc3NldEdyb3VwRXJyb3JQcm90b1AB",
            "WkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjkvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlY5LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5",
            "XEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFcnJvcnNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.AssetGroupErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.AssetGroupErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.AssetGroupErrorEnum.Types.AssetGroupError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset group errors.
  /// </summary>
  public sealed partial class AssetGroupErrorEnum : pb::IMessage<AssetGroupErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupErrorEnum> _parser = new pb::MessageParser<AssetGroupErrorEnum>(() => new AssetGroupErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.AssetGroupErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupErrorEnum(AssetGroupErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupErrorEnum Clone() {
      return new AssetGroupErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupErrorEnum other) {
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
    public void MergeFrom(AssetGroupErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AssetGroupErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset group errors.
      /// </summary>
      public enum AssetGroupError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Each asset group in a single campaign must have a unique name.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 2,
        /// <summary>
        /// Cannot add asset group for the campaign type.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_ASSET_GROUP_FOR_CAMPAIGN_TYPE")] CannotAddAssetGroupForCampaignType = 3,
        /// <summary>
        /// Not enough headline asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_HEADLINE_ASSET")] NotEnoughHeadlineAsset = 4,
        /// <summary>
        /// Not enough long headline asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_LONG_HEADLINE_ASSET")] NotEnoughLongHeadlineAsset = 5,
        /// <summary>
        /// Not enough description headline asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_DESCRIPTION_ASSET")] NotEnoughDescriptionAsset = 6,
        /// <summary>
        /// Not enough business name asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_BUSINESS_NAME_ASSET")] NotEnoughBusinessNameAsset = 7,
        /// <summary>
        /// Not enough marketing image asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_MARKETING_IMAGE_ASSET")] NotEnoughMarketingImageAsset = 8,
        /// <summary>
        /// Not enough square marketing image asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_SQUARE_MARKETING_IMAGE_ASSET")] NotEnoughSquareMarketingImageAsset = 9,
        /// <summary>
        /// Not enough logo asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_LOGO_ASSET")] NotEnoughLogoAsset = 10,
        /// <summary>
        /// Final url and shopping merchant url does not have the same domain.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SHOPPING_MERCHANT_HOME_PAGE_URL_DOMAINS_DIFFER")] FinalUrlShoppingMerchantHomePageUrlDomainsDiffer = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
