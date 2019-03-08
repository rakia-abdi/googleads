// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/new_resource_creation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/new_resource_creation_error.proto</summary>
  public static partial class NewResourceCreationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/new_resource_creation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NewResourceCreationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvbmV3X3Jlc291cmNl",
            "X2NyZWF0aW9uX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MS5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8isAEKHE5l",
            "d1Jlc291cmNlQ3JlYXRpb25FcnJvckVudW0ijwEKGE5ld1Jlc291cmNlQ3Jl",
            "YXRpb25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIcChhD",
            "QU5OT1RfU0VUX0lEX0ZPUl9DUkVBVEUQAhIWChJEVVBMSUNBVEVfVEVNUF9J",
            "RFMQAxIfChtURU1QX0lEX1JFU09VUkNFX0hBRF9FUlJPUlMQBEL4AQoiY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9yc0IdTmV3UmVzb3VyY2VD",
            "cmVhdGlvbkVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxL2Vycm9ycztlcnJvcnOi",
            "AgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMS5FcnJvcnPKAh5Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMVxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.NewResourceCreationErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.NewResourceCreationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.NewResourceCreationErrorEnum.Types.NewResourceCreationError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible new resource creation errors.
  /// </summary>
  public sealed partial class NewResourceCreationErrorEnum : pb::IMessage<NewResourceCreationErrorEnum> {
    private static readonly pb::MessageParser<NewResourceCreationErrorEnum> _parser = new pb::MessageParser<NewResourceCreationErrorEnum>(() => new NewResourceCreationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NewResourceCreationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.NewResourceCreationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewResourceCreationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewResourceCreationErrorEnum(NewResourceCreationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewResourceCreationErrorEnum Clone() {
      return new NewResourceCreationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NewResourceCreationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NewResourceCreationErrorEnum other) {
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
    public void MergeFrom(NewResourceCreationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the NewResourceCreationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible new resource creation errors.
      /// </summary>
      public enum NewResourceCreationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Do not set the id field while creating new resources.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_ID_FOR_CREATE")] CannotSetIdForCreate = 2,
        /// <summary>
        /// Creating more than one resource with the same temp ID is not allowed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_TEMP_IDS")] DuplicateTempIds = 3,
        /// <summary>
        /// Parent resource with specified temp ID failed validation, so no
        /// validation will be done for this child resource.
        /// </summary>
        [pbr::OriginalName("TEMP_ID_RESOURCE_HAD_ERRORS")] TempIdResourceHadErrors = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
