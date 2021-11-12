// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/enums/reach_plan_age_range.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/enums/reach_plan_age_range.proto</summary>
  public static partial class ReachPlanAgeRangeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/enums/reach_plan_age_range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReachPlanAgeRangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9yZWFjaF9wbGFuX2Fn",
            "ZV9yYW5nZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iiwUKFVJlYWNoUGxhbkFn",
            "ZVJhbmdlRW51bSLxBAoRUmVhY2hQbGFuQWdlUmFuZ2USDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESFQoPQUdFX1JBTkdFXzE4XzI0ENnZHhITCg9B",
            "R0VfUkFOR0VfMThfMzQQAhITCg9BR0VfUkFOR0VfMThfNDQQAxITCg9BR0Vf",
            "UkFOR0VfMThfNDkQBBITCg9BR0VfUkFOR0VfMThfNTQQBRITCg9BR0VfUkFO",
            "R0VfMThfNjQQBhIWChJBR0VfUkFOR0VfMThfNjVfVVAQBxITCg9BR0VfUkFO",
            "R0VfMjFfMzQQCBIVCg9BR0VfUkFOR0VfMjVfMzQQ2tkeEhMKD0FHRV9SQU5H",
            "RV8yNV80NBAJEhMKD0FHRV9SQU5HRV8yNV80ORAKEhMKD0FHRV9SQU5HRV8y",
            "NV81NBALEhMKD0FHRV9SQU5HRV8yNV82NBAMEhYKEkFHRV9SQU5HRV8yNV82",
            "NV9VUBANEhUKD0FHRV9SQU5HRV8zNV80NBDb2R4SEwoPQUdFX1JBTkdFXzM1",
            "XzQ5EA4SEwoPQUdFX1JBTkdFXzM1XzU0EA8SEwoPQUdFX1JBTkdFXzM1XzY0",
            "EBASFgoSQUdFX1JBTkdFXzM1XzY1X1VQEBESFQoPQUdFX1JBTkdFXzQ1XzU0",
            "ENzZHhITCg9BR0VfUkFOR0VfNDVfNjQQEhIWChJBR0VfUkFOR0VfNDVfNjVf",
            "VVAQExIWChJBR0VfUkFOR0VfNTBfNjVfVVAQFBIVCg9BR0VfUkFOR0VfNTVf",
            "NjQQ3dkeEhYKEkFHRV9SQU5HRV81NV82NV9VUBAVEhUKD0FHRV9SQU5HRV82",
            "NV9VUBDe2R5C6wEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVt",
            "c0IWUmVhY2hQbGFuQWdlUmFuZ2VQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjcvZW51bXM7",
            "ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNy5FbnVtc8oC",
            "HUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY3XEVudW1z6gIhR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6Vjc6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Enums.ReachPlanAgeRangeEnum), global::Google.Ads.GoogleAds.V7.Enums.ReachPlanAgeRangeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Enums.ReachPlanAgeRangeEnum.Types.ReachPlanAgeRange) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing plannable age ranges.
  /// </summary>
  public sealed partial class ReachPlanAgeRangeEnum : pb::IMessage<ReachPlanAgeRangeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReachPlanAgeRangeEnum> _parser = new pb::MessageParser<ReachPlanAgeRangeEnum>(() => new ReachPlanAgeRangeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReachPlanAgeRangeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Enums.ReachPlanAgeRangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReachPlanAgeRangeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReachPlanAgeRangeEnum(ReachPlanAgeRangeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReachPlanAgeRangeEnum Clone() {
      return new ReachPlanAgeRangeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReachPlanAgeRangeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReachPlanAgeRangeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReachPlanAgeRangeEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    /// <summary>Container for nested types declared in the ReachPlanAgeRangeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible plannable age range values.
      /// </summary>
      public enum ReachPlanAgeRange {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Between 18 and 24 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_24")] AgeRange1824 = 503001,
        /// <summary>
        /// Between 18 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_34")] AgeRange1834 = 2,
        /// <summary>
        /// Between 18 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_44")] AgeRange1844 = 3,
        /// <summary>
        /// Between 18 and 49 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_49")] AgeRange1849 = 4,
        /// <summary>
        /// Between 18 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_54")] AgeRange1854 = 5,
        /// <summary>
        /// Between 18 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_64")] AgeRange1864 = 6,
        /// <summary>
        /// Between 18 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_65_UP")] AgeRange1865Up = 7,
        /// <summary>
        /// Between 21 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_21_34")] AgeRange2134 = 8,
        /// <summary>
        /// Between 25 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_34")] AgeRange2534 = 503002,
        /// <summary>
        /// Between 25 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_44")] AgeRange2544 = 9,
        /// <summary>
        /// Between 25 and 49 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_49")] AgeRange2549 = 10,
        /// <summary>
        /// Between 25 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_54")] AgeRange2554 = 11,
        /// <summary>
        /// Between 25 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_64")] AgeRange2564 = 12,
        /// <summary>
        /// Between 25 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_65_UP")] AgeRange2565Up = 13,
        /// <summary>
        /// Between 35 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_44")] AgeRange3544 = 503003,
        /// <summary>
        /// Between 35 and 49 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_49")] AgeRange3549 = 14,
        /// <summary>
        /// Between 35 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_54")] AgeRange3554 = 15,
        /// <summary>
        /// Between 35 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_64")] AgeRange3564 = 16,
        /// <summary>
        /// Between 35 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_65_UP")] AgeRange3565Up = 17,
        /// <summary>
        /// Between 45 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_54")] AgeRange4554 = 503004,
        /// <summary>
        /// Between 45 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_64")] AgeRange4564 = 18,
        /// <summary>
        /// Between 45 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_65_UP")] AgeRange4565Up = 19,
        /// <summary>
        /// Between 50 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_50_65_UP")] AgeRange5065Up = 20,
        /// <summary>
        /// Between 55 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_55_64")] AgeRange5564 = 503005,
        /// <summary>
        /// Between 55 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_55_65_UP")] AgeRange5565Up = 21,
        /// <summary>
        /// 65 years old and beyond.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_65_UP")] AgeRange65Up = 503006,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
