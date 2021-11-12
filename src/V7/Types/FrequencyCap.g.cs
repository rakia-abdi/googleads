// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/common/frequency_cap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/common/frequency_cap.proto</summary>
  public static partial class FrequencyCapReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/common/frequency_cap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FrequencyCapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9jb21tb24vZnJlcXVlbmN5X2Nh",
            "cC5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuY29tbW9uGjxnb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9mcmVxdWVuY3lfY2FwX2V2ZW50",
            "X3R5cGUucHJvdG8aN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y3L2VudW1zL2Zy",
            "ZXF1ZW5jeV9jYXBfbGV2ZWwucHJvdG8aO2dvb2dsZS9hZHMvZ29vZ2xlYWRz",
            "L3Y3L2VudW1zL2ZyZXF1ZW5jeV9jYXBfdGltZV91bml0LnByb3RvGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvImsKEUZyZXF1ZW5jeUNhcEVudHJ5",
            "EjwKA2tleRgBIAEoCzIvLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmNvbW1v",
            "bi5GcmVxdWVuY3lDYXBLZXkSEAoDY2FwGAMgASgFSACIAQFCBgoEX2NhcCLX",
            "AgoPRnJlcXVlbmN5Q2FwS2V5ElUKBWxldmVsGAEgASgOMkYuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjcuZW51bXMuRnJlcXVlbmN5Q2FwTGV2ZWxFbnVtLkZy",
            "ZXF1ZW5jeUNhcExldmVsEmIKCmV2ZW50X3R5cGUYAyABKA4yTi5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Ny5lbnVtcy5GcmVxdWVuY3lDYXBFdmVudFR5cGVF",
            "bnVtLkZyZXF1ZW5jeUNhcEV2ZW50VHlwZRJfCgl0aW1lX3VuaXQYAiABKA4y",
            "TC5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVtcy5GcmVxdWVuY3lDYXBU",
            "aW1lVW5pdEVudW0uRnJlcXVlbmN5Q2FwVGltZVVuaXQSGAoLdGltZV9sZW5n",
            "dGgYBSABKAVIAIgBAUIOCgxfdGltZV9sZW5ndGhC7AEKImNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Ny5jb21tb25CEUZyZXF1ZW5jeUNhcFByb3RvUAFa",
            "RGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92Ny9jb21tb247Y29tbW9uogIDR0FBqgIeR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjcuQ29tbW9uygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdc",
            "Q29tbW9u6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OkNvbW1vbmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Common.FrequencyCapEntry), global::Google.Ads.GoogleAds.V7.Common.FrequencyCapEntry.Parser, new[]{ "Key", "Cap" }, new[]{ "Cap" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey), global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey.Parser, new[]{ "Level", "EventType", "TimeUnit", "TimeLength" }, new[]{ "TimeLength" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A rule specifying the maximum number of times an ad (or some set of ads) can
  /// be shown to a user over a particular time period.
  /// </summary>
  public sealed partial class FrequencyCapEntry : pb::IMessage<FrequencyCapEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FrequencyCapEntry> _parser = new pb::MessageParser<FrequencyCapEntry>(() => new FrequencyCapEntry());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FrequencyCapEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Common.FrequencyCapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FrequencyCapEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FrequencyCapEntry(FrequencyCapEntry other) : this() {
      _hasBits0 = other._hasBits0;
      key_ = other.key_ != null ? other.key_.Clone() : null;
      cap_ = other.cap_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FrequencyCapEntry Clone() {
      return new FrequencyCapEntry(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey key_;
    /// <summary>
    /// The key of a particular frequency cap. There can be no more
    /// than one frequency cap with the same key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    /// <summary>Field number for the "cap" field.</summary>
    public const int CapFieldNumber = 3;
    private int cap_;
    /// <summary>
    /// Maximum number of events allowed during the time range by this cap.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Cap {
      get { if ((_hasBits0 & 1) != 0) { return cap_; } else { return 0; } }
      set {
        _hasBits0 |= 1;
        cap_ = value;
      }
    }
    /// <summary>Gets whether the "cap" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCap {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "cap" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCap() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FrequencyCapEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FrequencyCapEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Key, other.Key)) return false;
      if (Cap != other.Cap) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (key_ != null) hash ^= Key.GetHashCode();
      if (HasCap) hash ^= Cap.GetHashCode();
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
      if (key_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Key);
      }
      if (HasCap) {
        output.WriteRawTag(24);
        output.WriteInt32(Cap);
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
      if (key_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Key);
      }
      if (HasCap) {
        output.WriteRawTag(24);
        output.WriteInt32(Cap);
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
      if (key_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Key);
      }
      if (HasCap) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Cap);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FrequencyCapEntry other) {
      if (other == null) {
        return;
      }
      if (other.key_ != null) {
        if (key_ == null) {
          Key = new global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey();
        }
        Key.MergeFrom(other.Key);
      }
      if (other.HasCap) {
        Cap = other.Cap;
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
            if (key_ == null) {
              Key = new global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey();
            }
            input.ReadMessage(Key);
            break;
          }
          case 24: {
            Cap = input.ReadInt32();
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
            if (key_ == null) {
              Key = new global::Google.Ads.GoogleAds.V7.Common.FrequencyCapKey();
            }
            input.ReadMessage(Key);
            break;
          }
          case 24: {
            Cap = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A group of fields used as keys for a frequency cap.
  /// There can be no more than one frequency cap with the same key.
  /// </summary>
  public sealed partial class FrequencyCapKey : pb::IMessage<FrequencyCapKey>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FrequencyCapKey> _parser = new pb::MessageParser<FrequencyCapKey>(() => new FrequencyCapKey());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FrequencyCapKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Common.FrequencyCapReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FrequencyCapKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FrequencyCapKey(FrequencyCapKey other) : this() {
      _hasBits0 = other._hasBits0;
      level_ = other.level_;
      eventType_ = other.eventType_;
      timeUnit_ = other.timeUnit_;
      timeLength_ = other.timeLength_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FrequencyCapKey Clone() {
      return new FrequencyCapKey(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel level_ = global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel.Unspecified;
    /// <summary>
    /// The level on which the cap is to be applied (e.g. ad group ad, ad group).
    /// The cap is applied to all the entities of this level.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "event_type" field.</summary>
    public const int EventTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType eventType_ = global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType.Unspecified;
    /// <summary>
    /// The type of event that the cap applies to (e.g. impression).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType EventType {
      get { return eventType_; }
      set {
        eventType_ = value;
      }
    }

    /// <summary>Field number for the "time_unit" field.</summary>
    public const int TimeUnitFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit timeUnit_ = global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit.Unspecified;
    /// <summary>
    /// Unit of time the cap is defined at (e.g. day, week).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit TimeUnit {
      get { return timeUnit_; }
      set {
        timeUnit_ = value;
      }
    }

    /// <summary>Field number for the "time_length" field.</summary>
    public const int TimeLengthFieldNumber = 5;
    private int timeLength_;
    /// <summary>
    /// Number of time units the cap lasts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TimeLength {
      get { if ((_hasBits0 & 1) != 0) { return timeLength_; } else { return 0; } }
      set {
        _hasBits0 |= 1;
        timeLength_ = value;
      }
    }
    /// <summary>Gets whether the "time_length" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTimeLength {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "time_length" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTimeLength() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FrequencyCapKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FrequencyCapKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (EventType != other.EventType) return false;
      if (TimeUnit != other.TimeUnit) return false;
      if (TimeLength != other.TimeLength) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel.Unspecified) hash ^= Level.GetHashCode();
      if (EventType != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType.Unspecified) hash ^= EventType.GetHashCode();
      if (TimeUnit != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit.Unspecified) hash ^= TimeUnit.GetHashCode();
      if (HasTimeLength) hash ^= TimeLength.GetHashCode();
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
      if (Level != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Level);
      }
      if (TimeUnit != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) TimeUnit);
      }
      if (EventType != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EventType);
      }
      if (HasTimeLength) {
        output.WriteRawTag(40);
        output.WriteInt32(TimeLength);
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
      if (Level != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Level);
      }
      if (TimeUnit != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) TimeUnit);
      }
      if (EventType != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EventType);
      }
      if (HasTimeLength) {
        output.WriteRawTag(40);
        output.WriteInt32(TimeLength);
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
      if (Level != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Level);
      }
      if (EventType != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
      }
      if (TimeUnit != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TimeUnit);
      }
      if (HasTimeLength) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeLength);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FrequencyCapKey other) {
      if (other == null) {
        return;
      }
      if (other.Level != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel.Unspecified) {
        Level = other.Level;
      }
      if (other.EventType != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType.Unspecified) {
        EventType = other.EventType;
      }
      if (other.TimeUnit != global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit.Unspecified) {
        TimeUnit = other.TimeUnit;
      }
      if (other.HasTimeLength) {
        TimeLength = other.TimeLength;
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
            Level = (global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel) input.ReadEnum();
            break;
          }
          case 16: {
            TimeUnit = (global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit) input.ReadEnum();
            break;
          }
          case 24: {
            EventType = (global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType) input.ReadEnum();
            break;
          }
          case 40: {
            TimeLength = input.ReadInt32();
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
            Level = (global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel) input.ReadEnum();
            break;
          }
          case 16: {
            TimeUnit = (global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit) input.ReadEnum();
            break;
          }
          case 24: {
            EventType = (global::Google.Ads.GoogleAds.V7.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType) input.ReadEnum();
            break;
          }
          case 40: {
            TimeLength = input.ReadInt32();
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
