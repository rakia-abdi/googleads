// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/asset_field_type_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/asset_field_type_view.proto</summary>
  public static partial class AssetFieldTypeViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/asset_field_type_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetFieldTypeViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2Fzc2V0X2Zp",
            "ZWxkX3R5cGVfdmlldy5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEw",
            "LnJlc291cmNlcxo1Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zL2Fz",
            "c2V0X2ZpZWxkX3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8iqAIKEkFzc2V0",
            "RmllbGRUeXBlVmlldxJKCg1yZXNvdXJjZV9uYW1lGAEgASgJQjPgQQP6QS0K",
            "K2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Bc3NldEZpZWxkVHlwZVZpZXcS",
            "WgoKZmllbGRfdHlwZRgDIAEoDjJBLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "MC5lbnVtcy5Bc3NldEZpZWxkVHlwZUVudW0uQXNzZXRGaWVsZFR5cGVCA+BB",
            "Azpq6kFnCitnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRGaWVsZFR5",
            "cGVWaWV3EjhjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9hc3NldEZpZWxkVHlw",
            "ZVZpZXdzL3tmaWVsZF90eXBlfUKJAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMC5yZXNvdXJjZXNCF0Fzc2V0RmllbGRUeXBlVmlld1Byb3RvUAFa",
            "S2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92MTAvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYxMC5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMTBcUmVzb3VyY2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjEwOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.AssetFieldTypeView), global::Google.Ads.GoogleAds.V10.Resources.AssetFieldTypeView.Parser, new[]{ "ResourceName", "FieldType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An asset field type view.
  /// This view reports non-overcounted metrics for each asset field type when the
  /// asset is used as extension.
  /// </summary>
  public sealed partial class AssetFieldTypeView : pb::IMessage<AssetFieldTypeView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetFieldTypeView> _parser = new pb::MessageParser<AssetFieldTypeView>(() => new AssetFieldTypeView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetFieldTypeView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.AssetFieldTypeViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetFieldTypeView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetFieldTypeView(AssetFieldTypeView other) : this() {
      resourceName_ = other.resourceName_;
      fieldType_ = other.fieldType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetFieldTypeView Clone() {
      return new AssetFieldTypeView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the asset field type view.
    /// Asset field type view resource names have the form:
    ///
    /// `customers/{customer_id}/assetFieldTypeViews/{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// Output only. The asset field type of the asset field type view.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetFieldTypeView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetFieldTypeView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (FieldType != other.FieldType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
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
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FieldType);
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
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FieldType);
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
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetFieldTypeView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
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
          case 24: {
            FieldType = (global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
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
          case 24: {
            FieldType = (global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
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
