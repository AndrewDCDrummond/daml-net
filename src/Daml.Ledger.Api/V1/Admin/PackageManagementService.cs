// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/admin/package_management_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Ledger.Api.V1.Admin {

  /// <summary>Holder for reflection information generated from com/digitalasset/ledger/api/v1/admin/package_management_service.proto</summary>
  public static partial class PackageManagementServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/ledger/api/v1/admin/package_management_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PackageManagementServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVjb20vZGlnaXRhbGFzc2V0L2xlZGdlci9hcGkvdjEvYWRtaW4vcGFja2Fn",
            "ZV9tYW5hZ2VtZW50X3NlcnZpY2UucHJvdG8SJGNvbS5kaWdpdGFsYXNzZXQu",
            "bGVkZ2VyLmFwaS52MS5hZG1pbhofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFt",
            "cC5wcm90byIaChhMaXN0S25vd25QYWNrYWdlc1JlcXVlc3QiagoZTGlzdEtu",
            "b3duUGFja2FnZXNSZXNwb25zZRJNCg9wYWNrYWdlX2RldGFpbHMYASADKAsy",
            "NC5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEuYWRtaW4uUGFja2Fn",
            "ZURldGFpbHMihwEKDlBhY2thZ2VEZXRhaWxzEhIKCnBhY2thZ2VfaWQYASAB",
            "KAkSFAoMcGFja2FnZV9zaXplGAIgASgEEi8KC2tub3duX3NpbmNlGAMgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIaChJzb3VyY2VfZGVzY3Jp",
            "cHRpb24YBCABKAkiKAoUVXBsb2FkRGFyRmlsZVJlcXVlc3QSEAoIZGFyX2Zp",
            "bGUYASABKAwiFwoVVXBsb2FkRGFyRmlsZVJlc3BvbnNlMrwCChhQYWNrYWdl",
            "TWFuYWdlbWVudFNlcnZpY2USlAEKEUxpc3RLbm93blBhY2thZ2VzEj4uY29t",
            "LmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLmFkbWluLkxpc3RLbm93blBh",
            "Y2thZ2VzUmVxdWVzdBo/LmNvbS5kaWdpdGFsYXNzZXQubGVkZ2VyLmFwaS52",
            "MS5hZG1pbi5MaXN0S25vd25QYWNrYWdlc1Jlc3BvbnNlEogBCg1VcGxvYWRE",
            "YXJGaWxlEjouY29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLmFkbWlu",
            "LlVwbG9hZERhckZpbGVSZXF1ZXN0GjsuY29tLmRpZ2l0YWxhc3NldC5sZWRn",
            "ZXIuYXBpLnYxLmFkbWluLlVwbG9hZERhckZpbGVSZXNwb25zZUJxCiRjb20u",
            "ZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEuYWRtaW5CIlBhY2thZ2VNYW5h",
            "Z2VtZW50U2VydmljZU91dGVyQ2xhc3OqAiRDb20uRGlnaXRhbEFzc2V0Lkxl",
            "ZGdlci5BcGkuVjEuQWRtaW5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse.Parser, new[]{ "PackageDetails" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails), global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails.Parser, new[]{ "PackageId", "PackageSize", "KnownSince", "SourceDescription" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest.Parser, new[]{ "DarFile" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListKnownPackagesRequest : pb::IMessage<ListKnownPackagesRequest> {
    private static readonly pb::MessageParser<ListKnownPackagesRequest> _parser = new pb::MessageParser<ListKnownPackagesRequest>(() => new ListKnownPackagesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListKnownPackagesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageManagementServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPackagesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPackagesRequest(ListKnownPackagesRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPackagesRequest Clone() {
      return new ListKnownPackagesRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListKnownPackagesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListKnownPackagesRequest other) {
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
    public void MergeFrom(ListKnownPackagesRequest other) {
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

  }

  public sealed partial class ListKnownPackagesResponse : pb::IMessage<ListKnownPackagesResponse> {
    private static readonly pb::MessageParser<ListKnownPackagesResponse> _parser = new pb::MessageParser<ListKnownPackagesResponse>(() => new ListKnownPackagesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListKnownPackagesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageManagementServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPackagesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPackagesResponse(ListKnownPackagesResponse other) : this() {
      packageDetails_ = other.packageDetails_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPackagesResponse Clone() {
      return new ListKnownPackagesResponse(this);
    }

    /// <summary>Field number for the "package_details" field.</summary>
    public const int PackageDetailsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails> _repeated_packageDetails_codec
        = pb::FieldCodec.ForMessage(10, global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails.Parser);
    private readonly pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails> packageDetails_ = new pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails>();
    /// <summary>
    /// The details of all DAML-LF packages known to backing participant.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageDetails> PackageDetails {
      get { return packageDetails_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListKnownPackagesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListKnownPackagesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!packageDetails_.Equals(other.packageDetails_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= packageDetails_.GetHashCode();
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
      packageDetails_.WriteTo(output, _repeated_packageDetails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += packageDetails_.CalculateSize(_repeated_packageDetails_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListKnownPackagesResponse other) {
      if (other == null) {
        return;
      }
      packageDetails_.Add(other.packageDetails_);
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
            packageDetails_.AddEntriesFrom(input, _repeated_packageDetails_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PackageDetails : pb::IMessage<PackageDetails> {
    private static readonly pb::MessageParser<PackageDetails> _parser = new pb::MessageParser<PackageDetails>(() => new PackageDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PackageDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageManagementServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PackageDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PackageDetails(PackageDetails other) : this() {
      packageId_ = other.packageId_;
      packageSize_ = other.packageSize_;
      knownSince_ = other.knownSince_ != null ? other.knownSince_.Clone() : null;
      sourceDescription_ = other.sourceDescription_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PackageDetails Clone() {
      return new PackageDetails(this);
    }

    /// <summary>Field number for the "package_id" field.</summary>
    public const int PackageIdFieldNumber = 1;
    private string packageId_ = "";
    /// <summary>
    /// The identity of the DAML-LF package.
    /// Must be a valid PackageIdString (as describe in ``value.proto``).
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PackageId {
      get { return packageId_; }
      set {
        packageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "package_size" field.</summary>
    public const int PackageSizeFieldNumber = 2;
    private ulong packageSize_;
    /// <summary>
    /// Size of the package in bytes.
    /// The size of the package is given by the size of the ``daml_lf``
    /// ArchivePayload. See further details in ``daml_lf.proto``.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PackageSize {
      get { return packageSize_; }
      set {
        packageSize_ = value;
      }
    }

    /// <summary>Field number for the "known_since" field.</summary>
    public const int KnownSinceFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp knownSince_;
    /// <summary>
    /// Indicates since when the package is known to the backing participant.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp KnownSince {
      get { return knownSince_; }
      set {
        knownSince_ = value;
      }
    }

    /// <summary>Field number for the "source_description" field.</summary>
    public const int SourceDescriptionFieldNumber = 4;
    private string sourceDescription_ = "";
    /// <summary>
    /// Description provided by the backing participant describing where
    /// it got the package from.
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceDescription {
      get { return sourceDescription_; }
      set {
        sourceDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PackageDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PackageDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PackageId != other.PackageId) return false;
      if (PackageSize != other.PackageSize) return false;
      if (!object.Equals(KnownSince, other.KnownSince)) return false;
      if (SourceDescription != other.SourceDescription) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PackageId.Length != 0) hash ^= PackageId.GetHashCode();
      if (PackageSize != 0UL) hash ^= PackageSize.GetHashCode();
      if (knownSince_ != null) hash ^= KnownSince.GetHashCode();
      if (SourceDescription.Length != 0) hash ^= SourceDescription.GetHashCode();
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
      if (PackageId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PackageId);
      }
      if (PackageSize != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(PackageSize);
      }
      if (knownSince_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(KnownSince);
      }
      if (SourceDescription.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SourceDescription);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PackageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PackageId);
      }
      if (PackageSize != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PackageSize);
      }
      if (knownSince_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KnownSince);
      }
      if (SourceDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceDescription);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PackageDetails other) {
      if (other == null) {
        return;
      }
      if (other.PackageId.Length != 0) {
        PackageId = other.PackageId;
      }
      if (other.PackageSize != 0UL) {
        PackageSize = other.PackageSize;
      }
      if (other.knownSince_ != null) {
        if (knownSince_ == null) {
          KnownSince = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        KnownSince.MergeFrom(other.KnownSince);
      }
      if (other.SourceDescription.Length != 0) {
        SourceDescription = other.SourceDescription;
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
            PackageId = input.ReadString();
            break;
          }
          case 16: {
            PackageSize = input.ReadUInt64();
            break;
          }
          case 26: {
            if (knownSince_ == null) {
              KnownSince = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(KnownSince);
            break;
          }
          case 34: {
            SourceDescription = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class UploadDarFileRequest : pb::IMessage<UploadDarFileRequest> {
    private static readonly pb::MessageParser<UploadDarFileRequest> _parser = new pb::MessageParser<UploadDarFileRequest>(() => new UploadDarFileRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadDarFileRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageManagementServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadDarFileRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadDarFileRequest(UploadDarFileRequest other) : this() {
      darFile_ = other.darFile_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadDarFileRequest Clone() {
      return new UploadDarFileRequest(this);
    }

    /// <summary>Field number for the "dar_file" field.</summary>
    public const int DarFileFieldNumber = 1;
    private pb::ByteString darFile_ = pb::ByteString.Empty;
    /// <summary>
    /// Contains a DAML archive DAR file, which in turn is a jar like zipped
    /// container for ``daml_lf`` archives. See further details in
    /// ``daml_lf.proto``.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString DarFile {
      get { return darFile_; }
      set {
        darFile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadDarFileRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadDarFileRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DarFile != other.DarFile) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DarFile.Length != 0) hash ^= DarFile.GetHashCode();
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
      if (DarFile.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(DarFile);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DarFile.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(DarFile);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UploadDarFileRequest other) {
      if (other == null) {
        return;
      }
      if (other.DarFile.Length != 0) {
        DarFile = other.DarFile;
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
            DarFile = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// An empty message that is received when the upload operation succeeded.
  /// </summary>
  public sealed partial class UploadDarFileResponse : pb::IMessage<UploadDarFileResponse> {
    private static readonly pb::MessageParser<UploadDarFileResponse> _parser = new pb::MessageParser<UploadDarFileResponse>(() => new UploadDarFileResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadDarFileResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageManagementServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadDarFileResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadDarFileResponse(UploadDarFileResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadDarFileResponse Clone() {
      return new UploadDarFileResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadDarFileResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadDarFileResponse other) {
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
    public void MergeFrom(UploadDarFileResponse other) {
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

  }

  #endregion

}

#endregion Designer generated code
