// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/location_group_radius_units.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/location_group_radius_units.proto</summary>
  public static partial class LocationGroupRadiusUnitsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/location_group_radius_units.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationGroupRadiusUnitsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9sb2NhdGlvbl9ncm91",
            "cF9yYWRpdXNfdW5pdHMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoABChxMb2Nh",
            "dGlvbkdyb3VwUmFkaXVzVW5pdHNFbnVtImAKGExvY2F0aW9uR3JvdXBSYWRp",
            "dXNVbml0cxIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZNRVRF",
            "UlMQAhIJCgVNSUxFUxADEg8KC01JTExJX01JTEVTEARC8gEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52OC5lbnVtc0IdTG9jYXRpb25Hcm91cFJhZGl1",
            "c1VuaXRzUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y4L2VudW1zO2VudW1zogIDR0FBqgId",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjguRW51bXPKAh1Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWOFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY4",
            "OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.LocationGroupRadiusUnitsEnum), global::Google.Ads.GoogleAds.V8.Enums.LocationGroupRadiusUnitsEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.LocationGroupRadiusUnitsEnum.Types.LocationGroupRadiusUnits) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing unit of radius in location group.
  /// </summary>
  public sealed partial class LocationGroupRadiusUnitsEnum : pb::IMessage<LocationGroupRadiusUnitsEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocationGroupRadiusUnitsEnum> _parser = new pb::MessageParser<LocationGroupRadiusUnitsEnum>(() => new LocationGroupRadiusUnitsEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocationGroupRadiusUnitsEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.LocationGroupRadiusUnitsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationGroupRadiusUnitsEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationGroupRadiusUnitsEnum(LocationGroupRadiusUnitsEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationGroupRadiusUnitsEnum Clone() {
      return new LocationGroupRadiusUnitsEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocationGroupRadiusUnitsEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocationGroupRadiusUnitsEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LocationGroupRadiusUnitsEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LocationGroupRadiusUnitsEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The unit of radius distance in location group (e.g. MILES)
      /// </summary>
      public enum LocationGroupRadiusUnits {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Meters
        /// </summary>
        [pbr::OriginalName("METERS")] Meters = 2,
        /// <summary>
        /// Miles
        /// </summary>
        [pbr::OriginalName("MILES")] Miles = 3,
        /// <summary>
        /// Milli Miles
        /// </summary>
        [pbr::OriginalName("MILLI_MILES")] MilliMiles = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
