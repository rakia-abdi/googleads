// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/education_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/education_placeholder_field.proto</summary>
  public static partial class EducationPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/education_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EducationPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9lZHVjYXRpb25fcGxh",
            "Y2Vob2xkZXJfZmllbGQucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIr8DCh1FZHVj",
            "YXRpb25QbGFjZWhvbGRlckZpZWxkRW51bSKdAwoZRWR1Y2F0aW9uUGxhY2Vo",
            "b2xkZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIOCgpQ",
            "Uk9HUkFNX0lEEAISDwoLTE9DQVRJT05fSUQQAxIQCgxQUk9HUkFNX05BTUUQ",
            "BBIRCg1BUkVBX09GX1NUVURZEAUSFwoTUFJPR1JBTV9ERVNDUklQVElPThAG",
            "Eg8KC1NDSE9PTF9OQU1FEAcSCwoHQUREUkVTUxAIEhcKE1RIVU1CTkFJTF9J",
            "TUFHRV9VUkwQCRIjCh9BTFRFUk5BVElWRV9USFVNQk5BSUxfSU1BR0VfVVJM",
            "EAoSDgoKRklOQUxfVVJMUxALEhUKEUZJTkFMX01PQklMRV9VUkxTEAwSEAoM",
            "VFJBQ0tJTkdfVVJMEA0SFwoTQ09OVEVYVFVBTF9LRVlXT1JEUxAOEhQKEEFO",
            "RFJPSURfQVBQX0xJTksQDxIXChNTSU1JTEFSX1BST0dSQU1fSURTEBASEAoM",
            "SU9TX0FQUF9MSU5LEBESFAoQSU9TX0FQUF9TVE9SRV9JRBASQvMBCiFjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCHkVkdWNhdGlvblBsYWNl",
            "aG9sZGVyRmllbGRQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvZW51bXM7ZW51bXOiAgNH",
            "QUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYyXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.EducationPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V2.Enums.EducationPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.EducationPlaceholderFieldEnum.Types.EducationPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Education placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class EducationPlaceholderFieldEnum : pb::IMessage<EducationPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EducationPlaceholderFieldEnum> _parser = new pb::MessageParser<EducationPlaceholderFieldEnum>(() => new EducationPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EducationPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.EducationPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EducationPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EducationPlaceholderFieldEnum(EducationPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EducationPlaceholderFieldEnum Clone() {
      return new EducationPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EducationPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EducationPlaceholderFieldEnum other) {
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
    public void MergeFrom(EducationPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the EducationPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Education placeholder fields.
      /// </summary>
      public enum EducationPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Required. Combination of PROGRAM ID and LOCATION ID
        /// must be unique per offer.
        /// </summary>
        [pbr::OriginalName("PROGRAM_ID")] ProgramId = 2,
        /// <summary>
        /// Data Type: STRING. Combination of PROGRAM ID and LOCATION ID must be
        /// unique per offer.
        /// </summary>
        [pbr::OriginalName("LOCATION_ID")] LocationId = 3,
        /// <summary>
        /// Data Type: STRING. Required. Main headline with program name to be shown
        /// in dynamic ad.
        /// </summary>
        [pbr::OriginalName("PROGRAM_NAME")] ProgramName = 4,
        /// <summary>
        /// Data Type: STRING. Area of study that can be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("AREA_OF_STUDY")] AreaOfStudy = 5,
        /// <summary>
        /// Data Type: STRING. Description of program that can be shown in dynamic
        /// ad.
        /// </summary>
        [pbr::OriginalName("PROGRAM_DESCRIPTION")] ProgramDescription = 6,
        /// <summary>
        /// Data Type: STRING. Name of school that can be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("SCHOOL_NAME")] SchoolName = 7,
        /// <summary>
        /// Data Type: STRING. Complete school address, including postal code.
        /// </summary>
        [pbr::OriginalName("ADDRESS")] Address = 8,
        /// <summary>
        /// Data Type: URL. Image to be displayed in ads.
        /// </summary>
        [pbr::OriginalName("THUMBNAIL_IMAGE_URL")] ThumbnailImageUrl = 9,
        /// <summary>
        /// Data Type: URL. Alternative hosted file of image to be used in the ad.
        /// </summary>
        [pbr::OriginalName("ALTERNATIVE_THUMBNAIL_IMAGE_URL")] AlternativeThumbnailImageUrl = 10,
        /// <summary>
        /// Data Type: URL_LIST. Required. Final URLs to be used in ad when using
        /// Upgraded URLs; the more specific the better (e.g. the individual URL of a
        /// specific program and its location).
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
        /// Data Type: STRING_LIST. Keywords used for product retrieval.
        /// </summary>
        [pbr::OriginalName("CONTEXTUAL_KEYWORDS")] ContextualKeywords = 14,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 15,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended program IDs to show together
        /// with this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_PROGRAM_IDS")] SimilarProgramIds = 16,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 17,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 18,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
