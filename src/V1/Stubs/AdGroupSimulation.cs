// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/ad_group_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/ad_group_simulation.proto</summary>
  public static partial class AdGroupSimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/ad_group_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupSimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "c2ltdWxhdGlvbi5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEucmVz",
            "b3VyY2VzGi9nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9jb21tb24vc2ltdWxh",
            "dGlvbi5wcm90bxpCZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvZW51bXMvc2lt",
            "dWxhdGlvbl9tb2RpZmljYXRpb25fbWV0aG9kLnByb3RvGjNnb29nbGUvYWRz",
            "L2dvb2dsZWFkcy92MS9lbnVtcy9zaW11bGF0aW9uX3R5cGUucHJvdG8aHmdv",
            "b2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90byLPBAoRQWRHcm91cFNpbXVsYXRpb24SFQoNcmVzb3Vy",
            "Y2VfbmFtZRgBIAEoCRIwCgthZF9ncm91cF9pZBgCIAEoCzIbLmdvb2dsZS5w",
            "cm90b2J1Zi5JbnQ2NFZhbHVlEk4KBHR5cGUYAyABKA4yQC5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MS5lbnVtcy5TaW11bGF0aW9uVHlwZUVudW0uU2ltdWxh",
            "dGlvblR5cGUSeQoTbW9kaWZpY2F0aW9uX21ldGhvZBgEIAEoDjJcLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zLlNpbXVsYXRpb25Nb2RpZmljYXRp",
            "b25NZXRob2RFbnVtLlNpbXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2QSMAoK",
            "c3RhcnRfZGF0ZRgFIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1",
            "ZRIuCghlbmRfZGF0ZRgGIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdW",
            "YWx1ZRJXChJjcGNfYmlkX3BvaW50X2xpc3QYCCABKAsyOS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MS5jb21tb24uQ3BjQmlkU2ltdWxhdGlvblBvaW50TGlz",
            "dEgAEl0KFXRhcmdldF9jcGFfcG9pbnRfbGlzdBgJIAEoCzI8Lmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbi5UYXJnZXRDcGFTaW11bGF0aW9uUG9p",
            "bnRMaXN0SABCDAoKcG9pbnRfbGlzdEKDAgolY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxLnJlc291cmNlc0IWQWRHcm91cFNpbXVsYXRpb25Qcm90b1AB",
            "Wkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYxLlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYxXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.SimulationTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.AdGroupSimulation), global::Google.Ads.GoogleAds.V1.Resources.AdGroupSimulation.Parser, new[]{ "ResourceName", "AdGroupId", "Type", "ModificationMethod", "StartDate", "EndDate", "CpcBidPointList", "TargetCpaPointList" }, new[]{ "PointList" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad group simulation. Supported combinations of advertising
  /// channel type, simulation type and simulation modification method is
  /// detailed below respectively.
  ///
  /// SEARCH   CPC_BID     DEFAULT
  /// SEARCH   CPC_BID     UNIFORM
  /// SEARCH   TARGET_CPA  UNIFORM
  /// DISPLAY  CPC_BID     DEFAULT
  /// DISPLAY  CPC_BID     UNIFORM
  /// DISPLAY  TARGET_CPA  UNIFORM
  /// </summary>
  public sealed partial class AdGroupSimulation : pb::IMessage<AdGroupSimulation> {
    private static readonly pb::MessageParser<AdGroupSimulation> _parser = new pb::MessageParser<AdGroupSimulation>(() => new AdGroupSimulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupSimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.AdGroupSimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupSimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupSimulation(AdGroupSimulation other) : this() {
      resourceName_ = other.resourceName_;
      AdGroupId = other.AdGroupId;
      type_ = other.type_;
      modificationMethod_ = other.modificationMethod_;
      StartDate = other.StartDate;
      EndDate = other.EndDate;
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          CpcBidPointList = other.CpcBidPointList.Clone();
          break;
        case PointListOneofCase.TargetCpaPointList:
          TargetCpaPointList = other.TargetCpaPointList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupSimulation Clone() {
      return new AdGroupSimulation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the ad group simulation.
    /// Ad group simulation resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupSimulations/{ad_group_id}~{type}~{modification_method}~{start_date}~{end_date}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_id" field.</summary>
    public const int AdGroupIdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_adGroupId_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? adGroupId_;
    /// <summary>
    /// Ad group id of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? AdGroupId {
      get { return adGroupId_; }
      set {
        adGroupId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V1.Enums.SimulationTypeEnum.Types.SimulationType type_ = 0;
    /// <summary>
    /// The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.SimulationTypeEnum.Types.SimulationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "modification_method" field.</summary>
    public const int ModificationMethodFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V1.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod modificationMethod_ = 0;
    /// <summary>
    /// How the simulation modifies the field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod ModificationMethod {
      get { return modificationMethod_; }
      set {
        modificationMethod_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_startDate_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string startDate_;
    /// <summary>
    /// First day on which the simulation is based, in YYYY-MM-DD format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_endDate_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string endDate_;
    /// <summary>
    /// Last day on which the simulation is based, in YYYY-MM-DD format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EndDate {
      get { return endDate_; }
      set {
        endDate_ = value;
      }
    }

    /// <summary>Field number for the "cpc_bid_point_list" field.</summary>
    public const int CpcBidPointListFieldNumber = 8;
    /// <summary>
    /// Simulation points if the simulation type is CPC_BID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.CpcBidSimulationPointList CpcBidPointList {
      get { return pointListCase_ == PointListOneofCase.CpcBidPointList ? (global::Google.Ads.GoogleAds.V1.Common.CpcBidSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.CpcBidPointList;
      }
    }

    /// <summary>Field number for the "target_cpa_point_list" field.</summary>
    public const int TargetCpaPointListFieldNumber = 9;
    /// <summary>
    /// Simulation points if the simulation type is TARGET_CPA.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.TargetCpaSimulationPointList TargetCpaPointList {
      get { return pointListCase_ == PointListOneofCase.TargetCpaPointList ? (global::Google.Ads.GoogleAds.V1.Common.TargetCpaSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetCpaPointList;
      }
    }

    private object pointList_;
    /// <summary>Enum of possible cases for the "point_list" oneof.</summary>
    public enum PointListOneofCase {
      None = 0,
      CpcBidPointList = 8,
      TargetCpaPointList = 9,
    }
    private PointListOneofCase pointListCase_ = PointListOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PointListOneofCase PointListCase {
      get { return pointListCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPointList() {
      pointListCase_ = PointListOneofCase.None;
      pointList_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupSimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupSimulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupId != other.AdGroupId) return false;
      if (Type != other.Type) return false;
      if (ModificationMethod != other.ModificationMethod) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      if (!object.Equals(CpcBidPointList, other.CpcBidPointList)) return false;
      if (!object.Equals(TargetCpaPointList, other.TargetCpaPointList)) return false;
      if (PointListCase != other.PointListCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (adGroupId_ != null) hash ^= AdGroupId.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (ModificationMethod != 0) hash ^= ModificationMethod.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (endDate_ != null) hash ^= EndDate.GetHashCode();
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) hash ^= CpcBidPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) hash ^= TargetCpaPointList.GetHashCode();
      hash ^= (int) pointListCase_;
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (adGroupId_ != null) {
        _single_adGroupId_codec.WriteTagAndValue(output, AdGroupId);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (startDate_ != null) {
        _single_startDate_codec.WriteTagAndValue(output, StartDate);
      }
      if (endDate_ != null) {
        _single_endDate_codec.WriteTagAndValue(output, EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetCpaPointList);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (adGroupId_ != null) {
        size += _single_adGroupId_codec.CalculateSizeWithTag(AdGroupId);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ModificationMethod != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModificationMethod);
      }
      if (startDate_ != null) {
        size += _single_startDate_codec.CalculateSizeWithTag(StartDate);
      }
      if (endDate_ != null) {
        size += _single_endDate_codec.CalculateSizeWithTag(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetCpaPointList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupSimulation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.adGroupId_ != null) {
        if (adGroupId_ == null || other.AdGroupId != 0L) {
          AdGroupId = other.AdGroupId;
        }
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.ModificationMethod != 0) {
        ModificationMethod = other.ModificationMethod;
      }
      if (other.startDate_ != null) {
        if (startDate_ == null || other.StartDate != "") {
          StartDate = other.StartDate;
        }
      }
      if (other.endDate_ != null) {
        if (endDate_ == null || other.EndDate != "") {
          EndDate = other.EndDate;
        }
      }
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          if (CpcBidPointList == null) {
            CpcBidPointList = new global::Google.Ads.GoogleAds.V1.Common.CpcBidSimulationPointList();
          }
          CpcBidPointList.MergeFrom(other.CpcBidPointList);
          break;
        case PointListOneofCase.TargetCpaPointList:
          if (TargetCpaPointList == null) {
            TargetCpaPointList = new global::Google.Ads.GoogleAds.V1.Common.TargetCpaSimulationPointList();
          }
          TargetCpaPointList.MergeFrom(other.TargetCpaPointList);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
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
            long? value = _single_adGroupId_codec.Read(input);
            if (adGroupId_ == null || value != 0L) {
              AdGroupId = value;
            }
            break;
          }
          case 24: {
            type_ = (global::Google.Ads.GoogleAds.V1.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            modificationMethod_ = (global::Google.Ads.GoogleAds.V1.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 42: {
            string value = _single_startDate_codec.Read(input);
            if (startDate_ == null || value != "") {
              StartDate = value;
            }
            break;
          }
          case 50: {
            string value = _single_endDate_codec.Read(input);
            if (endDate_ == null || value != "") {
              EndDate = value;
            }
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V1.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V1.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V1.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V1.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
