// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/promotion_extension_discount_modifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/promotion_extension_discount_modifier.proto</summary>
  public static partial class PromotionExtensionDiscountModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/promotion_extension_discount_modifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PromotionExtensionDiscountModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9wcm9tb3Rpb25fZXh0",
            "ZW5zaW9uX2Rpc2NvdW50X21vZGlmaWVyLnByb3RvEh1nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MS5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byJ3CiZQcm9tb3Rpb25FeHRlbnNpb25EaXNjb3VudE1vZGlmaWVyRW51bSJN",
            "CiJQcm9tb3Rpb25FeHRlbnNpb25EaXNjb3VudE1vZGlmaWVyEg8KC1VOU1BF",
            "Q0lGSUVEEAASCwoHVU5LTk9XThABEgkKBVVQX1RPEAJC/AEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MS5lbnVtc0InUHJvbW90aW9uRXh0ZW5zaW9u",
            "RGlzY291bnRNb2RpZmllclByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lbnVtcztlbnVt",
            "c6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLkVudW1zygIdR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjFcRW51bXPqAiFHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.PromotionExtensionDiscountModifierEnum), global::Google.Ads.GoogleAds.V1.Enums.PromotionExtensionDiscountModifierEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.PromotionExtensionDiscountModifierEnum.Types.PromotionExtensionDiscountModifier) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible a promotion extension
  /// discount modifier.
  /// </summary>
  public sealed partial class PromotionExtensionDiscountModifierEnum : pb::IMessage<PromotionExtensionDiscountModifierEnum> {
    private static readonly pb::MessageParser<PromotionExtensionDiscountModifierEnum> _parser = new pb::MessageParser<PromotionExtensionDiscountModifierEnum>(() => new PromotionExtensionDiscountModifierEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PromotionExtensionDiscountModifierEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.PromotionExtensionDiscountModifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PromotionExtensionDiscountModifierEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PromotionExtensionDiscountModifierEnum(PromotionExtensionDiscountModifierEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PromotionExtensionDiscountModifierEnum Clone() {
      return new PromotionExtensionDiscountModifierEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PromotionExtensionDiscountModifierEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PromotionExtensionDiscountModifierEnum other) {
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
    public void MergeFrom(PromotionExtensionDiscountModifierEnum other) {
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
    /// <summary>Container for nested types declared in the PromotionExtensionDiscountModifierEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// A promotion extension discount modifier.
      /// </summary>
      public enum PromotionExtensionDiscountModifier {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// 'Up to'.
        /// </summary>
        [pbr::OriginalName("UP_TO")] UpTo = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
