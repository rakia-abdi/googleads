// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/shared_criterion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/shared_criterion.proto</summary>
  public static partial class SharedCriterionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/shared_criterion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedCriterionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvc2hhcmVkX2Ny",
            "aXRlcmlvbi5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVzb3Vy",
            "Y2VzGi1nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9jb21tb24vY3JpdGVyaWEu",
            "cHJvdG8aMmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y3L2VudW1zL2NyaXRlcmlv",
            "bl90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3Rv",
            "Ghlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGhxnb29nbGUvYXBpL2Fubm90",
            "YXRpb25zLnByb3RvIpwHCg9TaGFyZWRDcml0ZXJpb24SRwoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCUIw4EEF+kEqCihnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "U2hhcmVkQ3JpdGVyaW9uEkMKCnNoYXJlZF9zZXQYCiABKAlCKuBBBfpBJAoi",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL1NoYXJlZFNldEgBiAEBEh4KDGNy",
            "aXRlcmlvbl9pZBgLIAEoA0ID4EEDSAKIAQESUQoEdHlwZRgEIAEoDjI+Lmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVudW1zLkNyaXRlcmlvblR5cGVFbnVt",
            "LkNyaXRlcmlvblR5cGVCA+BBAxJDCgdrZXl3b3JkGAMgASgLMisuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjcuY29tbW9uLktleXdvcmRJbmZvQgPgQQVIABJO",
            "Cg15b3V0dWJlX3ZpZGVvGAUgASgLMjAuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djcuY29tbW9uLllvdVR1YmVWaWRlb0luZm9CA+BBBUgAElIKD3lvdXR1YmVf",
            "Y2hhbm5lbBgGIAEoCzIyLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmNvbW1v",
            "bi5Zb3VUdWJlQ2hhbm5lbEluZm9CA+BBBUgAEkcKCXBsYWNlbWVudBgHIAEo",
            "CzItLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmNvbW1vbi5QbGFjZW1lbnRJ",
            "bmZvQgPgQQVIABJZChNtb2JpbGVfYXBwX2NhdGVnb3J5GAggASgLMjUuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjcuY29tbW9uLk1vYmlsZUFwcENhdGVnb3J5",
            "SW5mb0ID4EEFSAASWAoSbW9iaWxlX2FwcGxpY2F0aW9uGAkgASgLMjUuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjcuY29tbW9uLk1vYmlsZUFwcGxpY2F0aW9u",
            "SW5mb0ID4EEFSAA6dOpBcQooZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL1No",
            "YXJlZENyaXRlcmlvbhJFY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vc2hhcmVk",
            "Q3JpdGVyaWEve3NoYXJlZF9zZXRfaWR9fntjcml0ZXJpb25faWR9QgsKCWNy",
            "aXRlcmlvbkINCgtfc2hhcmVkX3NldEIPCg1fY3JpdGVyaW9uX2lkQoECCiVj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVzb3VyY2VzQhRTaGFyZWRD",
            "cml0ZXJpb25Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjcvcmVzb3VyY2VzO3Jlc291cmNl",
            "c6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY3LlJlc291cmNlc8oC",
            "IUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY3XFJlc291cmNlc+oCJUdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlY3OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.SharedCriterion), global::Google.Ads.GoogleAds.V7.Resources.SharedCriterion.Parser, new[]{ "ResourceName", "SharedSet", "CriterionId", "Type", "Keyword", "YoutubeVideo", "YoutubeChannel", "Placement", "MobileAppCategory", "MobileApplication" }, new[]{ "Criterion", "SharedSet", "CriterionId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A criterion belonging to a shared set.
  /// </summary>
  public sealed partial class SharedCriterion : pb::IMessage<SharedCriterion>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SharedCriterion> _parser = new pb::MessageParser<SharedCriterion>(() => new SharedCriterion());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SharedCriterion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.SharedCriterionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharedCriterion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharedCriterion(SharedCriterion other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      sharedSet_ = other.sharedSet_;
      criterionId_ = other.criterionId_;
      type_ = other.type_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.Keyword:
          Keyword = other.Keyword.Clone();
          break;
        case CriterionOneofCase.YoutubeVideo:
          YoutubeVideo = other.YoutubeVideo.Clone();
          break;
        case CriterionOneofCase.YoutubeChannel:
          YoutubeChannel = other.YoutubeChannel.Clone();
          break;
        case CriterionOneofCase.Placement:
          Placement = other.Placement.Clone();
          break;
        case CriterionOneofCase.MobileAppCategory:
          MobileAppCategory = other.MobileAppCategory.Clone();
          break;
        case CriterionOneofCase.MobileApplication:
          MobileApplication = other.MobileApplication.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharedCriterion Clone() {
      return new SharedCriterion(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the shared criterion.
    /// Shared set resource names have the form:
    ///
    /// `customers/{customer_id}/sharedCriteria/{shared_set_id}~{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shared_set" field.</summary>
    public const int SharedSetFieldNumber = 10;
    private string sharedSet_;
    /// <summary>
    /// Immutable. The shared set to which the shared criterion belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SharedSet {
      get { return sharedSet_ ?? ""; }
      set {
        sharedSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "shared_set" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSharedSet {
      get { return sharedSet_ != null; }
    }
    /// <summary>Clears the value of the "shared_set" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSharedSet() {
      sharedSet_ = null;
    }

    /// <summary>Field number for the "criterion_id" field.</summary>
    public const int CriterionIdFieldNumber = 11;
    private long criterionId_;
    /// <summary>
    /// Output only. The ID of the criterion.
    ///
    /// This field is ignored for mutates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CriterionId {
      get { if ((_hasBits0 & 1) != 0) { return criterionId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        criterionId_ = value;
      }
    }
    /// <summary>Gets whether the "criterion_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCriterionId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "criterion_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCriterionId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType type_ = global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified;
    /// <summary>
    /// Output only. The type of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "keyword" field.</summary>
    public const int KeywordFieldNumber = 3;
    /// <summary>
    /// Immutable. Keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.KeywordInfo Keyword {
      get { return criterionCase_ == CriterionOneofCase.Keyword ? (global::Google.Ads.GoogleAds.V7.Common.KeywordInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Keyword;
      }
    }

    /// <summary>Field number for the "youtube_video" field.</summary>
    public const int YoutubeVideoFieldNumber = 5;
    /// <summary>
    /// Immutable. YouTube Video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo YoutubeVideo {
      get { return criterionCase_ == CriterionOneofCase.YoutubeVideo ? (global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeVideo;
      }
    }

    /// <summary>Field number for the "youtube_channel" field.</summary>
    public const int YoutubeChannelFieldNumber = 6;
    /// <summary>
    /// Immutable. YouTube Channel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo YoutubeChannel {
      get { return criterionCase_ == CriterionOneofCase.YoutubeChannel ? (global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeChannel;
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 7;
    /// <summary>
    /// Immutable. Placement.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.PlacementInfo Placement {
      get { return criterionCase_ == CriterionOneofCase.Placement ? (global::Google.Ads.GoogleAds.V7.Common.PlacementInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Placement;
      }
    }

    /// <summary>Field number for the "mobile_app_category" field.</summary>
    public const int MobileAppCategoryFieldNumber = 8;
    /// <summary>
    /// Immutable. Mobile App Category.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo MobileAppCategory {
      get { return criterionCase_ == CriterionOneofCase.MobileAppCategory ? (global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileAppCategory;
      }
    }

    /// <summary>Field number for the "mobile_application" field.</summary>
    public const int MobileApplicationFieldNumber = 9;
    /// <summary>
    /// Immutable. Mobile application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo MobileApplication {
      get { return criterionCase_ == CriterionOneofCase.MobileApplication ? (global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileApplication;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      Keyword = 3,
      YoutubeVideo = 5,
      YoutubeChannel = 6,
      Placement = 7,
      MobileAppCategory = 8,
      MobileApplication = 9,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SharedCriterion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SharedCriterion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SharedSet != other.SharedSet) return false;
      if (CriterionId != other.CriterionId) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(Keyword, other.Keyword)) return false;
      if (!object.Equals(YoutubeVideo, other.YoutubeVideo)) return false;
      if (!object.Equals(YoutubeChannel, other.YoutubeChannel)) return false;
      if (!object.Equals(Placement, other.Placement)) return false;
      if (!object.Equals(MobileAppCategory, other.MobileAppCategory)) return false;
      if (!object.Equals(MobileApplication, other.MobileApplication)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasSharedSet) hash ^= SharedSet.GetHashCode();
      if (HasCriterionId) hash ^= CriterionId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) hash ^= Type.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Keyword) hash ^= Keyword.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) hash ^= YoutubeVideo.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) hash ^= YoutubeChannel.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Placement) hash ^= Placement.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) hash ^= MobileAppCategory.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileApplication) hash ^= MobileApplication.GetHashCode();
      hash ^= (int) criterionCase_;
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
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        output.WriteRawTag(26);
        output.WriteMessage(Keyword);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        output.WriteRawTag(42);
        output.WriteMessage(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        output.WriteRawTag(50);
        output.WriteMessage(YoutubeChannel);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        output.WriteRawTag(58);
        output.WriteMessage(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        output.WriteRawTag(66);
        output.WriteMessage(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        output.WriteRawTag(74);
        output.WriteMessage(MobileApplication);
      }
      if (HasSharedSet) {
        output.WriteRawTag(82);
        output.WriteString(SharedSet);
      }
      if (HasCriterionId) {
        output.WriteRawTag(88);
        output.WriteInt64(CriterionId);
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
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        output.WriteRawTag(26);
        output.WriteMessage(Keyword);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        output.WriteRawTag(42);
        output.WriteMessage(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        output.WriteRawTag(50);
        output.WriteMessage(YoutubeChannel);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        output.WriteRawTag(58);
        output.WriteMessage(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        output.WriteRawTag(66);
        output.WriteMessage(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        output.WriteRawTag(74);
        output.WriteMessage(MobileApplication);
      }
      if (HasSharedSet) {
        output.WriteRawTag(82);
        output.WriteString(SharedSet);
      }
      if (HasCriterionId) {
        output.WriteRawTag(88);
        output.WriteInt64(CriterionId);
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
      if (HasSharedSet) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SharedSet);
      }
      if (HasCriterionId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CriterionId);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Keyword);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeChannel);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileApplication);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SharedCriterion other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasSharedSet) {
        SharedSet = other.SharedSet;
      }
      if (other.HasCriterionId) {
        CriterionId = other.CriterionId;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        Type = other.Type;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.Keyword:
          if (Keyword == null) {
            Keyword = new global::Google.Ads.GoogleAds.V7.Common.KeywordInfo();
          }
          Keyword.MergeFrom(other.Keyword);
          break;
        case CriterionOneofCase.YoutubeVideo:
          if (YoutubeVideo == null) {
            YoutubeVideo = new global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo();
          }
          YoutubeVideo.MergeFrom(other.YoutubeVideo);
          break;
        case CriterionOneofCase.YoutubeChannel:
          if (YoutubeChannel == null) {
            YoutubeChannel = new global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo();
          }
          YoutubeChannel.MergeFrom(other.YoutubeChannel);
          break;
        case CriterionOneofCase.Placement:
          if (Placement == null) {
            Placement = new global::Google.Ads.GoogleAds.V7.Common.PlacementInfo();
          }
          Placement.MergeFrom(other.Placement);
          break;
        case CriterionOneofCase.MobileAppCategory:
          if (MobileAppCategory == null) {
            MobileAppCategory = new global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo();
          }
          MobileAppCategory.MergeFrom(other.MobileAppCategory);
          break;
        case CriterionOneofCase.MobileApplication:
          if (MobileApplication == null) {
            MobileApplication = new global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo();
          }
          MobileApplication.MergeFrom(other.MobileApplication);
          break;
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
          case 26: {
            global::Google.Ads.GoogleAds.V7.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.KeywordInfo();
            if (criterionCase_ == CriterionOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
              subBuilder.MergeFrom(YoutubeVideo);
            }
            input.ReadMessage(subBuilder);
            YoutubeVideo = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
              subBuilder.MergeFrom(YoutubeChannel);
            }
            input.ReadMessage(subBuilder);
            YoutubeChannel = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V7.Common.PlacementInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.PlacementInfo();
            if (criterionCase_ == CriterionOneofCase.Placement) {
              subBuilder.MergeFrom(Placement);
            }
            input.ReadMessage(subBuilder);
            Placement = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo();
            if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
              subBuilder.MergeFrom(MobileAppCategory);
            }
            input.ReadMessage(subBuilder);
            MobileAppCategory = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo();
            if (criterionCase_ == CriterionOneofCase.MobileApplication) {
              subBuilder.MergeFrom(MobileApplication);
            }
            input.ReadMessage(subBuilder);
            MobileApplication = subBuilder;
            break;
          }
          case 82: {
            SharedSet = input.ReadString();
            break;
          }
          case 88: {
            CriterionId = input.ReadInt64();
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
          case 26: {
            global::Google.Ads.GoogleAds.V7.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.KeywordInfo();
            if (criterionCase_ == CriterionOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V7.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.YouTubeVideoInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
              subBuilder.MergeFrom(YoutubeVideo);
            }
            input.ReadMessage(subBuilder);
            YoutubeVideo = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.YouTubeChannelInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
              subBuilder.MergeFrom(YoutubeChannel);
            }
            input.ReadMessage(subBuilder);
            YoutubeChannel = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V7.Common.PlacementInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.PlacementInfo();
            if (criterionCase_ == CriterionOneofCase.Placement) {
              subBuilder.MergeFrom(Placement);
            }
            input.ReadMessage(subBuilder);
            Placement = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.MobileAppCategoryInfo();
            if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
              subBuilder.MergeFrom(MobileAppCategory);
            }
            input.ReadMessage(subBuilder);
            MobileAppCategory = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo subBuilder = new global::Google.Ads.GoogleAds.V7.Common.MobileApplicationInfo();
            if (criterionCase_ == CriterionOneofCase.MobileApplication) {
              subBuilder.MergeFrom(MobileApplication);
            }
            input.ReadMessage(subBuilder);
            MobileApplication = subBuilder;
            break;
          }
          case 82: {
            SharedSet = input.ReadString();
            break;
          }
          case 88: {
            CriterionId = input.ReadInt64();
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
