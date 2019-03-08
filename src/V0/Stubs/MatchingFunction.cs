// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/common/matching_function.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/common/matching_function.proto</summary>
  public static partial class MatchingFunctionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/common/matching_function.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatchingFunctionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9jb21tb24vbWF0Y2hpbmdfZnVu",
            "Y3Rpb24ucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmNvbW1vbhoe",
            "Z29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvIkkKEE1hdGNoaW5nRnVuY3Rpb24SNQoPZnVuY3Rp",
            "b25fc3RyaW5nGAEgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVl",
            "QvABCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuY29tbW9uQhVNYXRj",
            "aGluZ0Z1bmN0aW9uUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2NvbW1vbjtjb21tb26i",
            "AgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5Db21tb27KAh5Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMFxDb21tb27qAiJHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMDo6Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.MatchingFunction), global::Google.Ads.GoogleAds.V0.Common.MatchingFunction.Parser, new[]{ "FunctionString" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Matching function associated with a
  /// CustomerFeed, CampaignFeed, or AdGroupFeed. The matching function is used
  /// to filter the set of feed items selected.
  /// </summary>
  public sealed partial class MatchingFunction : pb::IMessage<MatchingFunction> {
    private static readonly pb::MessageParser<MatchingFunction> _parser = new pb::MessageParser<MatchingFunction>(() => new MatchingFunction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MatchingFunction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.MatchingFunctionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MatchingFunction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MatchingFunction(MatchingFunction other) : this() {
      FunctionString = other.FunctionString;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MatchingFunction Clone() {
      return new MatchingFunction(this);
    }

    /// <summary>Field number for the "function_string" field.</summary>
    public const int FunctionStringFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_functionString_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string functionString_;
    /// <summary>
    /// String representation of the Function.
    ///
    /// Examples:
    /// 1) IDENTITY(true) or IDENTITY(false). All or none feed items serve.
    /// 2) EQUALS(CONTEXT.DEVICE,"Mobile")
    /// 3) IN(FEED_ITEM_ID,{1000001,1000002,1000003})
    /// 4) CONTAINS_ANY(FeedAttribute[12345678,0],{"Mars cruise","Venus cruise"})
    /// 5) AND(IN(FEED_ITEM_ID,{10001,10002}),EQUALS(CONTEXT.DEVICE,"Mobile"))
    /// See
    /// https:
    /// //developers.google.com/adwords/api/docs/guides/feed-matching-functions
    ///
    /// Note that because multiple strings may represent the same underlying
    /// function (whitespace and single versus double quotation marks, for
    /// example), the value returned may not be identical to the string sent in a
    /// mutate request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FunctionString {
      get { return functionString_; }
      set {
        functionString_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MatchingFunction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MatchingFunction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FunctionString != other.FunctionString) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (functionString_ != null) hash ^= FunctionString.GetHashCode();
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
      if (functionString_ != null) {
        _single_functionString_codec.WriteTagAndValue(output, FunctionString);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (functionString_ != null) {
        size += _single_functionString_codec.CalculateSizeWithTag(FunctionString);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MatchingFunction other) {
      if (other == null) {
        return;
      }
      if (other.functionString_ != null) {
        if (functionString_ == null || other.FunctionString != "") {
          FunctionString = other.FunctionString;
        }
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
          case 10: {
            string value = _single_functionString_codec.Read(input);
            if (functionString_ == null || value != "") {
              FunctionString = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
