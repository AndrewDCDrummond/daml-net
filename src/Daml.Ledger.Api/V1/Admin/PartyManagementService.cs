// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/admin/party_management_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Ledger.Api.V1.Admin {

  /// <summary>Holder for reflection information generated from com/digitalasset/ledger/api/v1/admin/party_management_service.proto</summary>
  public static partial class PartyManagementServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/ledger/api/v1/admin/party_management_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PartyManagementServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNjb20vZGlnaXRhbGFzc2V0L2xlZGdlci9hcGkvdjEvYWRtaW4vcGFydHlf",
            "bWFuYWdlbWVudF9zZXJ2aWNlLnByb3RvEiRjb20uZGlnaXRhbGFzc2V0Lmxl",
            "ZGdlci5hcGkudjEuYWRtaW4iGQoXR2V0UGFydGljaXBhbnRJZFJlcXVlc3Qi",
            "MgoYR2V0UGFydGljaXBhbnRJZFJlc3BvbnNlEhYKDnBhcnRpY2lwYW50X2lk",
            "GAEgASgJIhkKF0xpc3RLbm93blBhcnRpZXNSZXF1ZXN0ImUKGExpc3RLbm93",
            "blBhcnRpZXNSZXNwb25zZRJJCg1wYXJ0eV9kZXRhaWxzGAEgAygLMjIuY29t",
            "LmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLmFkbWluLlBhcnR5RGV0YWls",
            "cyJFCgxQYXJ0eURldGFpbHMSDQoFcGFydHkYASABKAkSFAoMZGlzcGxheV9u",
            "YW1lGAIgASgJEhAKCGlzX2xvY2FsGAMgASgIIkMKFEFsbG9jYXRlUGFydHlS",
            "ZXF1ZXN0EhUKDXBhcnR5X2lkX2hpbnQYASABKAkSFAoMZGlzcGxheV9uYW1l",
            "GAIgASgJImIKFUFsbG9jYXRlUGFydHlSZXNwb25zZRJJCg1wYXJ0eV9kZXRh",
            "aWxzGAEgASgLMjIuY29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLmFk",
            "bWluLlBhcnR5RGV0YWlsczLLAwoWUGFydHlNYW5hZ2VtZW50U2VydmljZRKR",
            "AQoQR2V0UGFydGljaXBhbnRJZBI9LmNvbS5kaWdpdGFsYXNzZXQubGVkZ2Vy",
            "LmFwaS52MS5hZG1pbi5HZXRQYXJ0aWNpcGFudElkUmVxdWVzdBo+LmNvbS5k",
            "aWdpdGFsYXNzZXQubGVkZ2VyLmFwaS52MS5hZG1pbi5HZXRQYXJ0aWNpcGFu",
            "dElkUmVzcG9uc2USkQEKEExpc3RLbm93blBhcnRpZXMSPS5jb20uZGlnaXRh",
            "bGFzc2V0LmxlZGdlci5hcGkudjEuYWRtaW4uTGlzdEtub3duUGFydGllc1Jl",
            "cXVlc3QaPi5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEuYWRtaW4u",
            "TGlzdEtub3duUGFydGllc1Jlc3BvbnNlEogBCg1BbGxvY2F0ZVBhcnR5Ejou",
            "Y29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLmFkbWluLkFsbG9jYXRl",
            "UGFydHlSZXF1ZXN0GjsuY29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYx",
            "LmFkbWluLkFsbG9jYXRlUGFydHlSZXNwb25zZUJvCiRjb20uZGlnaXRhbGFz",
            "c2V0LmxlZGdlci5hcGkudjEuYWRtaW5CIFBhcnR5TWFuYWdlbWVudFNlcnZp",
            "Y2VPdXRlckNsYXNzqgIkQ29tLkRpZ2l0YWxBc3NldC5MZWRnZXIuQXBpLlYx",
            "LkFkbWluYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetParticipantIdRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetParticipantIdRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetParticipantIdResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetParticipantIdResponse.Parser, new[]{ "ParticipantId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPartiesRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPartiesRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPartiesResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPartiesResponse.Parser, new[]{ "PartyDetails" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails), global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails.Parser, new[]{ "Party", "DisplayName", "IsLocal" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.AllocatePartyRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.AllocatePartyRequest.Parser, new[]{ "PartyIdHint", "DisplayName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.AllocatePartyResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.AllocatePartyResponse.Parser, new[]{ "PartyDetails" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetParticipantIdRequest : pb::IMessage<GetParticipantIdRequest> {
    private static readonly pb::MessageParser<GetParticipantIdRequest> _parser = new pb::MessageParser<GetParticipantIdRequest>(() => new GetParticipantIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetParticipantIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParticipantIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParticipantIdRequest(GetParticipantIdRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParticipantIdRequest Clone() {
      return new GetParticipantIdRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetParticipantIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetParticipantIdRequest other) {
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
    public void MergeFrom(GetParticipantIdRequest other) {
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

  public sealed partial class GetParticipantIdResponse : pb::IMessage<GetParticipantIdResponse> {
    private static readonly pb::MessageParser<GetParticipantIdResponse> _parser = new pb::MessageParser<GetParticipantIdResponse>(() => new GetParticipantIdResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetParticipantIdResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParticipantIdResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParticipantIdResponse(GetParticipantIdResponse other) : this() {
      participantId_ = other.participantId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParticipantIdResponse Clone() {
      return new GetParticipantIdResponse(this);
    }

    /// <summary>Field number for the "participant_id" field.</summary>
    public const int ParticipantIdFieldNumber = 1;
    private string participantId_ = "";
    /// <summary>
    /// Identifier of the participant, which SHOULD be globally unique.
    /// Must be a valid LedgerString (as describe in ``value.proto``).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ParticipantId {
      get { return participantId_; }
      set {
        participantId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetParticipantIdResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetParticipantIdResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ParticipantId != other.ParticipantId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ParticipantId.Length != 0) hash ^= ParticipantId.GetHashCode();
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
      if (ParticipantId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ParticipantId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ParticipantId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParticipantId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetParticipantIdResponse other) {
      if (other == null) {
        return;
      }
      if (other.ParticipantId.Length != 0) {
        ParticipantId = other.ParticipantId;
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
            ParticipantId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ListKnownPartiesRequest : pb::IMessage<ListKnownPartiesRequest> {
    private static readonly pb::MessageParser<ListKnownPartiesRequest> _parser = new pb::MessageParser<ListKnownPartiesRequest>(() => new ListKnownPartiesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListKnownPartiesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPartiesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPartiesRequest(ListKnownPartiesRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPartiesRequest Clone() {
      return new ListKnownPartiesRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListKnownPartiesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListKnownPartiesRequest other) {
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
    public void MergeFrom(ListKnownPartiesRequest other) {
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

  public sealed partial class ListKnownPartiesResponse : pb::IMessage<ListKnownPartiesResponse> {
    private static readonly pb::MessageParser<ListKnownPartiesResponse> _parser = new pb::MessageParser<ListKnownPartiesResponse>(() => new ListKnownPartiesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListKnownPartiesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPartiesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPartiesResponse(ListKnownPartiesResponse other) : this() {
      partyDetails_ = other.partyDetails_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListKnownPartiesResponse Clone() {
      return new ListKnownPartiesResponse(this);
    }

    /// <summary>Field number for the "party_details" field.</summary>
    public const int PartyDetailsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails> _repeated_partyDetails_codec
        = pb::FieldCodec.ForMessage(10, global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails.Parser);
    private readonly pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails> partyDetails_ = new pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails>();
    /// <summary>
    /// The details of all DAML parties hosted by the participant.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails> PartyDetails {
      get { return partyDetails_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListKnownPartiesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListKnownPartiesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!partyDetails_.Equals(other.partyDetails_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= partyDetails_.GetHashCode();
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
      partyDetails_.WriteTo(output, _repeated_partyDetails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += partyDetails_.CalculateSize(_repeated_partyDetails_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListKnownPartiesResponse other) {
      if (other == null) {
        return;
      }
      partyDetails_.Add(other.partyDetails_);
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
            partyDetails_.AddEntriesFrom(input, _repeated_partyDetails_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PartyDetails : pb::IMessage<PartyDetails> {
    private static readonly pb::MessageParser<PartyDetails> _parser = new pb::MessageParser<PartyDetails>(() => new PartyDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PartyDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PartyDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PartyDetails(PartyDetails other) : this() {
      party_ = other.party_;
      displayName_ = other.displayName_;
      isLocal_ = other.isLocal_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PartyDetails Clone() {
      return new PartyDetails(this);
    }

    /// <summary>Field number for the "party" field.</summary>
    public const int PartyFieldNumber = 1;
    private string party_ = "";
    /// <summary>
    /// The stable unique identifier of a DAML party.
    /// Must be a valid PartyIdString (as described in ``value.proto``).
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Party {
      get { return party_; }
      set {
        party_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Human readable name associated with the party. Caution, it might not be
    /// unique.
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_local" field.</summary>
    public const int IsLocalFieldNumber = 3;
    private bool isLocal_;
    /// <summary>
    /// true if party is hosted by the backing participant.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsLocal {
      get { return isLocal_; }
      set {
        isLocal_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PartyDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PartyDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Party != other.Party) return false;
      if (DisplayName != other.DisplayName) return false;
      if (IsLocal != other.IsLocal) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Party.Length != 0) hash ^= Party.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (IsLocal != false) hash ^= IsLocal.GetHashCode();
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
      if (Party.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Party);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (IsLocal != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsLocal);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Party.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Party);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (IsLocal != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PartyDetails other) {
      if (other == null) {
        return;
      }
      if (other.Party.Length != 0) {
        Party = other.Party;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.IsLocal != false) {
        IsLocal = other.IsLocal;
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
            Party = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            IsLocal = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AllocatePartyRequest : pb::IMessage<AllocatePartyRequest> {
    private static readonly pb::MessageParser<AllocatePartyRequest> _parser = new pb::MessageParser<AllocatePartyRequest>(() => new AllocatePartyRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AllocatePartyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocatePartyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocatePartyRequest(AllocatePartyRequest other) : this() {
      partyIdHint_ = other.partyIdHint_;
      displayName_ = other.displayName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocatePartyRequest Clone() {
      return new AllocatePartyRequest(this);
    }

    /// <summary>Field number for the "party_id_hint" field.</summary>
    public const int PartyIdHintFieldNumber = 1;
    private string partyIdHint_ = "";
    /// <summary>
    /// A hint to the backing participant what party id to allocate. It can be
    /// ignored.
    /// Must be a valid PartyIdString (as describe in ``value.proto``).
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PartyIdHint {
      get { return partyIdHint_; }
      set {
        partyIdHint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Human readable name of the party to be added to the participant. It doesn't
    /// have to be unique.
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AllocatePartyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AllocatePartyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PartyIdHint != other.PartyIdHint) return false;
      if (DisplayName != other.DisplayName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PartyIdHint.Length != 0) hash ^= PartyIdHint.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (PartyIdHint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PartyIdHint);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PartyIdHint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PartyIdHint);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AllocatePartyRequest other) {
      if (other == null) {
        return;
      }
      if (other.PartyIdHint.Length != 0) {
        PartyIdHint = other.PartyIdHint;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
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
            PartyIdHint = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AllocatePartyResponse : pb::IMessage<AllocatePartyResponse> {
    private static readonly pb::MessageParser<AllocatePartyResponse> _parser = new pb::MessageParser<AllocatePartyResponse>(() => new AllocatePartyResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AllocatePartyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyManagementServiceReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocatePartyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocatePartyResponse(AllocatePartyResponse other) : this() {
      partyDetails_ = other.partyDetails_ != null ? other.partyDetails_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocatePartyResponse Clone() {
      return new AllocatePartyResponse(this);
    }

    /// <summary>Field number for the "party_details" field.</summary>
    public const int PartyDetailsFieldNumber = 1;
    private global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails partyDetails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails PartyDetails {
      get { return partyDetails_; }
      set {
        partyDetails_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AllocatePartyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AllocatePartyResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PartyDetails, other.PartyDetails)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (partyDetails_ != null) hash ^= PartyDetails.GetHashCode();
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
      if (partyDetails_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PartyDetails);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (partyDetails_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PartyDetails);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AllocatePartyResponse other) {
      if (other == null) {
        return;
      }
      if (other.partyDetails_ != null) {
        if (partyDetails_ == null) {
          PartyDetails = new global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails();
        }
        PartyDetails.MergeFrom(other.PartyDetails);
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
            if (partyDetails_ == null) {
              PartyDetails = new global::Com.DigitalAsset.Ledger.Api.V1.Admin.PartyDetails();
            }
            input.ReadMessage(PartyDetails);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code