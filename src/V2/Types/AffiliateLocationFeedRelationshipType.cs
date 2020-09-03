// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/affiliate_location_feed_relationship_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/affiliate_location_feed_relationship_type.proto</summary>
  public static partial class AffiliateLocationFeedRelationshipTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/affiliate_location_feed_relationship_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AffiliateLocationFeedRelationshipTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9hZmZpbGlhdGVfbG9j",
            "YXRpb25fZmVlZF9yZWxhdGlvbnNoaXBfdHlwZS5wcm90bxIdZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjIuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8iiAEKKUFmZmlsaWF0ZUxvY2F0aW9uRmVlZFJlbGF0aW9uc2hpcFR5",
            "cGVFbnVtIlsKJUFmZmlsaWF0ZUxvY2F0aW9uRmVlZFJlbGF0aW9uc2hpcFR5",
            "cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESFAoQR0VORVJBTF9S",
            "RVRBSUxFUhACQv8BCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51",
            "bXNCKkFmZmlsaWF0ZUxvY2F0aW9uRmVlZFJlbGF0aW9uc2hpcFR5cGVQcm90",
            "b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYy",
            "XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.AffiliateLocationFeedRelationshipTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.AffiliateLocationFeedRelationshipTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.AffiliateLocationFeedRelationshipTypeEnum.Types.AffiliateLocationFeedRelationshipType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible values for a relationship type for
  /// an affiliate location feed.
  /// </summary>
  public sealed partial class AffiliateLocationFeedRelationshipTypeEnum : pb::IMessage<AffiliateLocationFeedRelationshipTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AffiliateLocationFeedRelationshipTypeEnum> _parser = new pb::MessageParser<AffiliateLocationFeedRelationshipTypeEnum>(() => new AffiliateLocationFeedRelationshipTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AffiliateLocationFeedRelationshipTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.AffiliateLocationFeedRelationshipTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AffiliateLocationFeedRelationshipTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AffiliateLocationFeedRelationshipTypeEnum(AffiliateLocationFeedRelationshipTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AffiliateLocationFeedRelationshipTypeEnum Clone() {
      return new AffiliateLocationFeedRelationshipTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AffiliateLocationFeedRelationshipTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AffiliateLocationFeedRelationshipTypeEnum other) {
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
    public void MergeFrom(AffiliateLocationFeedRelationshipTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AffiliateLocationFeedRelationshipTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for a relationship type for an affiliate location feed.
      /// </summary>
      public enum AffiliateLocationFeedRelationshipType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// General retailer relationship.
        /// </summary>
        [pbr::OriginalName("GENERAL_RETAILER")] GeneralRetailer = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
