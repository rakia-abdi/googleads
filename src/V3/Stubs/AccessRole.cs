// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/access_role.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/access_role.proto</summary>
  public static partial class AccessRoleReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/access_role.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccessRoleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9hY2Nlc3Nfcm9sZS5w",
            "cm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMaHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8iZAoOQWNjZXNzUm9sZUVudW0iUgoKQWNj",
            "ZXNzUm9sZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIJCgVBRE1J",
            "ThACEgwKCFNUQU5EQVJEEAMSDQoJUkVBRF9PTkxZEARC5AEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IPQWNjZXNzUm9sZVByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92My9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYzLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcRW51",
            "bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.AccessRoleEnum), global::Google.Ads.GoogleAds.V3.Enums.AccessRoleEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.AccessRoleEnum.Types.AccessRole) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible access role for user.
  /// </summary>
  public sealed partial class AccessRoleEnum : pb::IMessage<AccessRoleEnum> {
    private static readonly pb::MessageParser<AccessRoleEnum> _parser = new pb::MessageParser<AccessRoleEnum>(() => new AccessRoleEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccessRoleEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.AccessRoleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessRoleEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessRoleEnum(AccessRoleEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessRoleEnum Clone() {
      return new AccessRoleEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AccessRoleEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccessRoleEnum other) {
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
    public void MergeFrom(AccessRoleEnum other) {
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
    /// <summary>Container for nested types declared in the AccessRoleEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible access role of a user.
      /// </summary>
      public enum AccessRole {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Owns its account and can control the addition of other users.
        /// </summary>
        [pbr::OriginalName("ADMIN")] Admin = 2,
        /// <summary>
        /// Can modify campaigns, but can't affect other users.
        /// </summary>
        [pbr::OriginalName("STANDARD")] Standard = 3,
        /// <summary>
        /// Can view campaigns and account changes, but cannot make edits.
        /// </summary>
        [pbr::OriginalName("READ_ONLY")] ReadOnly = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code