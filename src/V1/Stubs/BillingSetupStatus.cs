// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/billing_setup_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/billing_setup_status.proto</summary>
  public static partial class BillingSetupStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/billing_setup_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BillingSetupStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9iaWxsaW5nX3NldHVw",
            "X3N0YXR1cy5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iiQEKFkJpbGxpbmdTZXR1",
            "cFN0YXR1c0VudW0ibwoSQmlsbGluZ1NldHVwU3RhdHVzEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEgsKB1BFTkRJTkcQAhIRCg1BUFBST1ZFRF9I",
            "RUxEEAMSDAoIQVBQUk9WRUQQBBINCglDQU5DRUxMRUQQBULsAQohY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zQhdCaWxsaW5nU2V0dXBTdGF0",
            "dXNQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjEvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYxXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.BillingSetupStatusEnum), global::Google.Ads.GoogleAds.V1.Enums.BillingSetupStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.BillingSetupStatusEnum.Types.BillingSetupStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing BillingSetup statuses.
  /// </summary>
  public sealed partial class BillingSetupStatusEnum : pb::IMessage<BillingSetupStatusEnum> {
    private static readonly pb::MessageParser<BillingSetupStatusEnum> _parser = new pb::MessageParser<BillingSetupStatusEnum>(() => new BillingSetupStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BillingSetupStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.BillingSetupStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BillingSetupStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BillingSetupStatusEnum(BillingSetupStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BillingSetupStatusEnum Clone() {
      return new BillingSetupStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BillingSetupStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BillingSetupStatusEnum other) {
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
    public void MergeFrom(BillingSetupStatusEnum other) {
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
    /// <summary>Container for nested types declared in the BillingSetupStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible statuses of a BillingSetup.
      /// </summary>
      public enum BillingSetupStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The billing setup is pending approval.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 2,
        /// <summary>
        /// The billing setup has been approved but the corresponding first budget
        /// has not.  This can only occur for billing setups configured for monthly
        /// invoicing.
        /// </summary>
        [pbr::OriginalName("APPROVED_HELD")] ApprovedHeld = 3,
        /// <summary>
        /// The billing setup has been approved.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 4,
        /// <summary>
        /// The billing setup was cancelled by the user prior to approval.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
