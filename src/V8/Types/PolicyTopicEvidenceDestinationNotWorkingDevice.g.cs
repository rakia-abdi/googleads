// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/policy_topic_evidence_destination_not_working_device.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/policy_topic_evidence_destination_not_working_device.proto</summary>
  public static partial class PolicyTopicEvidenceDestinationNotWorkingDeviceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/policy_topic_evidence_destination_not_working_device.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyTopicEvidenceDestinationNotWorkingDeviceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clhnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9wb2xpY3lfdG9waWNf",
            "ZXZpZGVuY2VfZGVzdGluYXRpb25fbm90X3dvcmtpbmdfZGV2aWNlLnByb3Rv",
            "Eh1nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5lbnVtcxocZ29vZ2xlL2FwaS9h",
            "bm5vdGF0aW9ucy5wcm90byKnAQoyUG9saWN5VG9waWNFdmlkZW5jZURlc3Rp",
            "bmF0aW9uTm90V29ya2luZ0RldmljZUVudW0icQouUG9saWN5VG9waWNFdmlk",
            "ZW5jZURlc3RpbmF0aW9uTm90V29ya2luZ0RldmljZRIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARILCgdERVNLVE9QEAISCwoHQU5EUk9JRBADEgcK",
            "A0lPUxAEQogCCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjguZW51bXNC",
            "M1BvbGljeVRvcGljRXZpZGVuY2VEZXN0aW5hdGlvbk5vdFdvcmtpbmdEZXZp",
            "Y2VQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjgvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WOC5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFY4XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.PolicyTopicEvidenceDestinationNotWorkingDeviceEnum), global::Google.Ads.GoogleAds.V8.Enums.PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.Types.PolicyTopicEvidenceDestinationNotWorkingDevice) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy topic evidence destination not
  /// working devices.
  /// </summary>
  public sealed partial class PolicyTopicEvidenceDestinationNotWorkingDeviceEnum : pb::IMessage<PolicyTopicEvidenceDestinationNotWorkingDeviceEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyTopicEvidenceDestinationNotWorkingDeviceEnum> _parser = new pb::MessageParser<PolicyTopicEvidenceDestinationNotWorkingDeviceEnum>(() => new PolicyTopicEvidenceDestinationNotWorkingDeviceEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PolicyTopicEvidenceDestinationNotWorkingDeviceEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.PolicyTopicEvidenceDestinationNotWorkingDeviceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationNotWorkingDeviceEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationNotWorkingDeviceEnum(PolicyTopicEvidenceDestinationNotWorkingDeviceEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationNotWorkingDeviceEnum Clone() {
      return new PolicyTopicEvidenceDestinationNotWorkingDeviceEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PolicyTopicEvidenceDestinationNotWorkingDeviceEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PolicyTopicEvidenceDestinationNotWorkingDeviceEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PolicyTopicEvidenceDestinationNotWorkingDeviceEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PolicyTopicEvidenceDestinationNotWorkingDeviceEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible policy topic evidence destination not working devices.
      /// </summary>
      public enum PolicyTopicEvidenceDestinationNotWorkingDevice {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Landing page doesn't work on desktop device.
        /// </summary>
        [pbr::OriginalName("DESKTOP")] Desktop = 2,
        /// <summary>
        /// Landing page doesn't work on Android device.
        /// </summary>
        [pbr::OriginalName("ANDROID")] Android = 3,
        /// <summary>
        /// Landing page doesn't work on iOS device.
        /// </summary>
        [pbr::OriginalName("IOS")] Ios = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
