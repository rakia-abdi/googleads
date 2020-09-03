// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/enums/customer_match_upload_key_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/enums/customer_match_upload_key_type.proto</summary>
  public static partial class CustomerMatchUploadKeyTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/enums/customer_match_upload_key_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerMatchUploadKeyTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9jdXN0b21lcl9tYXRj",
            "aF91cGxvYWRfa2V5X3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY1LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpUBCh5D",
            "dXN0b21lck1hdGNoVXBsb2FkS2V5VHlwZUVudW0icwoaQ3VzdG9tZXJNYXRj",
            "aFVwbG9hZEtleVR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "EAoMQ09OVEFDVF9JTkZPEAISCgoGQ1JNX0lEEAMSGQoVTU9CSUxFX0FEVkVS",
            "VElTSU5HX0lEEARC9AEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NS5l",
            "bnVtc0IfQ3VzdG9tZXJNYXRjaFVwbG9hZEtleVR5cGVQcm90b1ABWkJnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjUvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WNS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY1XEVudW1z6gIh",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjU6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Enums.CustomerMatchUploadKeyTypeEnum), global::Google.Ads.GoogleAds.V5.Enums.CustomerMatchUploadKeyTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Enums.CustomerMatchUploadKeyTypeEnum.Types.CustomerMatchUploadKeyType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Indicates what type of data are the user list's members matched from.
  /// </summary>
  public sealed partial class CustomerMatchUploadKeyTypeEnum : pb::IMessage<CustomerMatchUploadKeyTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerMatchUploadKeyTypeEnum> _parser = new pb::MessageParser<CustomerMatchUploadKeyTypeEnum>(() => new CustomerMatchUploadKeyTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerMatchUploadKeyTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Enums.CustomerMatchUploadKeyTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerMatchUploadKeyTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerMatchUploadKeyTypeEnum(CustomerMatchUploadKeyTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerMatchUploadKeyTypeEnum Clone() {
      return new CustomerMatchUploadKeyTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerMatchUploadKeyTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerMatchUploadKeyTypeEnum other) {
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerMatchUploadKeyTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CustomerMatchUploadKeyTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible customer match upload key types.
      /// </summary>
      public enum CustomerMatchUploadKeyType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Members are matched from customer info such as email address, phone
        /// number or physical address.
        /// </summary>
        [pbr::OriginalName("CONTACT_INFO")] ContactInfo = 2,
        /// <summary>
        /// Members are matched from a user id generated and assigned by the
        /// advertiser.
        /// </summary>
        [pbr::OriginalName("CRM_ID")] CrmId = 3,
        /// <summary>
        /// Members are matched from mobile advertising ids.
        /// </summary>
        [pbr::OriginalName("MOBILE_ADVERTISING_ID")] MobileAdvertisingId = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
