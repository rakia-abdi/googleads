// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/feed_placeholder_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/feed_placeholder_view_service.proto</summary>
  public static partial class FeedPlaceholderViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/feed_placeholder_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedPlaceholderViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9mZWVkX3BsYWNl",
            "aG9sZGVyX3ZpZXdfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjMuc2VydmljZXMaPWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YzL3Jlc291",
            "cmNlcy9mZWVkX3BsYWNlaG9sZGVyX3ZpZXcucHJvdG8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9n",
            "b29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jl",
            "c291cmNlLnByb3RvImwKHUdldEZlZWRQbGFjZWhvbGRlclZpZXdSZXF1ZXN0",
            "EksKDXJlc291cmNlX25hbWUYASABKAlCNOBBAvpBLgosZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0ZlZWRQbGFjZWhvbGRlclZpZXcynQIKGkZlZWRQbGFj",
            "ZWhvbGRlclZpZXdTZXJ2aWNlEuEBChZHZXRGZWVkUGxhY2Vob2xkZXJWaWV3",
            "Ej8uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuc2VydmljZXMuR2V0RmVlZFBs",
            "YWNlaG9sZGVyVmlld1JlcXVlc3QaNi5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "My5yZXNvdXJjZXMuRmVlZFBsYWNlaG9sZGVyVmlldyJOgtPkkwI4EjYvdjMv",
            "e3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovZmVlZFBsYWNlaG9sZGVyVmll",
            "d3MvKn3aQQ1yZXNvdXJjZV9uYW1lGhvKQRhnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb21ChgIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNl",
            "c0IfRmVlZFBsYWNlaG9sZGVyVmlld1NlcnZpY2VQcm90b1ABWkhnb29nbGUu",
            "Z29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMv",
            "djMvc2VydmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMy5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXFNl",
            "cnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OlNlcnZpY2Vz",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.FeedPlaceholderViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetFeedPlaceholderViewRequest), global::Google.Ads.GoogleAds.V3.Services.GetFeedPlaceholderViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [FeedPlaceholderViewService.GetFeedPlaceholderView][google.ads.googleads.v3.services.FeedPlaceholderViewService.GetFeedPlaceholderView].
  /// </summary>
  public sealed partial class GetFeedPlaceholderViewRequest : pb::IMessage<GetFeedPlaceholderViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFeedPlaceholderViewRequest> _parser = new pb::MessageParser<GetFeedPlaceholderViewRequest>(() => new GetFeedPlaceholderViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetFeedPlaceholderViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.FeedPlaceholderViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFeedPlaceholderViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFeedPlaceholderViewRequest(GetFeedPlaceholderViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFeedPlaceholderViewRequest Clone() {
      return new GetFeedPlaceholderViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the feed placeholder view to fetch.
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
      return Equals(other as GetFeedPlaceholderViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetFeedPlaceholderViewRequest other) {
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
    public void MergeFrom(GetFeedPlaceholderViewRequest other) {
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
