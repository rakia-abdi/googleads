// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/call_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/call_placeholder_field.proto</summary>
  public static partial class CallPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/call_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CallPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvY2FsbF9wbGFjZWhv",
            "bGRlcl9maWVsZC5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVu",
            "dW1zIroBChhDYWxsUGxhY2Vob2xkZXJGaWVsZEVudW0inQEKFENhbGxQbGFj",
            "ZWhvbGRlckZpZWxkEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhAK",
            "DFBIT05FX05VTUJFUhACEhAKDENPVU5UUllfQ09ERRADEgsKB1RSQUNLRUQQ",
            "BBIWChJDT05WRVJTSU9OX1RZUEVfSUQQBRIeChpDT05WRVJTSU9OX1JFUE9S",
            "VElOR19TVEFURRAGQvMBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEx",
            "LmVudW1zQhlDYWxsUGxhY2Vob2xkZXJGaWVsZFByb3RvUAFaQ2dvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTEvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTEuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcRW51bXPqAiJH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTE6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.CallPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V11.Enums.CallPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.CallPlaceholderFieldEnum.Types.CallPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Call placeholder fields.
  /// </summary>
  public sealed partial class CallPlaceholderFieldEnum : pb::IMessage<CallPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CallPlaceholderFieldEnum> _parser = new pb::MessageParser<CallPlaceholderFieldEnum>(() => new CallPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CallPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.CallPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CallPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CallPlaceholderFieldEnum(CallPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CallPlaceholderFieldEnum Clone() {
      return new CallPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CallPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CallPlaceholderFieldEnum other) {
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
    public void MergeFrom(CallPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the CallPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Call placeholder fields.
      /// </summary>
      public enum CallPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The advertiser's phone number to append to the ad.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER")] PhoneNumber = 2,
        /// <summary>
        /// Data Type: STRING. Uppercase two-letter country code of the advertiser's
        /// phone number.
        /// </summary>
        [pbr::OriginalName("COUNTRY_CODE")] CountryCode = 3,
        /// <summary>
        /// Data Type: BOOLEAN. Indicates whether call tracking is enabled. Default:
        /// true.
        /// </summary>
        [pbr::OriginalName("TRACKED")] Tracked = 4,
        /// <summary>
        /// Data Type: INT64. The ID of an AdCallMetricsConversion object. This
        /// object contains the phoneCallDurationfield which is the minimum duration
        /// (in seconds) of a call to be considered a conversion.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_ID")] ConversionTypeId = 5,
        /// <summary>
        /// Data Type: STRING. Indicates whether this call extension uses its own
        /// call conversion setting or follows the account level setting.
        /// Valid values are: USE_ACCOUNT_LEVEL_CALL_CONVERSION_ACTION and
        /// USE_RESOURCE_LEVEL_CALL_CONVERSION_ACTION.
        /// </summary>
        [pbr::OriginalName("CONVERSION_REPORTING_STATE")] ConversionReportingState = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
