// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/dynamic_search_ads_search_term_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/dynamic_search_ads_search_term_view_service.proto</summary>
  public static partial class DynamicSearchAdsSearchTermViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/dynamic_search_ads_search_term_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DynamicSearchAdsSearchTermViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9keW5hbWljX3Nl",
            "YXJjaF9hZHNfc2VhcmNoX3Rlcm1fdmlld19zZXJ2aWNlLnByb3RvEiBnb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNlcxpLZ29vZ2xlL2Fkcy9nb29n",
            "bGVhZHMvdjMvcmVzb3VyY2VzL2R5bmFtaWNfc2VhcmNoX2Fkc19zZWFyY2hf",
            "dGVybV92aWV3LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "Ghdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKCAQoo",
            "R2V0RHluYW1pY1NlYXJjaEFkc1NlYXJjaFRlcm1WaWV3UmVxdWVzdBJWCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQj/gQQL6QTkKN2dvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9EeW5hbWljU2VhcmNoQWRzU2VhcmNoVGVybVZpZXcy1AIKJUR5",
            "bmFtaWNTZWFyY2hBZHNTZWFyY2hUZXJtVmlld1NlcnZpY2USjQIKIUdldER5",
            "bmFtaWNTZWFyY2hBZHNTZWFyY2hUZXJtVmlldxJKLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYzLnNlcnZpY2VzLkdldER5bmFtaWNTZWFyY2hBZHNTZWFyY2hU",
            "ZXJtVmlld1JlcXVlc3QaQS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5yZXNv",
            "dXJjZXMuRHluYW1pY1NlYXJjaEFkc1NlYXJjaFRlcm1WaWV3IlmC0+STAkMS",
            "QS92My97cmVzb3VyY2VfbmFtZT1jdXN0b21lcnMvKi9keW5hbWljU2VhcmNo",
            "QWRzU2VhcmNoVGVybVZpZXdzLyp92kENcmVzb3VyY2VfbmFtZRobykEYZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tQpECCiRjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMuc2VydmljZXNCKkR5bmFtaWNTZWFyY2hBZHNTZWFyY2hUZXJt",
            "Vmlld1NlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvc2VydmljZXM7c2Vydmlj",
            "ZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WMy5TZXJ2aWNlc8oC",
            "IEdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXFNlcnZpY2Vz6gIkR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjM6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.DynamicSearchAdsSearchTermViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetDynamicSearchAdsSearchTermViewRequest), global::Google.Ads.GoogleAds.V3.Services.GetDynamicSearchAdsSearchTermViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [DynamicSearchAdsSearchTermViewService.GetDynamicSearchAdsSearchTermView][google.ads.googleads.v3.services.DynamicSearchAdsSearchTermViewService.GetDynamicSearchAdsSearchTermView].
  /// </summary>
  public sealed partial class GetDynamicSearchAdsSearchTermViewRequest : pb::IMessage<GetDynamicSearchAdsSearchTermViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetDynamicSearchAdsSearchTermViewRequest> _parser = new pb::MessageParser<GetDynamicSearchAdsSearchTermViewRequest>(() => new GetDynamicSearchAdsSearchTermViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetDynamicSearchAdsSearchTermViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.DynamicSearchAdsSearchTermViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDynamicSearchAdsSearchTermViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDynamicSearchAdsSearchTermViewRequest(GetDynamicSearchAdsSearchTermViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDynamicSearchAdsSearchTermViewRequest Clone() {
      return new GetDynamicSearchAdsSearchTermViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the dynamic search ads search term view to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetDynamicSearchAdsSearchTermViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetDynamicSearchAdsSearchTermViewRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetDynamicSearchAdsSearchTermViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
