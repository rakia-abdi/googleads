// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/bidding_strategy_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/bidding_strategy_error.proto</summary>
  public static partial class BiddingStrategyErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/bidding_strategy_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingStrategyErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvYmlkZGluZ19zdHJh",
            "dGVneV9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZXJy",
            "b3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItkBChhCaWRkaW5n",
            "U3RyYXRlZ3lFcnJvckVudW0ivAEKFEJpZGRpbmdTdHJhdGVneUVycm9yEg8K",
            "C1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhIKDkRVUExJQ0FURV9OQU1F",
            "EAISJwojQ0FOTk9UX0NIQU5HRV9CSURESU5HX1NUUkFURUdZX1RZUEUQAxIl",
            "CiFDQU5OT1RfUkVNT1ZFX0FTU09DSUFURURfU1RSQVRFR1kQBBIiCh5CSURE",
            "SU5HX1NUUkFURUdZX05PVF9TVVBQT1JURUQQBUL0AQoiY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYwLmVycm9yc0IZQmlkZGluZ1N0cmF0ZWd5RXJyb3JQ",
            "cm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYwXEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYwOjpF",
            "cnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.BiddingStrategyErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.BiddingStrategyErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.BiddingStrategyErrorEnum.Types.BiddingStrategyError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bidding strategy errors.
  /// </summary>
  public sealed partial class BiddingStrategyErrorEnum : pb::IMessage<BiddingStrategyErrorEnum> {
    private static readonly pb::MessageParser<BiddingStrategyErrorEnum> _parser = new pb::MessageParser<BiddingStrategyErrorEnum>(() => new BiddingStrategyErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BiddingStrategyErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.BiddingStrategyErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategyErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategyErrorEnum(BiddingStrategyErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategyErrorEnum Clone() {
      return new BiddingStrategyErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BiddingStrategyErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BiddingStrategyErrorEnum other) {
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
    public void MergeFrom(BiddingStrategyErrorEnum other) {
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
    /// <summary>Container for nested types declared in the BiddingStrategyErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible bidding strategy errors.
      /// </summary>
      public enum BiddingStrategyError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Each bidding strategy must have a unique name.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 2,
        /// <summary>
        /// Bidding strategy type is immutable.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_BIDDING_STRATEGY_TYPE")] CannotChangeBiddingStrategyType = 3,
        /// <summary>
        /// Only bidding strategies not linked to campaigns, adgroups or adgroup
        /// criteria can be removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_ASSOCIATED_STRATEGY")] CannotRemoveAssociatedStrategy = 4,
        /// <summary>
        /// The specified bidding strategy is not supported.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_SUPPORTED")] BiddingStrategyNotSupported = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
