// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/customer_feed.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/customer_feed.proto</summary>
  public static partial class CustomerFeedReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/customer_feed.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerFeedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "ZmVlZC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEucmVzb3VyY2Vz",
            "GjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9jb21tb24vbWF0Y2hpbmdfZnVu",
            "Y3Rpb24ucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL2VudW1zL2Zl",
            "ZWRfbGlua19zdGF0dXMucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yx",
            "L2VudW1zL3BsYWNlaG9sZGVyX3R5cGUucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byLPAgoMQ3VzdG9tZXJGZWVkEhUKDXJlc291cmNlX25hbWUYASABKAkSKgoE",
            "ZmVlZBgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRJdChFw",
            "bGFjZWhvbGRlcl90eXBlcxgDIAMoDjJCLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zLlBsYWNlaG9sZGVyVHlwZUVudW0uUGxhY2Vob2xkZXJUeXBl",
            "EksKEW1hdGNoaW5nX2Z1bmN0aW9uGAQgASgLMjAuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEuY29tbW9uLk1hdGNoaW5nRnVuY3Rpb24SUAoGc3RhdHVzGAUg",
            "ASgOMkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51bXMuRmVlZExpbmtT",
            "dGF0dXNFbnVtLkZlZWRMaW5rU3RhdHVzQv4BCiVjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEucmVzb3VyY2VzQhFDdXN0b21lckZlZWRQcm90b1ABWkpn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYxLlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYxXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYx",
            "OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Common.MatchingFunctionReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.FeedLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.PlaceholderTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.CustomerFeed), global::Google.Ads.GoogleAds.V1.Resources.CustomerFeed.Parser, new[]{ "ResourceName", "Feed", "PlaceholderTypes", "MatchingFunction", "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customer feed.
  /// </summary>
  public sealed partial class CustomerFeed : pb::IMessage<CustomerFeed> {
    private static readonly pb::MessageParser<CustomerFeed> _parser = new pb::MessageParser<CustomerFeed>(() => new CustomerFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.CustomerFeedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerFeed() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerFeed(CustomerFeed other) : this() {
      resourceName_ = other.resourceName_;
      Feed = other.Feed;
      placeholderTypes_ = other.placeholderTypes_.Clone();
      matchingFunction_ = other.matchingFunction_ != null ? other.matchingFunction_.Clone() : null;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerFeed Clone() {
      return new CustomerFeed(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the customer feed.
    /// Customer feed resource names have the form:
    ///
    /// `customers/{customer_id}/customerFeeds/{feed_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_feed_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string feed_;
    /// <summary>
    /// The feed being linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Feed {
      get { return feed_; }
      set {
        feed_ = value;
      }
    }

    /// <summary>Field number for the "placeholder_types" field.</summary>
    public const int PlaceholderTypesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V1.Enums.PlaceholderTypeEnum.Types.PlaceholderType> _repeated_placeholderTypes_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::Google.Ads.GoogleAds.V1.Enums.PlaceholderTypeEnum.Types.PlaceholderType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Enums.PlaceholderTypeEnum.Types.PlaceholderType> placeholderTypes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Enums.PlaceholderTypeEnum.Types.PlaceholderType>();
    /// <summary>
    /// Indicates which placeholder types the feed may populate under the connected
    /// customer. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Enums.PlaceholderTypeEnum.Types.PlaceholderType> PlaceholderTypes {
      get { return placeholderTypes_; }
    }

    /// <summary>Field number for the "matching_function" field.</summary>
    public const int MatchingFunctionFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V1.Common.MatchingFunction matchingFunction_;
    /// <summary>
    /// Matching function associated with the CustomerFeed.
    /// The matching function is used to filter the set of feed items selected.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.MatchingFunction MatchingFunction {
      get { return matchingFunction_; }
      set {
        matchingFunction_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V1.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus status_ = 0;
    /// <summary>
    /// Status of the customer feed.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerFeed other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Feed != other.Feed) return false;
      if(!placeholderTypes_.Equals(other.placeholderTypes_)) return false;
      if (!object.Equals(MatchingFunction, other.MatchingFunction)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (feed_ != null) hash ^= Feed.GetHashCode();
      hash ^= placeholderTypes_.GetHashCode();
      if (matchingFunction_ != null) hash ^= MatchingFunction.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (feed_ != null) {
        _single_feed_codec.WriteTagAndValue(output, Feed);
      }
      placeholderTypes_.WriteTo(output, _repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MatchingFunction);
      }
      if (Status != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
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
      if (feed_ != null) {
        size += _single_feed_codec.CalculateSizeWithTag(Feed);
      }
      size += placeholderTypes_.CalculateSize(_repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MatchingFunction);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerFeed other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.feed_ != null) {
        if (feed_ == null || other.Feed != "") {
          Feed = other.Feed;
        }
      }
      placeholderTypes_.Add(other.placeholderTypes_);
      if (other.matchingFunction_ != null) {
        if (matchingFunction_ == null) {
          matchingFunction_ = new global::Google.Ads.GoogleAds.V1.Common.MatchingFunction();
        }
        MatchingFunction.MergeFrom(other.MatchingFunction);
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            string value = _single_feed_codec.Read(input);
            if (feed_ == null || value != "") {
              Feed = value;
            }
            break;
          }
          case 26:
          case 24: {
            placeholderTypes_.AddEntriesFrom(input, _repeated_placeholderTypes_codec);
            break;
          }
          case 34: {
            if (matchingFunction_ == null) {
              matchingFunction_ = new global::Google.Ads.GoogleAds.V1.Common.MatchingFunction();
            }
            input.ReadMessage(matchingFunction_);
            break;
          }
          case 40: {
            status_ = (global::Google.Ads.GoogleAds.V1.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
