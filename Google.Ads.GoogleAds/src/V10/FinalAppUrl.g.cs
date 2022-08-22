// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/common/final_app_url.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/common/final_app_url.proto</summary>
  public static partial class FinalAppUrlReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/common/final_app_url.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinalAppUrlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvY29tbW9uL2ZpbmFsX2FwcF91",
            "cmwucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5jb21tb24aQmdv",
            "b2dsZS9hZHMvZ29vZ2xlYWRzL3YxMC9lbnVtcy9hcHBfdXJsX29wZXJhdGlu",
            "Z19zeXN0ZW1fdHlwZS5wcm90byKRAQoLRmluYWxBcHBVcmwSaAoHb3NfdHlw",
            "ZRgBIAEoDjJXLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5lbnVtcy5BcHBV",
            "cmxPcGVyYXRpbmdTeXN0ZW1UeXBlRW51bS5BcHBVcmxPcGVyYXRpbmdTeXN0",
            "ZW1UeXBlEhAKA3VybBgDIAEoCUgAiAEBQgYKBF91cmxC8AEKI2NvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTAuY29tbW9uQhBGaW5hbEFwcFVybFByb3Rv",
            "UAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92MTAvY29tbW9uO2NvbW1vbqICA0dBQaoCH0dvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYxMC5Db21tb27KAh9Hb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWMTBcQ29tbW9u6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpD",
            "b21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Common.FinalAppUrl), global::Google.Ads.GoogleAds.V10.Common.FinalAppUrl.Parser, new[]{ "OsType", "Url" }, new[]{ "Url" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A URL for deep linking into an app for the given operating system.
  /// </summary>
  public sealed partial class FinalAppUrl : pb::IMessage<FinalAppUrl>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinalAppUrl> _parser = new pb::MessageParser<FinalAppUrl>(() => new FinalAppUrl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinalAppUrl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Common.FinalAppUrlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinalAppUrl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinalAppUrl(FinalAppUrl other) : this() {
      osType_ = other.osType_;
      url_ = other.url_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinalAppUrl Clone() {
      return new FinalAppUrl(this);
    }

    /// <summary>Field number for the "os_type" field.</summary>
    public const int OsTypeFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType osType_ = global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified;
    /// <summary>
    /// The operating system targeted by this URL. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType OsType {
      get { return osType_; }
      set {
        osType_ = value;
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 3;
    private string url_;
    /// <summary>
    /// The app deep link URL. Deep links specify a location in an app that
    /// corresponds to the content you'd like to show, and should be of the form
    /// {scheme}://{host_path}
    /// The scheme identifies which app to open. For your app, you can use a custom
    /// scheme that starts with the app's name. The host and path specify the
    /// unique location in the app where your content exists.
    /// Example: "exampleapp://productid_1234". Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Url {
      get { return url_ ?? ""; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUrl {
      get { return url_ != null; }
    }
    /// <summary>Clears the value of the "url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUrl() {
      url_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinalAppUrl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinalAppUrl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OsType != other.OsType) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OsType != global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) hash ^= OsType.GetHashCode();
      if (HasUrl) hash ^= Url.GetHashCode();
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
      if (OsType != global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OsType);
      }
      if (HasUrl) {
        output.WriteRawTag(26);
        output.WriteString(Url);
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
      if (OsType != global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OsType);
      }
      if (HasUrl) {
        output.WriteRawTag(26);
        output.WriteString(Url);
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
      if (OsType != global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OsType);
      }
      if (HasUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinalAppUrl other) {
      if (other == null) {
        return;
      }
      if (other.OsType != global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        OsType = other.OsType;
      }
      if (other.HasUrl) {
        Url = other.Url;
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
          case 8: {
            OsType = (global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType) input.ReadEnum();
            break;
          }
          case 26: {
            Url = input.ReadString();
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
          case 8: {
            OsType = (global::Google.Ads.GoogleAds.V10.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType) input.ReadEnum();
            break;
          }
          case 26: {
            Url = input.ReadString();
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
