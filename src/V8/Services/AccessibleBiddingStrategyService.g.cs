// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/services/accessible_bidding_strategy_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/services/accessible_bidding_strategy_service.proto</summary>
  public static partial class AccessibleBiddingStrategyServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/services/accessible_bidding_strategy_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccessibleBiddingStrategyServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9zZXJ2aWNlcy9hY2Nlc3NpYmxl",
            "X2JpZGRpbmdfc3RyYXRlZ3lfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjguc2VydmljZXMaQ2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y4",
            "L3Jlc291cmNlcy9hY2Nlc3NpYmxlX2JpZGRpbmdfc3RyYXRlZ3kucHJvdG8a",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aF2dvb2dsZS9hcGkvY2xp",
            "ZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhln",
            "b29nbGUvYXBpL3Jlc291cmNlLnByb3RvIngKI0dldEFjY2Vzc2libGVCaWRk",
            "aW5nU3RyYXRlZ3lSZXF1ZXN0ElEKDXJlc291cmNlX25hbWUYASABKAlCOuBB",
            "AvpBNAoyZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FjY2Vzc2libGVCaWRk",
            "aW5nU3RyYXRlZ3ky5gIKIEFjY2Vzc2libGVCaWRkaW5nU3RyYXRlZ3lTZXJ2",
            "aWNlEvoBChxHZXRBY2Nlc3NpYmxlQmlkZGluZ1N0cmF0ZWd5EkUuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjguc2VydmljZXMuR2V0QWNjZXNzaWJsZUJpZGRp",
            "bmdTdHJhdGVneVJlcXVlc3QaPC5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5y",
            "ZXNvdXJjZXMuQWNjZXNzaWJsZUJpZGRpbmdTdHJhdGVneSJVgtPkkwI/Ej0v",
            "djgve3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovYWNjZXNzaWJsZUJpZGRp",
            "bmdTdHJhdGVnaWVzLyp92kENcmVzb3VyY2VfbmFtZRpFykEYZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29t0kEnaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20v",
            "YXV0aC9hZHdvcmRzQowCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjgu",
            "c2VydmljZXNCJUFjY2Vzc2libGVCaWRkaW5nU3RyYXRlZ3lTZXJ2aWNlUHJv",
            "dG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3Y4L3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjguU2VydmljZXPKAiBHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWOFxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlY4OjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Resources.AccessibleBiddingStrategyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Services.GetAccessibleBiddingStrategyRequest), global::Google.Ads.GoogleAds.V8.Services.GetAccessibleBiddingStrategyRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [AccessibleBiddingStrategyService.GetAccessibleBiddingStrategy][google.ads.googleads.v8.services.AccessibleBiddingStrategyService.GetAccessibleBiddingStrategy].
  /// </summary>
  public sealed partial class GetAccessibleBiddingStrategyRequest : pb::IMessage<GetAccessibleBiddingStrategyRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAccessibleBiddingStrategyRequest> _parser = new pb::MessageParser<GetAccessibleBiddingStrategyRequest>(() => new GetAccessibleBiddingStrategyRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAccessibleBiddingStrategyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Services.AccessibleBiddingStrategyServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAccessibleBiddingStrategyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAccessibleBiddingStrategyRequest(GetAccessibleBiddingStrategyRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAccessibleBiddingStrategyRequest Clone() {
      return new GetAccessibleBiddingStrategyRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the accessible bidding strategy to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAccessibleBiddingStrategyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAccessibleBiddingStrategyRequest other) {
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAccessibleBiddingStrategyRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
