// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/group_placement_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/group_placement_view.proto</summary>
  public static partial class GroupPlacementViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/group_placement_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupPlacementViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2dyb3VwX3Bs",
            "YWNlbWVudF92aWV3LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTAu",
            "cmVzb3VyY2VzGjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvcGxh",
            "Y2VtZW50X3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8ixwMKEkdyb3VwUGxh",
            "Y2VtZW50VmlldxJKCg1yZXNvdXJjZV9uYW1lGAEgASgJQjPgQQP6QS0KK2dv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Hcm91cFBsYWNlbWVudFZpZXcSGwoJ",
            "cGxhY2VtZW50GAYgASgJQgPgQQNIAIgBARIeCgxkaXNwbGF5X25hbWUYByAB",
            "KAlCA+BBA0gBiAEBEhwKCnRhcmdldF91cmwYCCABKAlCA+BBA0gCiAEBElwK",
            "DnBsYWNlbWVudF90eXBlGAUgASgOMj8uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEwLmVudW1zLlBsYWNlbWVudFR5cGVFbnVtLlBsYWNlbWVudFR5cGVCA+BB",
            "Azp+6kF7Citnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vR3JvdXBQbGFjZW1l",
            "bnRWaWV3EkxjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9ncm91cFBsYWNlbWVu",
            "dFZpZXdzL3thZF9ncm91cF9pZH1+e2Jhc2U2NF9wbGFjZW1lbnR9QgwKCl9w",
            "bGFjZW1lbnRCDwoNX2Rpc3BsYXlfbmFtZUINCgtfdGFyZ2V0X3VybEKJAgom",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5yZXNvdXJjZXNCF0dyb3Vw",
            "UGxhY2VtZW50Vmlld1Byb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzO3Jl",
            "c291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMC5SZXNv",
            "dXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcUmVzb3VyY2Vz6gIm",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpSZXNvdXJjZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.GroupPlacementView), global::Google.Ads.GoogleAds.V10.Resources.GroupPlacementView.Parser, new[]{ "ResourceName", "Placement", "DisplayName", "TargetUrl", "PlacementType" }, new[]{ "Placement", "DisplayName", "TargetUrl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A group placement view.
  /// </summary>
  public sealed partial class GroupPlacementView : pb::IMessage<GroupPlacementView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupPlacementView> _parser = new pb::MessageParser<GroupPlacementView>(() => new GroupPlacementView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupPlacementView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.GroupPlacementViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupPlacementView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupPlacementView(GroupPlacementView other) : this() {
      resourceName_ = other.resourceName_;
      placement_ = other.placement_;
      displayName_ = other.displayName_;
      targetUrl_ = other.targetUrl_;
      placementType_ = other.placementType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupPlacementView Clone() {
      return new GroupPlacementView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the group placement view.
    /// Group placement view resource names have the form:
    ///
    /// `customers/{customer_id}/groupPlacementViews/{ad_group_id}~{base64_placement}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 6;
    private string placement_;
    /// <summary>
    /// Output only. The automatic placement string at group level, e. g. web domain, mobile
    /// app ID, or a YouTube channel ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Placement {
      get { return placement_ ?? ""; }
      set {
        placement_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "placement" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPlacement {
      get { return placement_ != null; }
    }
    /// <summary>Clears the value of the "placement" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPlacement() {
      placement_ = null;
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 7;
    private string displayName_;
    /// <summary>
    /// Output only. Domain name for websites and YouTube channel name for YouTube channels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_ ?? ""; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "display_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDisplayName {
      get { return displayName_ != null; }
    }
    /// <summary>Clears the value of the "display_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDisplayName() {
      displayName_ = null;
    }

    /// <summary>Field number for the "target_url" field.</summary>
    public const int TargetUrlFieldNumber = 8;
    private string targetUrl_;
    /// <summary>
    /// Output only. URL of the group placement, for example, domain, link to the mobile
    /// application in app store, or a YouTube channel URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetUrl {
      get { return targetUrl_ ?? ""; }
      set {
        targetUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "target_url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTargetUrl {
      get { return targetUrl_ != null; }
    }
    /// <summary>Clears the value of the "target_url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTargetUrl() {
      targetUrl_ = null;
    }

    /// <summary>Field number for the "placement_type" field.</summary>
    public const int PlacementTypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType placementType_ = global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified;
    /// <summary>
    /// Output only. Type of the placement, for example, Website, YouTube Channel, Mobile
    /// Application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType PlacementType {
      get { return placementType_; }
      set {
        placementType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupPlacementView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupPlacementView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Placement != other.Placement) return false;
      if (DisplayName != other.DisplayName) return false;
      if (TargetUrl != other.TargetUrl) return false;
      if (PlacementType != other.PlacementType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasPlacement) hash ^= Placement.GetHashCode();
      if (HasDisplayName) hash ^= DisplayName.GetHashCode();
      if (HasTargetUrl) hash ^= TargetUrl.GetHashCode();
      if (PlacementType != global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) hash ^= PlacementType.GetHashCode();
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
      if (PlacementType != global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) PlacementType);
      }
      if (HasPlacement) {
        output.WriteRawTag(50);
        output.WriteString(Placement);
      }
      if (HasDisplayName) {
        output.WriteRawTag(58);
        output.WriteString(DisplayName);
      }
      if (HasTargetUrl) {
        output.WriteRawTag(66);
        output.WriteString(TargetUrl);
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
      if (PlacementType != global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) PlacementType);
      }
      if (HasPlacement) {
        output.WriteRawTag(50);
        output.WriteString(Placement);
      }
      if (HasDisplayName) {
        output.WriteRawTag(58);
        output.WriteString(DisplayName);
      }
      if (HasTargetUrl) {
        output.WriteRawTag(66);
        output.WriteString(TargetUrl);
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
      if (HasPlacement) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Placement);
      }
      if (HasDisplayName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (HasTargetUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlacementType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupPlacementView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasPlacement) {
        Placement = other.Placement;
      }
      if (other.HasDisplayName) {
        DisplayName = other.DisplayName;
      }
      if (other.HasTargetUrl) {
        TargetUrl = other.TargetUrl;
      }
      if (other.PlacementType != global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        PlacementType = other.PlacementType;
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
          case 40: {
            PlacementType = (global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
            break;
          }
          case 50: {
            Placement = input.ReadString();
            break;
          }
          case 58: {
            DisplayName = input.ReadString();
            break;
          }
          case 66: {
            TargetUrl = input.ReadString();
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
          case 40: {
            PlacementType = (global::Google.Ads.GoogleAds.V10.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
            break;
          }
          case 50: {
            Placement = input.ReadString();
            break;
          }
          case 58: {
            DisplayName = input.ReadString();
            break;
          }
          case 66: {
            TargetUrl = input.ReadString();
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
