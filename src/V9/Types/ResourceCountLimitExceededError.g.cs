// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/resource_count_limit_exceeded_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/resource_count_limit_exceeded_error.proto</summary>
  public static partial class ResourceCountLimitExceededErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/resource_count_limit_exceeded_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceCountLimitExceededErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvcmVzb3VyY2VfY291",
            "bnRfbGltaXRfZXhjZWVkZWRfZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY5LmVycm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byK+AgojUmVzb3VyY2VDb3VudExpbWl0RXhjZWVkZWRFcnJvckVudW0ilgIK",
            "H1Jlc291cmNlQ291bnRMaW1pdEV4Y2VlZGVkRXJyb3ISDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESEQoNQUNDT1VOVF9MSU1JVBACEhIKDkNBTVBB",
            "SUdOX0xJTUlUEAMSEQoNQURHUk9VUF9MSU1JVBAEEhUKEUFEX0dST1VQX0FE",
            "X0xJTUlUEAUSHAoYQURfR1JPVVBfQ1JJVEVSSU9OX0xJTUlUEAYSFAoQU0hB",
            "UkVEX1NFVF9MSU1JVBAHEhsKF01BVENISU5HX0ZVTkNUSU9OX0xJTUlUEAgS",
            "HwobUkVTUE9OU0VfUk9XX0xJTUlUX0VYQ0VFREVEEAkSEgoOUkVTT1VSQ0Vf",
            "TElNSVQQCkL/AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVycm9y",
            "c0IkUmVzb3VyY2VDb3VudExpbWl0RXhjZWVkZWRFcnJvclByb3RvUAFaRGdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92OS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjkuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlcRXJy",
            "b3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjk6OkVycm9yc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.ResourceCountLimitExceededErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.ResourceCountLimitExceededErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.ResourceCountLimitExceededErrorEnum.Types.ResourceCountLimitExceededError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible resource count limit exceeded errors.
  /// </summary>
  public sealed partial class ResourceCountLimitExceededErrorEnum : pb::IMessage<ResourceCountLimitExceededErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResourceCountLimitExceededErrorEnum> _parser = new pb::MessageParser<ResourceCountLimitExceededErrorEnum>(() => new ResourceCountLimitExceededErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResourceCountLimitExceededErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.ResourceCountLimitExceededErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceCountLimitExceededErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceCountLimitExceededErrorEnum(ResourceCountLimitExceededErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceCountLimitExceededErrorEnum Clone() {
      return new ResourceCountLimitExceededErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResourceCountLimitExceededErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResourceCountLimitExceededErrorEnum other) {
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
    public void MergeFrom(ResourceCountLimitExceededErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ResourceCountLimitExceededErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible resource count limit exceeded errors.
      /// </summary>
      public enum ResourceCountLimitExceededError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Indicates that this request would exceed the number of allowed resources
        /// for the Google Ads account. The exact resource type and limit being
        /// checked can be inferred from accountLimitType.
        /// </summary>
        [pbr::OriginalName("ACCOUNT_LIMIT")] AccountLimit = 2,
        /// <summary>
        /// Indicates that this request would exceed the number of allowed resources
        /// in a Campaign. The exact resource type and limit being checked can be
        /// inferred from accountLimitType, and the numeric id of the
        /// Campaign involved is given by enclosingId.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LIMIT")] CampaignLimit = 3,
        /// <summary>
        /// Indicates that this request would exceed the number of allowed resources
        /// in an ad group. The exact resource type and limit being checked can be
        /// inferred from accountLimitType, and the numeric id of the
        /// ad group involved is given by enclosingId.
        /// </summary>
        [pbr::OriginalName("ADGROUP_LIMIT")] AdgroupLimit = 4,
        /// <summary>
        /// Indicates that this request would exceed the number of allowed resources
        /// in an ad group ad. The exact resource type and limit being checked can
        /// be inferred from accountLimitType, and the enclosingId
        /// contains the ad group id followed by the ad id, separated by a single
        /// comma (,).
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD_LIMIT")] AdGroupAdLimit = 5,
        /// <summary>
        /// Indicates that this request would exceed the number of allowed resources
        /// in an ad group criterion. The exact resource type and limit being checked
        /// can be inferred from accountLimitType, and the
        /// enclosingId contains the ad group id followed by the
        /// criterion id, separated by a single comma (,).
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION_LIMIT")] AdGroupCriterionLimit = 6,
        /// <summary>
        /// Indicates that this request would exceed the number of allowed resources
        /// in this shared set. The exact resource type and limit being checked can
        /// be inferred from accountLimitType, and the numeric id of the
        /// shared set involved is given by enclosingId.
        /// </summary>
        [pbr::OriginalName("SHARED_SET_LIMIT")] SharedSetLimit = 7,
        /// <summary>
        /// Exceeds a limit related to a matching function.
        /// </summary>
        [pbr::OriginalName("MATCHING_FUNCTION_LIMIT")] MatchingFunctionLimit = 8,
        /// <summary>
        /// The response for this request would exceed the maximum number of rows
        /// that can be returned.
        /// </summary>
        [pbr::OriginalName("RESPONSE_ROW_LIMIT_EXCEEDED")] ResponseRowLimitExceeded = 9,
        /// <summary>
        /// This request would exceed a limit on the number of allowed resources.
        /// The details of which type of limit was exceeded will eventually be
        /// returned in ErrorDetails.
        /// </summary>
        [pbr::OriginalName("RESOURCE_LIMIT")] ResourceLimit = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
