// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/campaign_experiment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/campaign_experiment.proto</summary>
  public static partial class CampaignExperimentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/campaign_experiment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignExperimentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "ZXhwZXJpbWVudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjgucmVz",
            "b3VyY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9jYW1wYWln",
            "bl9leHBlcmltZW50X3N0YXR1cy5wcm90bxpKZ29vZ2xlL2Fkcy9nb29nbGVh",
            "ZHMvdjgvZW51bXMvY2FtcGFpZ25fZXhwZXJpbWVudF90cmFmZmljX3NwbGl0",
            "X3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8a",
            "GWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8iywcKEkNhbXBhaWduRXhwZXJpbWVudBJKCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQjPgQQX6QS0KK2dvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9DYW1wYWlnbkV4cGVyaW1lbnQSFAoCaWQYDSABKANCA+BBA0gAiAEBEksK",
            "DmNhbXBhaWduX2RyYWZ0GA4gASgJQi7gQQX6QSgKJmdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9DYW1wYWlnbkRyYWZ0SAGIAQESEQoEbmFtZRgPIAEoCUgC",
            "iAEBEhgKC2Rlc2NyaXB0aW9uGBAgASgJSAOIAQESJwoVdHJhZmZpY19zcGxp",
            "dF9wZXJjZW50GBEgASgDQgPgQQVIBIgBARKJAQoSdHJhZmZpY19zcGxpdF90",
            "eXBlGAcgASgOMmguZ29vZ2xlLmFkcy5nb29nbGVhZHMudjguZW51bXMuQ2Ft",
            "cGFpZ25FeHBlcmltZW50VHJhZmZpY1NwbGl0VHlwZUVudW0uQ2FtcGFpZ25F",
            "eHBlcmltZW50VHJhZmZpY1NwbGl0VHlwZUID4EEFEksKE2V4cGVyaW1lbnRf",
            "Y2FtcGFpZ24YEiABKAlCKeBBA/pBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0NhbXBhaWduSAWIAQESaQoGc3RhdHVzGAkgASgOMlQuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjguZW51bXMuQ2FtcGFpZ25FeHBlcmltZW50U3RhdHVz",
            "RW51bS5DYW1wYWlnbkV4cGVyaW1lbnRTdGF0dXNCA+BBAxIoChZsb25nX3J1",
            "bm5pbmdfb3BlcmF0aW9uGBMgASgJQgPgQQNIBogBARIXCgpzdGFydF9kYXRl",
            "GBQgASgJSAeIAQESFQoIZW5kX2RhdGUYFSABKAlICIgBATp26kFzCitnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25FeHBlcmltZW50EkRjdXN0",
            "b21lcnMve2N1c3RvbWVyX2lkfS9jYW1wYWlnbkV4cGVyaW1lbnRzL3tjYW1w",
            "YWlnbl9leHBlcmltZW50X2lkfUIFCgNfaWRCEQoPX2NhbXBhaWduX2RyYWZ0",
            "QgcKBV9uYW1lQg4KDF9kZXNjcmlwdGlvbkIYChZfdHJhZmZpY19zcGxpdF9w",
            "ZXJjZW50QhYKFF9leHBlcmltZW50X2NhbXBhaWduQhkKF19sb25nX3J1bm5p",
            "bmdfb3BlcmF0aW9uQg0KC19zdGFydF9kYXRlQgsKCV9lbmRfZGF0ZUKEAgol",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LnJlc291cmNlc0IXQ2FtcGFp",
            "Z25FeHBlcmltZW50UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y4L3Jlc291cmNlcztyZXNv",
            "dXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WOC5SZXNvdXJj",
            "ZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWOFxSZXNvdXJjZXPqAiVHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWODo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.CampaignExperiment), global::Google.Ads.GoogleAds.V8.Resources.CampaignExperiment.Parser, new[]{ "ResourceName", "Id", "CampaignDraft", "Name", "Description", "TrafficSplitPercent", "TrafficSplitType", "ExperimentCampaign", "Status", "LongRunningOperation", "StartDate", "EndDate" }, new[]{ "Id", "CampaignDraft", "Name", "Description", "TrafficSplitPercent", "ExperimentCampaign", "LongRunningOperation", "StartDate", "EndDate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An A/B experiment that compares the performance of the base campaign
  /// (the control) and a variation of that campaign (the experiment).
  /// </summary>
  public sealed partial class CampaignExperiment : pb::IMessage<CampaignExperiment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignExperiment> _parser = new pb::MessageParser<CampaignExperiment>(() => new CampaignExperiment());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignExperiment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Resources.CampaignExperimentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperiment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperiment(CampaignExperiment other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      campaignDraft_ = other.campaignDraft_;
      name_ = other.name_;
      description_ = other.description_;
      trafficSplitPercent_ = other.trafficSplitPercent_;
      trafficSplitType_ = other.trafficSplitType_;
      experimentCampaign_ = other.experimentCampaign_;
      status_ = other.status_;
      longRunningOperation_ = other.longRunningOperation_;
      startDate_ = other.startDate_;
      endDate_ = other.endDate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperiment Clone() {
      return new CampaignExperiment(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign experiment.
    /// Campaign experiment resource names have the form:
    ///
    /// `customers/{customer_id}/campaignExperiments/{campaign_experiment_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 13;
    private long id_;
    /// <summary>
    /// Output only. The ID of the campaign experiment.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "campaign_draft" field.</summary>
    public const int CampaignDraftFieldNumber = 14;
    private string campaignDraft_;
    /// <summary>
    /// Immutable. The campaign draft with staged changes to the base campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CampaignDraft {
      get { return campaignDraft_ ?? ""; }
      set {
        campaignDraft_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign_draft" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaignDraft {
      get { return campaignDraft_ != null; }
    }
    /// <summary>Clears the value of the "campaign_draft" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaignDraft() {
      campaignDraft_ = null;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 15;
    private string name_;
    /// <summary>
    /// The name of the campaign experiment.
    ///
    /// This field is required when creating new campaign experiments
    /// and must not conflict with the name of another non-removed
    /// campaign experiment or campaign.
    ///
    /// It must not contain any null (code point 0x0), NL line feed
    /// (code point 0xA) or carriage return (code point 0xD) characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 16;
    private string description_;
    /// <summary>
    /// The description of the experiment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_ ?? ""; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "description" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDescription {
      get { return description_ != null; }
    }
    /// <summary>Clears the value of the "description" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDescription() {
      description_ = null;
    }

    /// <summary>Field number for the "traffic_split_percent" field.</summary>
    public const int TrafficSplitPercentFieldNumber = 17;
    private long trafficSplitPercent_;
    /// <summary>
    /// Immutable. Share of traffic directed to experiment as a percent (must be between 1 and
    /// 99 inclusive. Base campaign receives the remainder of the traffic
    /// (100 - traffic_split_percent). Required for create.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TrafficSplitPercent {
      get { if ((_hasBits0 & 2) != 0) { return trafficSplitPercent_; } else { return 0L; } }
      set {
        _hasBits0 |= 2;
        trafficSplitPercent_ = value;
      }
    }
    /// <summary>Gets whether the "traffic_split_percent" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTrafficSplitPercent {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "traffic_split_percent" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTrafficSplitPercent() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "traffic_split_type" field.</summary>
    public const int TrafficSplitTypeFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType trafficSplitType_ = global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified;
    /// <summary>
    /// Immutable. Determines the behavior of the traffic split.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType TrafficSplitType {
      get { return trafficSplitType_; }
      set {
        trafficSplitType_ = value;
      }
    }

    /// <summary>Field number for the "experiment_campaign" field.</summary>
    public const int ExperimentCampaignFieldNumber = 18;
    private string experimentCampaign_;
    /// <summary>
    /// Output only. The experiment campaign, as opposed to the base campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExperimentCampaign {
      get { return experimentCampaign_ ?? ""; }
      set {
        experimentCampaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "experiment_campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasExperimentCampaign {
      get { return experimentCampaign_ != null; }
    }
    /// <summary>Clears the value of the "experiment_campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearExperimentCampaign() {
      experimentCampaign_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 9;
    private global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus status_ = global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the campaign experiment. This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "long_running_operation" field.</summary>
    public const int LongRunningOperationFieldNumber = 19;
    private string longRunningOperation_;
    /// <summary>
    /// Output only. The resource name of the long-running operation that can be used to poll
    /// for completion of experiment create or promote. The most recent long
    /// running operation is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LongRunningOperation {
      get { return longRunningOperation_ ?? ""; }
      set {
        longRunningOperation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "long_running_operation" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLongRunningOperation {
      get { return longRunningOperation_ != null; }
    }
    /// <summary>Clears the value of the "long_running_operation" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLongRunningOperation() {
      longRunningOperation_ = null;
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 20;
    private string startDate_;
    /// <summary>
    /// Date when the campaign experiment starts. By default, the experiment starts
    /// now or on the campaign's start date, whichever is later. If this field is
    /// set, then the experiment starts at the beginning of the specified date in
    /// the customer's time zone. Cannot be changed once the experiment starts.
    ///
    /// Format: YYYY-MM-DD
    /// Example: 2019-03-14
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDate {
      get { return startDate_ ?? ""; }
      set {
        startDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "start_date" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasStartDate {
      get { return startDate_ != null; }
    }
    /// <summary>Clears the value of the "start_date" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearStartDate() {
      startDate_ = null;
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 21;
    private string endDate_;
    /// <summary>
    /// The last day of the campaign experiment. By default, the experiment ends on
    /// the campaign's end date. If this field is set, then the experiment ends at
    /// the end of the specified date in the customer's time zone.
    ///
    /// Format: YYYY-MM-DD
    /// Example: 2019-04-18
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDate {
      get { return endDate_ ?? ""; }
      set {
        endDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "end_date" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEndDate {
      get { return endDate_ != null; }
    }
    /// <summary>Clears the value of the "end_date" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEndDate() {
      endDate_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignExperiment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignExperiment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (CampaignDraft != other.CampaignDraft) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (TrafficSplitPercent != other.TrafficSplitPercent) return false;
      if (TrafficSplitType != other.TrafficSplitType) return false;
      if (ExperimentCampaign != other.ExperimentCampaign) return false;
      if (Status != other.Status) return false;
      if (LongRunningOperation != other.LongRunningOperation) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasCampaignDraft) hash ^= CampaignDraft.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasDescription) hash ^= Description.GetHashCode();
      if (HasTrafficSplitPercent) hash ^= TrafficSplitPercent.GetHashCode();
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) hash ^= TrafficSplitType.GetHashCode();
      if (HasExperimentCampaign) hash ^= ExperimentCampaign.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) hash ^= Status.GetHashCode();
      if (HasLongRunningOperation) hash ^= LongRunningOperation.GetHashCode();
      if (HasStartDate) hash ^= StartDate.GetHashCode();
      if (HasEndDate) hash ^= EndDate.GetHashCode();
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
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) TrafficSplitType);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Status);
      }
      if (HasId) {
        output.WriteRawTag(104);
        output.WriteInt64(Id);
      }
      if (HasCampaignDraft) {
        output.WriteRawTag(114);
        output.WriteString(CampaignDraft);
      }
      if (HasName) {
        output.WriteRawTag(122);
        output.WriteString(Name);
      }
      if (HasDescription) {
        output.WriteRawTag(130, 1);
        output.WriteString(Description);
      }
      if (HasTrafficSplitPercent) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(TrafficSplitPercent);
      }
      if (HasExperimentCampaign) {
        output.WriteRawTag(146, 1);
        output.WriteString(ExperimentCampaign);
      }
      if (HasLongRunningOperation) {
        output.WriteRawTag(154, 1);
        output.WriteString(LongRunningOperation);
      }
      if (HasStartDate) {
        output.WriteRawTag(162, 1);
        output.WriteString(StartDate);
      }
      if (HasEndDate) {
        output.WriteRawTag(170, 1);
        output.WriteString(EndDate);
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
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) TrafficSplitType);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Status);
      }
      if (HasId) {
        output.WriteRawTag(104);
        output.WriteInt64(Id);
      }
      if (HasCampaignDraft) {
        output.WriteRawTag(114);
        output.WriteString(CampaignDraft);
      }
      if (HasName) {
        output.WriteRawTag(122);
        output.WriteString(Name);
      }
      if (HasDescription) {
        output.WriteRawTag(130, 1);
        output.WriteString(Description);
      }
      if (HasTrafficSplitPercent) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(TrafficSplitPercent);
      }
      if (HasExperimentCampaign) {
        output.WriteRawTag(146, 1);
        output.WriteString(ExperimentCampaign);
      }
      if (HasLongRunningOperation) {
        output.WriteRawTag(154, 1);
        output.WriteString(LongRunningOperation);
      }
      if (HasStartDate) {
        output.WriteRawTag(162, 1);
        output.WriteString(StartDate);
      }
      if (HasEndDate) {
        output.WriteRawTag(170, 1);
        output.WriteString(EndDate);
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
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasCampaignDraft) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CampaignDraft);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasDescription) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (HasTrafficSplitPercent) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(TrafficSplitPercent);
      }
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TrafficSplitType);
      }
      if (HasExperimentCampaign) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExperimentCampaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (HasLongRunningOperation) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(LongRunningOperation);
      }
      if (HasStartDate) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(StartDate);
      }
      if (HasEndDate) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(EndDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignExperiment other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasCampaignDraft) {
        CampaignDraft = other.CampaignDraft;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasDescription) {
        Description = other.Description;
      }
      if (other.HasTrafficSplitPercent) {
        TrafficSplitPercent = other.TrafficSplitPercent;
      }
      if (other.TrafficSplitType != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        TrafficSplitType = other.TrafficSplitType;
      }
      if (other.HasExperimentCampaign) {
        ExperimentCampaign = other.ExperimentCampaign;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.HasLongRunningOperation) {
        LongRunningOperation = other.LongRunningOperation;
      }
      if (other.HasStartDate) {
        StartDate = other.StartDate;
      }
      if (other.HasEndDate) {
        EndDate = other.EndDate;
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
          case 56: {
            TrafficSplitType = (global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType) input.ReadEnum();
            break;
          }
          case 72: {
            Status = (global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus) input.ReadEnum();
            break;
          }
          case 104: {
            Id = input.ReadInt64();
            break;
          }
          case 114: {
            CampaignDraft = input.ReadString();
            break;
          }
          case 122: {
            Name = input.ReadString();
            break;
          }
          case 130: {
            Description = input.ReadString();
            break;
          }
          case 136: {
            TrafficSplitPercent = input.ReadInt64();
            break;
          }
          case 146: {
            ExperimentCampaign = input.ReadString();
            break;
          }
          case 154: {
            LongRunningOperation = input.ReadString();
            break;
          }
          case 162: {
            StartDate = input.ReadString();
            break;
          }
          case 170: {
            EndDate = input.ReadString();
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
          case 56: {
            TrafficSplitType = (global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType) input.ReadEnum();
            break;
          }
          case 72: {
            Status = (global::Google.Ads.GoogleAds.V8.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus) input.ReadEnum();
            break;
          }
          case 104: {
            Id = input.ReadInt64();
            break;
          }
          case 114: {
            CampaignDraft = input.ReadString();
            break;
          }
          case 122: {
            Name = input.ReadString();
            break;
          }
          case 130: {
            Description = input.ReadString();
            break;
          }
          case 136: {
            TrafficSplitPercent = input.ReadInt64();
            break;
          }
          case 146: {
            ExperimentCampaign = input.ReadString();
            break;
          }
          case 154: {
            LongRunningOperation = input.ReadString();
            break;
          }
          case 162: {
            StartDate = input.ReadString();
            break;
          }
          case 170: {
            EndDate = input.ReadString();
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
