// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/reach_plan_ad_length.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/reach_plan_ad_length.proto</summary>
  public static partial class ReachPlanAdLengthReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/reach_plan_ad_length.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReachPlanAdLengthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9yZWFjaF9wbGFuX2Fk",
            "X2xlbmd0aC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ilgEKFVJlYWNoUGxhbkFk",
            "TGVuZ3RoRW51bSJ9ChFSZWFjaFBsYW5BZExlbmd0aBIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIPCgtTSVhfU0VDT05EUxACEh0KGUZJRlRFRU5f",
            "T1JfVFdFTlRZX1NFQ09ORFMQAxIaChZUV0VOVFlfU0VDT05EU19PUl9NT1JF",
            "EARC6wEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtc0IWUmVh",
            "Y2hQbGFuQWRMZW5ndGhQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvZW51bXM7ZW51bXOi",
            "AgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5FbnVtc8oCHUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYyXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.ReachPlanAdLengthEnum), global::Google.Ads.GoogleAds.V2.Enums.ReachPlanAdLengthEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.ReachPlanAdLengthEnum.Types.ReachPlanAdLength) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing length of a plannable video ad.
  /// </summary>
  public sealed partial class ReachPlanAdLengthEnum : pb::IMessage<ReachPlanAdLengthEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReachPlanAdLengthEnum> _parser = new pb::MessageParser<ReachPlanAdLengthEnum>(() => new ReachPlanAdLengthEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReachPlanAdLengthEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.ReachPlanAdLengthReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReachPlanAdLengthEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReachPlanAdLengthEnum(ReachPlanAdLengthEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReachPlanAdLengthEnum Clone() {
      return new ReachPlanAdLengthEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReachPlanAdLengthEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReachPlanAdLengthEnum other) {
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
    public void MergeFrom(ReachPlanAdLengthEnum other) {
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
    /// <summary>Container for nested types declared in the ReachPlanAdLengthEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible ad length values.
      /// </summary>
      public enum ReachPlanAdLength {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// 6 seconds long ad.
        /// </summary>
        [pbr::OriginalName("SIX_SECONDS")] SixSeconds = 2,
        /// <summary>
        /// 15 or 20 seconds long ad.
        /// </summary>
        [pbr::OriginalName("FIFTEEN_OR_TWENTY_SECONDS")] FifteenOrTwentySeconds = 3,
        /// <summary>
        /// More than 20 seconds long ad.
        /// </summary>
        [pbr::OriginalName("TWENTY_SECONDS_OR_MORE")] TwentySecondsOrMore = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
