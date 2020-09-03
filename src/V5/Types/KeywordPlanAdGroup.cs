// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/resources/keyword_plan_ad_group.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/resources/keyword_plan_ad_group.proto</summary>
  public static partial class KeywordPlanAdGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/resources/keyword_plan_ad_group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanAdGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92NS9yZXNvdXJjZXMva2V5d29yZF9w",
            "bGFuX2FkX2dyb3VwLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52NS5y",
            "ZXNvdXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdv",
            "b2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFw",
            "cGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLTAwoS",
            "S2V5d29yZFBsYW5BZEdyb3VwEkoKDXJlc291cmNlX25hbWUYASABKAlCM+BB",
            "BfpBLQorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0tleXdvcmRQbGFuQWRH",
            "cm91cBJuChVrZXl3b3JkX3BsYW5fY2FtcGFpZ24YAiABKAsyHC5nb29nbGUu",
            "cHJvdG9idWYuU3RyaW5nVmFsdWVCMfpBLgosZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0tleXdvcmRQbGFuQ2FtcGFpZ24SLAoCaWQYAyABKAsyGy5nb29n",
            "bGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEDEioKBG5hbWUYBCABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSMwoOY3BjX2JpZF9taWNyb3MY",
            "BSABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZTpy6kFvCitnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vS2V5d29yZFBsYW5BZEdyb3VwEkBjdXN0",
            "b21lcnMve2N1c3RvbWVyfS9rZXl3b3JkUGxhbkFkR3JvdXBzL3trZXl3b3Jk",
            "X3BsYW5fYWRfZ3JvdXB9QoQCCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djUucmVzb3VyY2VzQhdLZXl3b3JkUGxhbkFkR3JvdXBQcm90b1ABWkpnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjUvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlY1LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFY1XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY1OjpS",
            "ZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Resources.KeywordPlanAdGroup), global::Google.Ads.GoogleAds.V5.Resources.KeywordPlanAdGroup.Parser, new[]{ "ResourceName", "KeywordPlanCampaign", "Id", "Name", "CpcBidMicros" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Keyword Planner ad group.
  /// Max number of keyword plan ad groups per plan: 200.
  /// </summary>
  public sealed partial class KeywordPlanAdGroup : pb::IMessage<KeywordPlanAdGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanAdGroup> _parser = new pb::MessageParser<KeywordPlanAdGroup>(() => new KeywordPlanAdGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanAdGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Resources.KeywordPlanAdGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanAdGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanAdGroup(KeywordPlanAdGroup other) : this() {
      resourceName_ = other.resourceName_;
      KeywordPlanCampaign = other.KeywordPlanCampaign;
      Id = other.Id;
      Name = other.Name;
      CpcBidMicros = other.CpcBidMicros;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanAdGroup Clone() {
      return new KeywordPlanAdGroup(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the Keyword Planner ad group.
    /// KeywordPlanAdGroup resource names have the form:
    ///
    /// `customers/{customer_id}/keywordPlanAdGroups/{kp_ad_group_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keyword_plan_campaign" field.</summary>
    public const int KeywordPlanCampaignFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_keywordPlanCampaign_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string keywordPlanCampaign_;
    /// <summary>
    /// The keyword plan campaign to which this ad group belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeywordPlanCampaign {
      get { return keywordPlanCampaign_; }
      set {
        keywordPlanCampaign_ = value;
      }
    }


    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the keyword plan ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// The name of the keyword plan ad group.
    ///
    /// This field is required and should not be empty when creating keyword plan
    /// ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "cpc_bid_micros" field.</summary>
    public const int CpcBidMicrosFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_cpcBidMicros_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? cpcBidMicros_;
    /// <summary>
    /// A default ad group max cpc bid in micros in account currency for all
    /// biddable keywords under the keyword plan ad group.
    /// If not set, will inherit from parent campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CpcBidMicros {
      get { return cpcBidMicros_; }
      set {
        cpcBidMicros_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanAdGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanAdGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (KeywordPlanCampaign != other.KeywordPlanCampaign) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (CpcBidMicros != other.CpcBidMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (keywordPlanCampaign_ != null) hash ^= KeywordPlanCampaign.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (cpcBidMicros_ != null) hash ^= CpcBidMicros.GetHashCode();
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
      if (keywordPlanCampaign_ != null) {
        _single_keywordPlanCampaign_codec.WriteTagAndValue(output, KeywordPlanCampaign);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (cpcBidMicros_ != null) {
        _single_cpcBidMicros_codec.WriteTagAndValue(output, CpcBidMicros);
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
      if (keywordPlanCampaign_ != null) {
        _single_keywordPlanCampaign_codec.WriteTagAndValue(ref output, KeywordPlanCampaign);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(ref output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(ref output, Name);
      }
      if (cpcBidMicros_ != null) {
        _single_cpcBidMicros_codec.WriteTagAndValue(ref output, CpcBidMicros);
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
      if (keywordPlanCampaign_ != null) {
        size += _single_keywordPlanCampaign_codec.CalculateSizeWithTag(KeywordPlanCampaign);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (cpcBidMicros_ != null) {
        size += _single_cpcBidMicros_codec.CalculateSizeWithTag(CpcBidMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanAdGroup other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.keywordPlanCampaign_ != null) {
        if (keywordPlanCampaign_ == null || other.KeywordPlanCampaign != "") {
          KeywordPlanCampaign = other.KeywordPlanCampaign;
        }
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.cpcBidMicros_ != null) {
        if (cpcBidMicros_ == null || other.CpcBidMicros != 0L) {
          CpcBidMicros = other.CpcBidMicros;
        }
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
            string value = _single_keywordPlanCampaign_codec.Read(input);
            if (keywordPlanCampaign_ == null || value != "") {
              KeywordPlanCampaign = value;
            }
            break;
          }
          case 26: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 42: {
            long? value = _single_cpcBidMicros_codec.Read(input);
            if (cpcBidMicros_ == null || value != 0L) {
              CpcBidMicros = value;
            }
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
            string value = _single_keywordPlanCampaign_codec.Read(ref input);
            if (keywordPlanCampaign_ == null || value != "") {
              KeywordPlanCampaign = value;
            }
            break;
          }
          case 26: {
            long? value = _single_id_codec.Read(ref input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(ref input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 42: {
            long? value = _single_cpcBidMicros_codec.Read(ref input);
            if (cpcBidMicros_ == null || value != 0L) {
              CpcBidMicros = value;
            }
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
