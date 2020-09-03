// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/internal_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/internal_error.proto</summary>
  public static partial class InternalErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/internal_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InternalErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvaW50ZXJuYWxfZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmVycm9ycxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKhAQoRSW50ZXJuYWxFcnJvckVu",
            "dW0iiwEKDUludGVybmFsRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktO",
            "T1dOEAESEgoOSU5URVJOQUxfRVJST1IQAhIcChhFUlJPUl9DT0RFX05PVF9Q",
            "VUJMSVNIRUQQAxITCg9UUkFOU0lFTlRfRVJST1IQBBIVChFERUFETElORV9F",
            "WENFRURFRBAFQu0BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZXJy",
            "b3JzQhJJbnRlcm5hbEVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2Vycm9ycztl",
            "cnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5FcnJvcnPK",
            "Ah5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxFcnJvcnPqAiJHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWNDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.InternalErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.InternalErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.InternalErrorEnum.Types.InternalError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible internal errors.
  /// </summary>
  public sealed partial class InternalErrorEnum : pb::IMessage<InternalErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InternalErrorEnum> _parser = new pb::MessageParser<InternalErrorEnum>(() => new InternalErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InternalErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.InternalErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InternalErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InternalErrorEnum(InternalErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InternalErrorEnum Clone() {
      return new InternalErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InternalErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InternalErrorEnum other) {
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
    public void MergeFrom(InternalErrorEnum other) {
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
    /// <summary>Container for nested types declared in the InternalErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible internal errors.
      /// </summary>
      public enum InternalError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google Ads API encountered unexpected internal error.
        /// </summary>
        [pbr::OriginalName("INTERNAL_ERROR")] InternalError = 2,
        /// <summary>
        /// The intended error code doesn't exist in specified API version. It will
        /// be released in a future API version.
        /// </summary>
        [pbr::OriginalName("ERROR_CODE_NOT_PUBLISHED")] ErrorCodeNotPublished = 3,
        /// <summary>
        /// Google Ads API encountered an unexpected transient error. The user
        /// should retry their request in these cases.
        /// </summary>
        [pbr::OriginalName("TRANSIENT_ERROR")] TransientError = 4,
        /// <summary>
        /// The request took longer than a deadline.
        /// </summary>
        [pbr::OriginalName("DEADLINE_EXCEEDED")] DeadlineExceeded = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
