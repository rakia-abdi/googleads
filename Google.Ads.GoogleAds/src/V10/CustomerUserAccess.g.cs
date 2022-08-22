// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/customer_user_access.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/customer_user_access.proto</summary>
  public static partial class CustomerUserAccessReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/customer_user_access.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerUserAccessReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X3VzZXJfYWNjZXNzLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTAu",
            "cmVzb3VyY2VzGjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvYWNj",
            "ZXNzX3JvbGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJv",
            "dG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8i+wMKEkN1c3RvbWVyVXNl",
            "ckFjY2VzcxJKCg1yZXNvdXJjZV9uYW1lGAEgASgJQjPgQQX6QS0KK2dvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lclVzZXJBY2Nlc3MSFAoHdXNl",
            "cl9pZBgCIAEoA0ID4EEDEh8KDWVtYWlsX2FkZHJlc3MYAyABKAlCA+BBA0gA",
            "iAEBEk4KC2FjY2Vzc19yb2xlGAQgASgOMjkuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEwLmVudW1zLkFjY2Vzc1JvbGVFbnVtLkFjY2Vzc1JvbGUSKwoZYWNj",
            "ZXNzX2NyZWF0aW9uX2RhdGVfdGltZRgGIAEoCUID4EEDSAGIAQESLAoaaW52",
            "aXRlcl91c2VyX2VtYWlsX2FkZHJlc3MYByABKAlCA+BBA0gCiAEBOmjqQWUK",
            "K2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lclVzZXJBY2Nlc3MS",
            "NmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2N1c3RvbWVyVXNlckFjY2Vzc2Vz",
            "L3t1c2VyX2lkfUIQCg5fZW1haWxfYWRkcmVzc0IcChpfYWNjZXNzX2NyZWF0",
            "aW9uX2RhdGVfdGltZUIdChtfaW52aXRlcl91c2VyX2VtYWlsX2FkZHJlc3NC",
            "iQIKJmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAucmVzb3VyY2VzQhdD",
            "dXN0b21lclVzZXJBY2Nlc3NQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL3Jlc291cmNl",
            "cztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTAu",
            "UmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEwXFJlc291cmNl",
            "c+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMDo6UmVzb3VyY2VzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Enums.AccessRoleReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.CustomerUserAccess), global::Google.Ads.GoogleAds.V10.Resources.CustomerUserAccess.Parser, new[]{ "ResourceName", "UserId", "EmailAddress", "AccessRole", "AccessCreationDateTime", "InviterUserEmailAddress" }, new[]{ "EmailAddress", "AccessCreationDateTime", "InviterUserEmailAddress" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents the permission of a single user onto a single customer.
  /// </summary>
  public sealed partial class CustomerUserAccess : pb::IMessage<CustomerUserAccess>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerUserAccess> _parser = new pb::MessageParser<CustomerUserAccess>(() => new CustomerUserAccess());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerUserAccess> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.CustomerUserAccessReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerUserAccess() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerUserAccess(CustomerUserAccess other) : this() {
      resourceName_ = other.resourceName_;
      userId_ = other.userId_;
      emailAddress_ = other.emailAddress_;
      accessRole_ = other.accessRole_;
      accessCreationDateTime_ = other.accessCreationDateTime_;
      inviterUserEmailAddress_ = other.inviterUserEmailAddress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerUserAccess Clone() {
      return new CustomerUserAccess(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Resource names have the form:
    /// `customers/{customer_id}/customerUserAccesses/{user_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 2;
    private long userId_;
    /// <summary>
    /// Output only. User id of the user with the customer access.
    /// Read only field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "email_address" field.</summary>
    public const int EmailAddressFieldNumber = 3;
    private string emailAddress_;
    /// <summary>
    /// Output only. Email address of the user.
    /// Read only field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EmailAddress {
      get { return emailAddress_ ?? ""; }
      set {
        emailAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "email_address" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEmailAddress {
      get { return emailAddress_ != null; }
    }
    /// <summary>Clears the value of the "email_address" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEmailAddress() {
      emailAddress_ = null;
    }

    /// <summary>Field number for the "access_role" field.</summary>
    public const int AccessRoleFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole accessRole_ = global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole.Unspecified;
    /// <summary>
    /// Access role of the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole AccessRole {
      get { return accessRole_; }
      set {
        accessRole_ = value;
      }
    }

    /// <summary>Field number for the "access_creation_date_time" field.</summary>
    public const int AccessCreationDateTimeFieldNumber = 6;
    private string accessCreationDateTime_;
    /// <summary>
    /// Output only. The customer user access creation time.
    /// Read only field
    /// The format is "YYYY-MM-DD HH:MM:SS".
    /// Examples: "2018-03-05 09:15:00" or "2018-02-01 14:34:30"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccessCreationDateTime {
      get { return accessCreationDateTime_ ?? ""; }
      set {
        accessCreationDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "access_creation_date_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAccessCreationDateTime {
      get { return accessCreationDateTime_ != null; }
    }
    /// <summary>Clears the value of the "access_creation_date_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccessCreationDateTime() {
      accessCreationDateTime_ = null;
    }

    /// <summary>Field number for the "inviter_user_email_address" field.</summary>
    public const int InviterUserEmailAddressFieldNumber = 7;
    private string inviterUserEmailAddress_;
    /// <summary>
    /// Output only. The email address of the inviter user.
    /// Read only field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InviterUserEmailAddress {
      get { return inviterUserEmailAddress_ ?? ""; }
      set {
        inviterUserEmailAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "inviter_user_email_address" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasInviterUserEmailAddress {
      get { return inviterUserEmailAddress_ != null; }
    }
    /// <summary>Clears the value of the "inviter_user_email_address" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInviterUserEmailAddress() {
      inviterUserEmailAddress_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerUserAccess);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerUserAccess other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (UserId != other.UserId) return false;
      if (EmailAddress != other.EmailAddress) return false;
      if (AccessRole != other.AccessRole) return false;
      if (AccessCreationDateTime != other.AccessCreationDateTime) return false;
      if (InviterUserEmailAddress != other.InviterUserEmailAddress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      if (HasEmailAddress) hash ^= EmailAddress.GetHashCode();
      if (AccessRole != global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) hash ^= AccessRole.GetHashCode();
      if (HasAccessCreationDateTime) hash ^= AccessCreationDateTime.GetHashCode();
      if (HasInviterUserEmailAddress) hash ^= InviterUserEmailAddress.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (UserId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UserId);
      }
      if (HasEmailAddress) {
        output.WriteRawTag(26);
        output.WriteString(EmailAddress);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) AccessRole);
      }
      if (HasAccessCreationDateTime) {
        output.WriteRawTag(50);
        output.WriteString(AccessCreationDateTime);
      }
      if (HasInviterUserEmailAddress) {
        output.WriteRawTag(58);
        output.WriteString(InviterUserEmailAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (UserId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UserId);
      }
      if (HasEmailAddress) {
        output.WriteRawTag(26);
        output.WriteString(EmailAddress);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) AccessRole);
      }
      if (HasAccessCreationDateTime) {
        output.WriteRawTag(50);
        output.WriteString(AccessCreationDateTime);
      }
      if (HasInviterUserEmailAddress) {
        output.WriteRawTag(58);
        output.WriteString(InviterUserEmailAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (HasEmailAddress) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EmailAddress);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AccessRole);
      }
      if (HasAccessCreationDateTime) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccessCreationDateTime);
      }
      if (HasInviterUserEmailAddress) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InviterUserEmailAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerUserAccess other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
      if (other.HasEmailAddress) {
        EmailAddress = other.EmailAddress;
      }
      if (other.AccessRole != global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        AccessRole = other.AccessRole;
      }
      if (other.HasAccessCreationDateTime) {
        AccessCreationDateTime = other.AccessCreationDateTime;
      }
      if (other.HasInviterUserEmailAddress) {
        InviterUserEmailAddress = other.InviterUserEmailAddress;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            UserId = input.ReadInt64();
            break;
          }
          case 26: {
            EmailAddress = input.ReadString();
            break;
          }
          case 32: {
            AccessRole = (global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole) input.ReadEnum();
            break;
          }
          case 50: {
            AccessCreationDateTime = input.ReadString();
            break;
          }
          case 58: {
            InviterUserEmailAddress = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            UserId = input.ReadInt64();
            break;
          }
          case 26: {
            EmailAddress = input.ReadString();
            break;
          }
          case 32: {
            AccessRole = (global::Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types.AccessRole) input.ReadEnum();
            break;
          }
          case 50: {
            AccessCreationDateTime = input.ReadString();
            break;
          }
          case 58: {
            InviterUserEmailAddress = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
