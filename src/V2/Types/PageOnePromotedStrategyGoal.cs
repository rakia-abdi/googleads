// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/page_one_promoted_strategy_goal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/page_one_promoted_strategy_goal.proto</summary>
  public static partial class PageOnePromotedStrategyGoalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/page_one_promoted_strategy_goal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PageOnePromotedStrategyGoalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9wYWdlX29uZV9wcm9t",
            "b3RlZF9zdHJhdGVneV9nb2FsLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Mi5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKHAQof",
            "UGFnZU9uZVByb21vdGVkU3RyYXRlZ3lHb2FsRW51bSJkChtQYWdlT25lUHJv",
            "bW90ZWRTdHJhdGVneUdvYWwSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESDgoKRklSU1RfUEFHRRACEhcKE0ZJUlNUX1BBR0VfUFJPTU9URUQQA0L1",
            "AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zQiBQYWdlT25l",
            "UHJvbW90ZWRTdHJhdGVneUdvYWxQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvZW51bXM7",
            "ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5FbnVtc8oC",
            "HUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVudW1z6gIhR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.PageOnePromotedStrategyGoalEnum), global::Google.Ads.GoogleAds.V2.Enums.PageOnePromotedStrategyGoalEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.PageOnePromotedStrategyGoalEnum.Types.PageOnePromotedStrategyGoal) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible strategy goals: where impressions are
  /// desired to be shown on search result pages.
  /// </summary>
  public sealed partial class PageOnePromotedStrategyGoalEnum : pb::IMessage<PageOnePromotedStrategyGoalEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PageOnePromotedStrategyGoalEnum> _parser = new pb::MessageParser<PageOnePromotedStrategyGoalEnum>(() => new PageOnePromotedStrategyGoalEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PageOnePromotedStrategyGoalEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.PageOnePromotedStrategyGoalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PageOnePromotedStrategyGoalEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PageOnePromotedStrategyGoalEnum(PageOnePromotedStrategyGoalEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PageOnePromotedStrategyGoalEnum Clone() {
      return new PageOnePromotedStrategyGoalEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PageOnePromotedStrategyGoalEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PageOnePromotedStrategyGoalEnum other) {
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
    public void MergeFrom(PageOnePromotedStrategyGoalEnum other) {
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
    /// <summary>Container for nested types declared in the PageOnePromotedStrategyGoalEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible strategy goals.
      /// </summary>
      public enum PageOnePromotedStrategyGoal {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// First page on google.com.
        /// </summary>
        [pbr::OriginalName("FIRST_PAGE")] FirstPage = 2,
        /// <summary>
        /// Top slots of the first page on google.com.
        /// </summary>
        [pbr::OriginalName("FIRST_PAGE_PROMOTED")] FirstPagePromoted = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
