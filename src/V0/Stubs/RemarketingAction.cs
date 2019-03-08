// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/remarketing_action.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/remarketing_action.proto</summary>
  public static partial class RemarketingActionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/remarketing_action.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RemarketingActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvcmVtYXJrZXRp",
            "bmdfYWN0aW9uLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52MC5yZXNv",
            "dXJjZXMaMGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL2NvbW1vbi90YWdfc25p",
            "cHBldC5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIsEBChFSZW1hcmtldGluZ0Fj",
            "dGlvbhIVCg1yZXNvdXJjZV9uYW1lGAEgASgJEicKAmlkGAIgASgLMhsuZ29v",
            "Z2xlLnByb3RvYnVmLkludDY0VmFsdWUSKgoEbmFtZRgDIAEoCzIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRJACgx0YWdfc25pcHBldHMYBCADKAsy",
            "Ki5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5jb21tb24uVGFnU25pcHBldEKD",
            "AgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlc0IWUmVt",
            "YXJrZXRpbmdBY3Rpb25Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvcmVzb3VyY2VzO3Jl",
            "c291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLlJlc291",
            "cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXFJlc291cmNlc+oCJUdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYwOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Common.TagSnippetReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction), global::Google.Ads.GoogleAds.V0.Resources.RemarketingAction.Parser, new[]{ "ResourceName", "Id", "Name", "TagSnippets" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A remarketing action. A snippet of JavaScript code that will collect the
  /// product id and the type of page people visited (product page, shopping cart
  /// page, purchase page, general site visit) on an advertiser's website.
  /// </summary>
  public sealed partial class RemarketingAction : pb::IMessage<RemarketingAction> {
    private static readonly pb::MessageParser<RemarketingAction> _parser = new pb::MessageParser<RemarketingAction>(() => new RemarketingAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemarketingAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.RemarketingActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemarketingAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemarketingAction(RemarketingAction other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Name = other.Name;
      tagSnippets_ = other.tagSnippets_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemarketingAction Clone() {
      return new RemarketingAction(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the remarketing action.
    /// Remarketing action resource names have the form:
    ///
    /// `customers/{customer_id}/remarketingActions/{remarketing_action_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// Id of the remarketing action.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string name_;
    /// <summary>
    /// The name of the remarketing action.
    ///
    /// This field is required and should not be empty when creating new
    /// remarketing actions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }

    /// <summary>Field number for the "tag_snippets" field.</summary>
    public const int TagSnippetsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Common.TagSnippet> _repeated_tagSnippets_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Ads.GoogleAds.V0.Common.TagSnippet.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.TagSnippet> tagSnippets_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.TagSnippet>();
    /// <summary>
    /// The snippets used for tracking remarketing actions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.TagSnippet> TagSnippets {
      get { return tagSnippets_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemarketingAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemarketingAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if(!tagSnippets_.Equals(other.tagSnippets_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      hash ^= tagSnippets_.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      tagSnippets_.WriteTo(output, _repeated_tagSnippets_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      size += tagSnippets_.CalculateSize(_repeated_tagSnippets_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemarketingAction other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      tagSnippets_.Add(other.tagSnippets_);
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 26: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 34: {
            tagSnippets_.AddEntriesFrom(input, _repeated_tagSnippets_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
