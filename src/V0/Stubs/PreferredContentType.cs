// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/preferred_content_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/preferred_content_type.proto</summary>
  public static partial class PreferredContentTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/preferred_content_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PreferredContentTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wcmVmZXJyZWRfY29u",
            "dGVudF90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVt",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJqChhQcmVmZXJyZWRD",
            "b250ZW50VHlwZUVudW0iTgoUUHJlZmVycmVkQ29udGVudFR5cGUSDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESGAoTWU9VVFVCRV9UT1BfQ09OVEVO",
            "VBCQA0LuAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zQhlQ",
            "cmVmZXJyZWRDb250ZW50VHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lbnVtcztl",
            "bnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVudW1zygId",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXPqAiFHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.PreferredContentTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.PreferredContentTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.PreferredContentTypeEnum.Types.PreferredContentType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of preferred content criterion type.
  /// </summary>
  public sealed partial class PreferredContentTypeEnum : pb::IMessage<PreferredContentTypeEnum> {
    private static readonly pb::MessageParser<PreferredContentTypeEnum> _parser = new pb::MessageParser<PreferredContentTypeEnum>(() => new PreferredContentTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PreferredContentTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.PreferredContentTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PreferredContentTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PreferredContentTypeEnum(PreferredContentTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PreferredContentTypeEnum Clone() {
      return new PreferredContentTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PreferredContentTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PreferredContentTypeEnum other) {
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
    public void MergeFrom(PreferredContentTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PreferredContentTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates preferred content criterion type.
      /// </summary>
      public enum PreferredContentType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Represents top content on YouTube.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_TOP_CONTENT")] YoutubeTopContent = 400,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
