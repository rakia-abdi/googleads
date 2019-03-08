// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/webpage_condition_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/webpage_condition_operator.proto</summary>
  public static partial class WebpageConditionOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/webpage_condition_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WebpageConditionOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy93ZWJwYWdlX2NvbmRp",
            "dGlvbl9vcGVyYXRvci5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8icgocV2VicGFn",
            "ZUNvbmRpdGlvbk9wZXJhdG9yRW51bSJSChhXZWJwYWdlQ29uZGl0aW9uT3Bl",
            "cmF0b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESCgoGRVFVQUxT",
            "EAISDAoIQ09OVEFJTlMQA0LyAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zQh1XZWJwYWdlQ29uZGl0aW9uT3BlcmF0b3JQcm90b1ABWkJn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjEvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXEVudW1z",
            "6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.WebpageConditionOperatorEnum), global::Google.Ads.GoogleAds.V1.Enums.WebpageConditionOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.WebpageConditionOperatorEnum.Types.WebpageConditionOperator) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing webpage condition operator in webpage
  /// criterion.
  /// </summary>
  public sealed partial class WebpageConditionOperatorEnum : pb::IMessage<WebpageConditionOperatorEnum> {
    private static readonly pb::MessageParser<WebpageConditionOperatorEnum> _parser = new pb::MessageParser<WebpageConditionOperatorEnum>(() => new WebpageConditionOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WebpageConditionOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.WebpageConditionOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebpageConditionOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebpageConditionOperatorEnum(WebpageConditionOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebpageConditionOperatorEnum Clone() {
      return new WebpageConditionOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WebpageConditionOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WebpageConditionOperatorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WebpageConditionOperatorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the WebpageConditionOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The webpage condition operator in webpage criterion.
      /// </summary>
      public enum WebpageConditionOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The argument web condition is equal to the compared web condition.
        /// </summary>
        [pbr::OriginalName("EQUALS")] Equals = 2,
        /// <summary>
        /// The argument web condition is part of the compared web condition.
        /// </summary>
        [pbr::OriginalName("CONTAINS")] Contains = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
