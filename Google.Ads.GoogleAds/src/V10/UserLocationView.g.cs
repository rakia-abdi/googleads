// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/user_location_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/user_location_view.proto</summary>
  public static partial class UserLocationViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/user_location_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserLocationViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL3VzZXJfbG9j",
            "YXRpb25fdmlldy5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLnJl",
            "c291cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29v",
            "Z2xlL2FwaS9yZXNvdXJjZS5wcm90byLmAgoQVXNlckxvY2F0aW9uVmlldxJI",
            "Cg1yZXNvdXJjZV9uYW1lGAEgASgJQjHgQQP6QSsKKWdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9Vc2VyTG9jYXRpb25WaWV3EiYKFGNvdW50cnlfY3JpdGVy",
            "aW9uX2lkGAQgASgDQgPgQQNIAIgBARIkChJ0YXJnZXRpbmdfbG9jYXRpb24Y",
            "BSABKAhCA+BBA0gBiAEBOokB6kGFAQopZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL1VzZXJMb2NhdGlvblZpZXcSWGN1c3RvbWVycy97Y3VzdG9tZXJfaWR9",
            "L3VzZXJMb2NhdGlvblZpZXdzL3tjb3VudHJ5X2NyaXRlcmlvbl9pZH1+e2lz",
            "X3RhcmdldGluZ19sb2NhdGlvbn1CFwoVX2NvdW50cnlfY3JpdGVyaW9uX2lk",
            "QhUKE190YXJnZXRpbmdfbG9jYXRpb25ChwIKJmNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTAucmVzb3VyY2VzQhVVc2VyTG9jYXRpb25WaWV3UHJvdG9Q",
            "AVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YxMC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjEwLlJlc291cmNlc8oCIkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMFxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTA6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.UserLocationView), global::Google.Ads.GoogleAds.V10.Resources.UserLocationView.Parser, new[]{ "ResourceName", "CountryCriterionId", "TargetingLocation" }, new[]{ "CountryCriterionId", "TargetingLocation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A user location view.
  ///
  /// User Location View includes all metrics aggregated at the country level,
  /// one row per country. It reports metrics at the actual physical location of
  /// the user by targeted or not targeted location. If other segment fields are
  /// used, you may get more than one row per country.
  /// </summary>
  public sealed partial class UserLocationView : pb::IMessage<UserLocationView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserLocationView> _parser = new pb::MessageParser<UserLocationView>(() => new UserLocationView());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserLocationView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.UserLocationViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLocationView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLocationView(UserLocationView other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      countryCriterionId_ = other.countryCriterionId_;
      targetingLocation_ = other.targetingLocation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLocationView Clone() {
      return new UserLocationView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the user location view.
    /// UserLocation view resource names have the form:
    ///
    /// `customers/{customer_id}/userLocationViews/{country_criterion_id}~{targeting_location}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country_criterion_id" field.</summary>
    public const int CountryCriterionIdFieldNumber = 4;
    private long countryCriterionId_;
    /// <summary>
    /// Output only. Criterion Id for the country.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CountryCriterionId {
      get { if ((_hasBits0 & 1) != 0) { return countryCriterionId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        countryCriterionId_ = value;
      }
    }
    /// <summary>Gets whether the "country_criterion_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCountryCriterionId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "country_criterion_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCountryCriterionId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "targeting_location" field.</summary>
    public const int TargetingLocationFieldNumber = 5;
    private bool targetingLocation_;
    /// <summary>
    /// Output only. Indicates whether location was targeted or not.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool TargetingLocation {
      get { if ((_hasBits0 & 2) != 0) { return targetingLocation_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        targetingLocation_ = value;
      }
    }
    /// <summary>Gets whether the "targeting_location" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTargetingLocation {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "targeting_location" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTargetingLocation() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserLocationView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserLocationView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CountryCriterionId != other.CountryCriterionId) return false;
      if (TargetingLocation != other.TargetingLocation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCountryCriterionId) hash ^= CountryCriterionId.GetHashCode();
      if (HasTargetingLocation) hash ^= TargetingLocation.GetHashCode();
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
      if (HasCountryCriterionId) {
        output.WriteRawTag(32);
        output.WriteInt64(CountryCriterionId);
      }
      if (HasTargetingLocation) {
        output.WriteRawTag(40);
        output.WriteBool(TargetingLocation);
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
      if (HasCountryCriterionId) {
        output.WriteRawTag(32);
        output.WriteInt64(CountryCriterionId);
      }
      if (HasTargetingLocation) {
        output.WriteRawTag(40);
        output.WriteBool(TargetingLocation);
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
      if (HasCountryCriterionId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CountryCriterionId);
      }
      if (HasTargetingLocation) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserLocationView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCountryCriterionId) {
        CountryCriterionId = other.CountryCriterionId;
      }
      if (other.HasTargetingLocation) {
        TargetingLocation = other.TargetingLocation;
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
          case 32: {
            CountryCriterionId = input.ReadInt64();
            break;
          }
          case 40: {
            TargetingLocation = input.ReadBool();
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
          case 32: {
            CountryCriterionId = input.ReadInt64();
            break;
          }
          case 40: {
            TargetingLocation = input.ReadBool();
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
