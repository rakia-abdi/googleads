// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/enums/promotion_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/enums/promotion_placeholder_field.proto</summary>
  public static partial class PromotionPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/enums/promotion_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PromotionPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9wcm9tb3Rpb25fcGxh",
            "Y2Vob2xkZXJfZmllbGQucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY1",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIu4CCh1Qcm9t",
            "b3Rpb25QbGFjZWhvbGRlckZpZWxkRW51bSLMAgoZUHJvbW90aW9uUGxhY2Vo",
            "b2xkZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIUChBQ",
            "Uk9NT1RJT05fVEFSR0VUEAISFQoRRElTQ09VTlRfTU9ESUZJRVIQAxIPCgtQ",
            "RVJDRU5UX09GRhAEEhQKEE1PTkVZX0FNT1VOVF9PRkYQBRISCg5QUk9NT1RJ",
            "T05fQ09ERRAGEhYKEk9SREVSU19PVkVSX0FNT1VOVBAHEhMKD1BST01PVElP",
            "Tl9TVEFSVBAIEhEKDVBST01PVElPTl9FTkQQCRIMCghPQ0NBU0lPThAKEg4K",
            "CkZJTkFMX1VSTFMQCxIVChFGSU5BTF9NT0JJTEVfVVJMUxAMEhAKDFRSQUNL",
            "SU5HX1VSTBANEgwKCExBTkdVQUdFEA4SFAoQRklOQUxfVVJMX1NVRkZJWBAP",
            "QvMBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZW51bXNCHlByb21v",
            "dGlvblBsYWNlaG9sZGVyRmllbGRQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjUvZW51bXM7",
            "ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNS5FbnVtc8oC",
            "HUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY1XEVudW1z6gIhR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjU6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Enums.PromotionPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V5.Enums.PromotionPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Enums.PromotionPlaceholderFieldEnum.Types.PromotionPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Promotion placeholder fields.
  /// </summary>
  public sealed partial class PromotionPlaceholderFieldEnum : pb::IMessage<PromotionPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PromotionPlaceholderFieldEnum> _parser = new pb::MessageParser<PromotionPlaceholderFieldEnum>(() => new PromotionPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PromotionPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Enums.PromotionPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PromotionPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PromotionPlaceholderFieldEnum(PromotionPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PromotionPlaceholderFieldEnum Clone() {
      return new PromotionPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PromotionPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PromotionPlaceholderFieldEnum other) {
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
    public void MergeFrom(PromotionPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the PromotionPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Promotion placeholder fields.
      /// </summary>
      public enum PromotionPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The text that appears on the ad when the extension is
        /// shown.
        /// </summary>
        [pbr::OriginalName("PROMOTION_TARGET")] PromotionTarget = 2,
        /// <summary>
        /// Data Type: STRING. Allows you to add "up to" phrase to the promotion,
        /// in case you have variable promotion rates.
        /// </summary>
        [pbr::OriginalName("DISCOUNT_MODIFIER")] DiscountModifier = 3,
        /// <summary>
        /// Data Type: INT64. Takes a value in micros, where 1 million micros
        /// represents 1%, and is shown as a percentage when rendered.
        /// </summary>
        [pbr::OriginalName("PERCENT_OFF")] PercentOff = 4,
        /// <summary>
        /// Data Type: MONEY. Requires a currency and an amount of money.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_OFF")] MoneyAmountOff = 5,
        /// <summary>
        /// Data Type: STRING. A string that the user enters to get the discount.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CODE")] PromotionCode = 6,
        /// <summary>
        /// Data Type: MONEY. A minimum spend before the user qualifies for the
        /// promotion.
        /// </summary>
        [pbr::OriginalName("ORDERS_OVER_AMOUNT")] OrdersOverAmount = 7,
        /// <summary>
        /// Data Type: DATE. The start date of the promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION_START")] PromotionStart = 8,
        /// <summary>
        /// Data Type: DATE. The end date of the promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION_END")] PromotionEnd = 9,
        /// <summary>
        /// Data Type: STRING. Describes the associated event for the promotion using
        /// one of the PromotionExtensionOccasion enum values, for example NEW_YEARS.
        /// </summary>
        [pbr::OriginalName("OCCASION")] Occasion = 10,
        /// <summary>
        /// Data Type: URL_LIST. Final URLs to be used in the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 11,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 12,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 13,
        /// <summary>
        /// Data Type: STRING. A string represented by a language code for the
        /// promotion.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 14,
        /// <summary>
        /// Data Type: STRING. Final URL suffix for the ad when using parallel
        /// tracking.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX")] FinalUrlSuffix = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
