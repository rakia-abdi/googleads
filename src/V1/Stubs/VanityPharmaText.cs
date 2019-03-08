// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/vanity_pharma_text.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/vanity_pharma_text.proto</summary>
  public static partial class VanityPharmaTextReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/vanity_pharma_text.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VanityPharmaTextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy92YW5pdHlfcGhhcm1h",
            "X3RleHQucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIosEChRWYW5pdHlQaGFybWFU",
            "ZXh0RW51bSLyAwoQVmFuaXR5UGhhcm1hVGV4dBIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIlCiFQUkVTQ1JJUFRJT05fVFJFQVRNRU5UX1dFQlNJ",
            "VEVfRU4QAhIlCiFQUkVTQ1JJUFRJT05fVFJFQVRNRU5UX1dFQlNJVEVfRVMQ",
            "AxIiCh5QUkVTQ1JJUFRJT05fREVWSUNFX1dFQlNJVEVfRU4QBBIiCh5QUkVT",
            "Q1JJUFRJT05fREVWSUNFX1dFQlNJVEVfRVMQBRIdChlNRURJQ0FMX0RFVklD",
            "RV9XRUJTSVRFX0VOEAYSHQoZTUVESUNBTF9ERVZJQ0VfV0VCU0lURV9FUxAH",
            "EiUKIVBSRVZFTlRBVElWRV9UUkVBVE1FTlRfV0VCU0lURV9FThAIEiUKIVBS",
            "RVZFTlRBVElWRV9UUkVBVE1FTlRfV0VCU0lURV9FUxAJEikKJVBSRVNDUklQ",
            "VElPTl9DT05UUkFDRVBUSU9OX1dFQlNJVEVfRU4QChIpCiVQUkVTQ1JJUFRJ",
            "T05fQ09OVFJBQ0VQVElPTl9XRUJTSVRFX0VTEAsSIwofUFJFU0NSSVBUSU9O",
            "X1ZBQ0NJTkVfV0VCU0lURV9FThAMEiMKH1BSRVNDUklQVElPTl9WQUNDSU5F",
            "X1dFQlNJVEVfRVMQDULqAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "LmVudW1zQhVWYW5pdHlQaGFybWFUZXh0UHJvdG9QAVpCZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxL2Vu",
            "dW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuRW51",
            "bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxFbnVtc+oCIUdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYxOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaTextEnum), global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaTextEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaTextEnum.Types.VanityPharmaText) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The text that will be displayed in display URL of the text ad when website
  /// description is the selected display mode for vanity pharma URLs.
  /// </summary>
  public sealed partial class VanityPharmaTextEnum : pb::IMessage<VanityPharmaTextEnum> {
    private static readonly pb::MessageParser<VanityPharmaTextEnum> _parser = new pb::MessageParser<VanityPharmaTextEnum>(() => new VanityPharmaTextEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VanityPharmaTextEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaTextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VanityPharmaTextEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VanityPharmaTextEnum(VanityPharmaTextEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VanityPharmaTextEnum Clone() {
      return new VanityPharmaTextEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VanityPharmaTextEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VanityPharmaTextEnum other) {
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
    public void MergeFrom(VanityPharmaTextEnum other) {
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
    /// <summary>Container for nested types declared in the VanityPharmaTextEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible text.
      /// </summary>
      public enum VanityPharmaText {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Prescription treatment website with website content in English.
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_TREATMENT_WEBSITE_EN")] PrescriptionTreatmentWebsiteEn = 2,
        /// <summary>
        /// Prescription treatment website with website content in Spanish
        /// (Sitio de tratamientos con receta).
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_TREATMENT_WEBSITE_ES")] PrescriptionTreatmentWebsiteEs = 3,
        /// <summary>
        /// Prescription device website with website content in English.
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_DEVICE_WEBSITE_EN")] PrescriptionDeviceWebsiteEn = 4,
        /// <summary>
        /// Prescription device website with website content in Spanish (Sitio de
        /// dispositivos con receta).
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_DEVICE_WEBSITE_ES")] PrescriptionDeviceWebsiteEs = 5,
        /// <summary>
        /// Medical device website with website content in English.
        /// </summary>
        [pbr::OriginalName("MEDICAL_DEVICE_WEBSITE_EN")] MedicalDeviceWebsiteEn = 6,
        /// <summary>
        /// Medical device website with website content in Spanish (Sitio de
        /// dispositivos médicos).
        /// </summary>
        [pbr::OriginalName("MEDICAL_DEVICE_WEBSITE_ES")] MedicalDeviceWebsiteEs = 7,
        /// <summary>
        /// Preventative treatment website with website content in English.
        /// </summary>
        [pbr::OriginalName("PREVENTATIVE_TREATMENT_WEBSITE_EN")] PreventativeTreatmentWebsiteEn = 8,
        /// <summary>
        /// Preventative treatment website with website content in Spanish (Sitio de
        /// tratamientos preventivos).
        /// </summary>
        [pbr::OriginalName("PREVENTATIVE_TREATMENT_WEBSITE_ES")] PreventativeTreatmentWebsiteEs = 9,
        /// <summary>
        /// Prescription contraception website with website content in English.
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_CONTRACEPTION_WEBSITE_EN")] PrescriptionContraceptionWebsiteEn = 10,
        /// <summary>
        /// Prescription contraception website with website content in Spanish (Sitio
        /// de anticonceptivos con receta).
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_CONTRACEPTION_WEBSITE_ES")] PrescriptionContraceptionWebsiteEs = 11,
        /// <summary>
        /// Prescription vaccine website with website content in English.
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_VACCINE_WEBSITE_EN")] PrescriptionVaccineWebsiteEn = 12,
        /// <summary>
        /// Prescription vaccine website with website content in Spanish (Sitio de
        /// vacunas con receta).
        /// </summary>
        [pbr::OriginalName("PRESCRIPTION_VACCINE_WEBSITE_ES")] PrescriptionVaccineWebsiteEs = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
