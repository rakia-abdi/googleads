// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/common/policy_summary.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/common/policy_summary.proto</summary>
  public static partial class PolicySummaryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/common/policy_summary.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicySummaryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vcG9saWN5X3N1bW1h",
            "cnkucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmNvbW1vbhorZ29v",
            "Z2xlL2Fkcy9nb29nbGVhZHMvdjkvY29tbW9uL3BvbGljeS5wcm90bxo6Z29v",
            "Z2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51bXMvcG9saWN5X2FwcHJvdmFsX3N0",
            "YXR1cy5wcm90bxo4Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51bXMvcG9s",
            "aWN5X3Jldmlld19zdGF0dXMucHJvdG8ipwIKDVBvbGljeVN1bW1hcnkSTgoU",
            "cG9saWN5X3RvcGljX2VudHJpZXMYASADKAsyMC5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52OS5jb21tb24uUG9saWN5VG9waWNFbnRyeRJfCg1yZXZpZXdfc3Rh",
            "dHVzGAIgASgOMkguZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMuUG9s",
            "aWN5UmV2aWV3U3RhdHVzRW51bS5Qb2xpY3lSZXZpZXdTdGF0dXMSZQoPYXBw",
            "cm92YWxfc3RhdHVzGAMgASgOMkwuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjku",
            "ZW51bXMuUG9saWN5QXBwcm92YWxTdGF0dXNFbnVtLlBvbGljeUFwcHJvdmFs",
            "U3RhdHVzQu0BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuY29tbW9u",
            "QhJQb2xpY3lTdW1tYXJ5UHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L2NvbW1vbjtjb21t",
            "b26iAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5Db21tb27KAh5H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWOVxDb21tb27qAiJHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWOTo6Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Common.PolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.PolicySummary), global::Google.Ads.GoogleAds.V9.Common.PolicySummary.Parser, new[]{ "PolicyTopicEntries", "ReviewStatus", "ApprovalStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains policy summary information.
  /// </summary>
  public sealed partial class PolicySummary : pb::IMessage<PolicySummary>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicySummary> _parser = new pb::MessageParser<PolicySummary>(() => new PolicySummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PolicySummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.PolicySummaryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicySummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicySummary(PolicySummary other) : this() {
      policyTopicEntries_ = other.policyTopicEntries_.Clone();
      reviewStatus_ = other.reviewStatus_;
      approvalStatus_ = other.approvalStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicySummary Clone() {
      return new PolicySummary(this);
    }

    /// <summary>Field number for the "policy_topic_entries" field.</summary>
    public const int PolicyTopicEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V9.Common.PolicyTopicEntry> _repeated_policyTopicEntries_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V9.Common.PolicyTopicEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Common.PolicyTopicEntry> policyTopicEntries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Common.PolicyTopicEntry>();
    /// <summary>
    /// The list of policy findings.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V9.Common.PolicyTopicEntry> PolicyTopicEntries {
      get { return policyTopicEntries_; }
    }

    /// <summary>Field number for the "review_status" field.</summary>
    public const int ReviewStatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus reviewStatus_ = global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified;
    /// <summary>
    /// Where in the review process the resource is.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus ReviewStatus {
      get { return reviewStatus_; }
      set {
        reviewStatus_ = value;
      }
    }

    /// <summary>Field number for the "approval_status" field.</summary>
    public const int ApprovalStatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus approvalStatus_ = global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified;
    /// <summary>
    /// The overall approval status, which is calculated based on
    /// the status of its individual policy topic entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus ApprovalStatus {
      get { return approvalStatus_; }
      set {
        approvalStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PolicySummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PolicySummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!policyTopicEntries_.Equals(other.policyTopicEntries_)) return false;
      if (ReviewStatus != other.ReviewStatus) return false;
      if (ApprovalStatus != other.ApprovalStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= policyTopicEntries_.GetHashCode();
      if (ReviewStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) hash ^= ReviewStatus.GetHashCode();
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) hash ^= ApprovalStatus.GetHashCode();
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
      policyTopicEntries_.WriteTo(output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
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
      policyTopicEntries_.WriteTo(ref output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
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
      size += policyTopicEntries_.CalculateSize(_repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PolicySummary other) {
      if (other == null) {
        return;
      }
      policyTopicEntries_.Add(other.policyTopicEntries_);
      if (other.ReviewStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        ReviewStatus = other.ReviewStatus;
      }
      if (other.ApprovalStatus != global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        ApprovalStatus = other.ApprovalStatus;
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
            policyTopicEntries_.AddEntriesFrom(input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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
            policyTopicEntries_.AddEntriesFrom(ref input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V9.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V9.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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