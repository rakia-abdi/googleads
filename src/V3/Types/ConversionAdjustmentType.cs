// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/conversion_adjustment_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/conversion_adjustment_type.proto</summary>
  public static partial class ConversionAdjustmentTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/conversion_adjustment_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionAdjustmentTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9jb252ZXJzaW9uX2Fk",
            "anVzdG1lbnRfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ieQocQ29udmVy",
            "c2lvbkFkanVzdG1lbnRUeXBlRW51bSJZChhDb252ZXJzaW9uQWRqdXN0bWVu",
            "dFR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDgoKUkVUUkFD",
            "VElPThACEg8KC1JFU1RBVEVNRU5UEANC8gEKIWNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52My5lbnVtc0IdQ29udmVyc2lvbkFkanVzdG1lbnRUeXBlUHJv",
            "dG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjMuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "M1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.ConversionAdjustmentTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.ConversionAdjustmentTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.ConversionAdjustmentTypeEnum.Types.ConversionAdjustmentType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing conversion adjustment types.
  /// </summary>
  public sealed partial class ConversionAdjustmentTypeEnum : pb::IMessage<ConversionAdjustmentTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionAdjustmentTypeEnum> _parser = new pb::MessageParser<ConversionAdjustmentTypeEnum>(() => new ConversionAdjustmentTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConversionAdjustmentTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.ConversionAdjustmentTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionAdjustmentTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionAdjustmentTypeEnum(ConversionAdjustmentTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionAdjustmentTypeEnum Clone() {
      return new ConversionAdjustmentTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConversionAdjustmentTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConversionAdjustmentTypeEnum other) {
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
    public void MergeFrom(ConversionAdjustmentTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionAdjustmentTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The different actions advertisers can take to adjust the conversions that
      /// they already reported. Retractions negate a conversion. Restatements change
      /// the value of a conversion.
      /// </summary>
      public enum ConversionAdjustmentType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Negates a conversion so that its total value and count are both zero.
        /// </summary>
        [pbr::OriginalName("RETRACTION")] Retraction = 2,
        /// <summary>
        /// Changes the value of a conversion.
        /// </summary>
        [pbr::OriginalName("RESTATEMENT")] Restatement = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
