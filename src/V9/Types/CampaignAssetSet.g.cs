// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/campaign_asset_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/campaign_asset_set.proto</summary>
  public static partial class CampaignAssetSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/campaign_asset_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignAssetSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "YXNzZXRfc2V0LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNv",
            "dXJjZXMaOWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y5L2VudW1zL2Fzc2V0X3Nl",
            "dF9saW5rX3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byKuAwoQQ2FtcGFpZ25Bc3NldFNldBJICg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQjHgQQX6QSsKKWdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9DYW1wYWlnbkFzc2V0U2V0EjsKCGNhbXBhaWduGAIgASgJQing",
            "QQX6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbhI8Cglh",
            "c3NldF9zZXQYAyABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0Fzc2V0U2V0El0KBnN0YXR1cxgEIAEoDjJILmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY5LmVudW1zLkFzc2V0U2V0TGlua1N0YXR1c0VudW0uQXNzZXRT",
            "ZXRMaW5rU3RhdHVzQgPgQQM6dupBcwopZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0NhbXBhaWduQXNzZXRTZXQSRmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9",
            "L2NhbXBhaWduQXNzZXRTZXRzL3tjYW1wYWlnbl9pZH1+e2Fzc2V0X3NldF9p",
            "ZH1CggIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNvdXJjZXNC",
            "FUNhbXBhaWduQXNzZXRTZXRQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvcmVzb3VyY2Vz",
            "O3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LlJl",
            "c291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XFJlc291cmNlc+oC",
            "JUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpSZXNvdXJjZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.CampaignAssetSet), global::Google.Ads.GoogleAds.V9.Resources.CampaignAssetSet.Parser, new[]{ "ResourceName", "Campaign", "AssetSet", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CampaignAssetSet is the linkage between a campaign and an asset set.
  /// Adding a CampaignAssetSet links an asset set with a campaign.
  /// </summary>
  public sealed partial class CampaignAssetSet : pb::IMessage<CampaignAssetSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignAssetSet> _parser = new pb::MessageParser<CampaignAssetSet>(() => new CampaignAssetSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignAssetSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.CampaignAssetSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignAssetSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignAssetSet(CampaignAssetSet other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      assetSet_ = other.assetSet_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignAssetSet Clone() {
      return new CampaignAssetSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign asset set.
    /// Asset set asset resource names have the form:
    ///
    /// `customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 2;
    private string campaign_ = "";
    /// <summary>
    /// Immutable. The campaign to which this asset set is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_set" field.</summary>
    public const int AssetSetFieldNumber = 3;
    private string assetSet_ = "";
    /// <summary>
    /// Immutable. The asset set which is linked to the campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetSet {
      get { return assetSet_; }
      set {
        assetSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus status_ = global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the campaign asset set asset. Read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignAssetSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignAssetSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (AssetSet != other.AssetSet) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (AssetSet.Length != 0) hash ^= AssetSet.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (AssetSet.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AssetSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (AssetSet.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AssetSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
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
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (AssetSet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignAssetSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.AssetSet.Length != 0) {
        AssetSet = other.AssetSet;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Campaign = input.ReadString();
            break;
          }
          case 26: {
            AssetSet = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus) input.ReadEnum();
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Campaign = input.ReadString();
            break;
          }
          case 26: {
            AssetSet = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus) input.ReadEnum();
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
