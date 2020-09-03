// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/bidding_source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/bidding_source.proto</summary>
  public static partial class BiddingSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/bidding_source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9iaWRkaW5nX3NvdXJj",
            "ZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ihwEKEUJpZGRpbmdTb3VyY2VFbnVt",
            "InIKDUJpZGRpbmdTb3VyY2USDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESHQoZQ0FNUEFJR05fQklERElOR19TVFJBVEVHWRAFEgwKCEFEX0dST1VQ",
            "EAYSFgoSQURfR1JPVVBfQ1JJVEVSSU9OEAdC5wEKIWNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5lbnVtc0ISQmlkZGluZ1NvdXJjZVByb3RvUAFaQmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92My9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlYzLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcRW51bXPq",
            "AiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.BiddingSourceEnum), global::Google.Ads.GoogleAds.V3.Enums.BiddingSourceEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.BiddingSourceEnum.Types.BiddingSource) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bidding sources.
  /// </summary>
  public sealed partial class BiddingSourceEnum : pb::IMessage<BiddingSourceEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingSourceEnum> _parser = new pb::MessageParser<BiddingSourceEnum>(() => new BiddingSourceEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BiddingSourceEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.BiddingSourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingSourceEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingSourceEnum(BiddingSourceEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingSourceEnum Clone() {
      return new BiddingSourceEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BiddingSourceEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BiddingSourceEnum other) {
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
    public void MergeFrom(BiddingSourceEnum other) {
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
    /// <summary>Container for nested types declared in the BiddingSourceEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Indicates where a bid or target is defined. For example, an ad group
      /// criterion may define a cpc bid directly, or it can inherit its cpc bid from
      /// the ad group.
      /// </summary>
      public enum BiddingSource {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Effective bid or target is inherited from campaign bidding strategy.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BIDDING_STRATEGY")] CampaignBiddingStrategy = 5,
        /// <summary>
        /// The bid or target is defined on the ad group.
        /// </summary>
        [pbr::OriginalName("AD_GROUP")] AdGroup = 6,
        /// <summary>
        /// The bid or target is defined on the ad group criterion.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION")] AdGroupCriterion = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
