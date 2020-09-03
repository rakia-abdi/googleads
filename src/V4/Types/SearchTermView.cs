// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/search_term_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/search_term_view.proto</summary>
  public static partial class SearchTermViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/search_term_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SearchTermViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMvc2VhcmNoX3Rl",
            "cm1fdmlldy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQucmVzb3Vy",
            "Y2VzGkBnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9zZWFyY2hfdGVy",
            "bV90YXJnZXRpbmdfc3RhdHVzLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8ivgMKDlNlYXJjaFRlcm1WaWV3EkYKDXJlc291cmNlX25h",
            "bWUYASABKAlCL+BBA/pBKQonZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL1Nl",
            "YXJjaFRlcm1WaWV3EjYKC3NlYXJjaF90ZXJtGAIgASgLMhwuZ29vZ2xlLnBy",
            "b3RvYnVmLlN0cmluZ1ZhbHVlQgPgQQMSWAoIYWRfZ3JvdXAYAyABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCKOBBA/pBIgogZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0FkR3JvdXASawoGc3RhdHVzGAQgASgOMlYuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjQuZW51bXMuU2VhcmNoVGVybVRhcmdldGlu",
            "Z1N0YXR1c0VudW0uU2VhcmNoVGVybVRhcmdldGluZ1N0YXR1c0ID4EEDOmXq",
            "QWIKJ2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9TZWFyY2hUZXJtVmlldxI3",
            "Y3VzdG9tZXJzL3tjdXN0b21lcn0vc2VhcmNoVGVybVZpZXdzL3tzZWFyY2hf",
            "dGVybV92aWV3fUKAAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnJl",
            "c291cmNlc0ITU2VhcmNoVGVybVZpZXdQcm90b1ABWkpnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQvcmVz",
            "b3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlY0LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XFJlc291",
            "cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY0OjpSZXNvdXJjZXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.SearchTermView), global::Google.Ads.GoogleAds.V4.Resources.SearchTermView.Parser, new[]{ "ResourceName", "SearchTerm", "AdGroup", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A search term view with metrics aggregated by search term at the ad group
  /// level.
  /// </summary>
  public sealed partial class SearchTermView : pb::IMessage<SearchTermView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SearchTermView> _parser = new pb::MessageParser<SearchTermView>(() => new SearchTermView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SearchTermView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Resources.SearchTermViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchTermView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchTermView(SearchTermView other) : this() {
      resourceName_ = other.resourceName_;
      SearchTerm = other.SearchTerm;
      AdGroup = other.AdGroup;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchTermView Clone() {
      return new SearchTermView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the search term view.
    /// Search term view resource names have the form:
    ///
    /// `customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{URL-base64_search_term}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_term" field.</summary>
    public const int SearchTermFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_searchTerm_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string searchTerm_;
    /// <summary>
    /// Output only. The search term.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SearchTerm {
      get { return searchTerm_; }
      set {
        searchTerm_ = value;
      }
    }


    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string adGroup_;
    /// <summary>
    /// Output only. The ad group the search term served in.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus status_ = global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified;
    /// <summary>
    /// Output only. Indicates whether the search term is currently one of your
    /// targeted or excluded keywords.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SearchTermView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SearchTermView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SearchTerm != other.SearchTerm) return false;
      if (AdGroup != other.AdGroup) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (searchTerm_ != null) hash ^= SearchTerm.GetHashCode();
      if (adGroup_ != null) hash ^= AdGroup.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (searchTerm_ != null) {
        _single_searchTerm_codec.WriteTagAndValue(output, SearchTerm);
      }
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(output, AdGroup);
      }
      if (Status != global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (searchTerm_ != null) {
        _single_searchTerm_codec.WriteTagAndValue(ref output, SearchTerm);
      }
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(ref output, AdGroup);
      }
      if (Status != global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (searchTerm_ != null) {
        size += _single_searchTerm_codec.CalculateSizeWithTag(SearchTerm);
      }
      if (adGroup_ != null) {
        size += _single_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      if (Status != global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SearchTermView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.searchTerm_ != null) {
        if (searchTerm_ == null || other.SearchTerm != "") {
          SearchTerm = other.SearchTerm;
        }
      }
      if (other.adGroup_ != null) {
        if (adGroup_ == null || other.AdGroup != "") {
          AdGroup = other.AdGroup;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            string value = _single_searchTerm_codec.Read(input);
            if (searchTerm_ == null || value != "") {
              SearchTerm = value;
            }
            break;
          }
          case 26: {
            string value = _single_adGroup_codec.Read(input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            string value = _single_searchTerm_codec.Read(ref input);
            if (searchTerm_ == null || value != "") {
              SearchTerm = value;
            }
            break;
          }
          case 26: {
            string value = _single_adGroup_codec.Read(ref input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V4.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus) input.ReadEnum();
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
