// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/campaign_criterion_simulation_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/campaign_criterion_simulation_service.proto</summary>
  public static partial class CampaignCriterionSimulationServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/campaign_criterion_simulation_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionSimulationServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9jYW1wYWlnbl9j",
            "cml0ZXJpb25fc2ltdWxhdGlvbl9zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5zZXJ2aWNlcxpFZ29vZ2xlL2Fkcy9nb29nbGVhZHMv",
            "djMvcmVzb3VyY2VzL2NhbXBhaWduX2NyaXRlcmlvbl9zaW11bGF0aW9uLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBp",
            "L2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJ8CiVHZXRDYW1wYWlnbkNy",
            "aXRlcmlvblNpbXVsYXRpb25SZXF1ZXN0ElMKDXJlc291cmNlX25hbWUYASAB",
            "KAlCPOBBAvpBNgo0Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWdu",
            "Q3JpdGVyaW9uU2ltdWxhdGlvbjLFAgoiQ2FtcGFpZ25Dcml0ZXJpb25TaW11",
            "bGF0aW9uU2VydmljZRKBAgoeR2V0Q2FtcGFpZ25Dcml0ZXJpb25TaW11bGF0",
            "aW9uEkcuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuc2VydmljZXMuR2V0Q2Ft",
            "cGFpZ25Dcml0ZXJpb25TaW11bGF0aW9uUmVxdWVzdBo+Lmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYzLnJlc291cmNlcy5DYW1wYWlnbkNyaXRlcmlvblNpbXVs",
            "YXRpb24iVoLT5JMCQBI+L3YzL3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8q",
            "L2NhbXBhaWduQ3JpdGVyaW9uU2ltdWxhdGlvbnMvKn3aQQ1yZXNvdXJjZV9u",
            "YW1lGhvKQRhnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb21CjgIKJGNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNlc0InQ2FtcGFpZ25Dcml0ZXJp",
            "b25TaW11bGF0aW9uU2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNl",
            "cztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLlNl",
            "cnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcU2VydmljZXPqAiRH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.CampaignCriterionSimulationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetCampaignCriterionSimulationRequest), global::Google.Ads.GoogleAds.V3.Services.GetCampaignCriterionSimulationRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [CampaignCriterionSimulationService.GetCampaignCriterionSimulation][google.ads.googleads.v3.services.CampaignCriterionSimulationService.GetCampaignCriterionSimulation].
  /// </summary>
  public sealed partial class GetCampaignCriterionSimulationRequest : pb::IMessage<GetCampaignCriterionSimulationRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCampaignCriterionSimulationRequest> _parser = new pb::MessageParser<GetCampaignCriterionSimulationRequest>(() => new GetCampaignCriterionSimulationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCampaignCriterionSimulationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.CampaignCriterionSimulationServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignCriterionSimulationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignCriterionSimulationRequest(GetCampaignCriterionSimulationRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignCriterionSimulationRequest Clone() {
      return new GetCampaignCriterionSimulationRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the campaign criterion simulation to fetch.
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
      return Equals(other as GetCampaignCriterionSimulationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCampaignCriterionSimulationRequest other) {
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
    public void MergeFrom(GetCampaignCriterionSimulationRequest other) {
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
