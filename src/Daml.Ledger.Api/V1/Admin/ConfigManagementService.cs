// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/admin/config_management_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Ledger.Api.V1.Admin {

  /// <summary>Holder for reflection information generated from com/digitalasset/ledger/api/v1/admin/config_management_service.proto</summary>
  public static partial class ConfigManagementServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/ledger/api/v1/admin/config_management_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigManagementServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRjb20vZGlnaXRhbGFzc2V0L2xlZGdlci9hcGkvdjEvYWRtaW4vY29uZmln",
            "X21hbmFnZW1lbnRfc2VydmljZS5wcm90bxIkY29tLmRpZ2l0YWxhc3NldC5s",
            "ZWRnZXIuYXBpLnYxLmFkbWluGh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24u",
            "cHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iFQoTR2V0",
            "VGltZU1vZGVsUmVxdWVzdCJ9ChRHZXRUaW1lTW9kZWxSZXNwb25zZRIgChhj",
            "b25maWd1cmF0aW9uX2dlbmVyYXRpb24YASABKAMSQwoKdGltZV9tb2RlbBgC",
            "IAEoCzIvLmNvbS5kaWdpdGFsYXNzZXQubGVkZ2VyLmFwaS52MS5hZG1pbi5U",
            "aW1lTW9kZWwi0AEKE1NldFRpbWVNb2RlbFJlcXVlc3QSFQoNc3VibWlzc2lv",
            "bl9pZBgBIAEoCRI3ChNtYXhpbXVtX3JlY29yZF90aW1lGAIgASgLMhouZ29v",
            "Z2xlLnByb3RvYnVmLlRpbWVzdGFtcBIgChhjb25maWd1cmF0aW9uX2dlbmVy",
            "YXRpb24YAyABKAMSRwoObmV3X3RpbWVfbW9kZWwYBCABKAsyLy5jb20uZGln",
            "aXRhbGFzc2V0LmxlZGdlci5hcGkudjEuYWRtaW4uVGltZU1vZGVsIjgKFFNl",
            "dFRpbWVNb2RlbFJlc3BvbnNlEiAKGGNvbmZpZ3VyYXRpb25fZ2VuZXJhdGlv",
            "bhgBIAEoAyKmAQoJVGltZU1vZGVsEjoKF21pbl90cmFuc2FjdGlvbl9sYXRl",
            "bmN5GAEgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uEjEKDm1heF9j",
            "bG9ja19za2V3GAIgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uEioK",
            "B21heF90dGwYAyABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb24yqQIK",
            "F0NvbmZpZ01hbmFnZW1lbnRTZXJ2aWNlEoUBCgxHZXRUaW1lTW9kZWwSOS5j",
            "b20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEuYWRtaW4uR2V0VGltZU1v",
            "ZGVsUmVxdWVzdBo6LmNvbS5kaWdpdGFsYXNzZXQubGVkZ2VyLmFwaS52MS5h",
            "ZG1pbi5HZXRUaW1lTW9kZWxSZXNwb25zZRKFAQoMU2V0VGltZU1vZGVsEjku",
            "Y29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLmFkbWluLlNldFRpbWVN",
            "b2RlbFJlcXVlc3QaOi5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEu",
            "YWRtaW4uU2V0VGltZU1vZGVsUmVzcG9uc2VCcAokY29tLmRpZ2l0YWxhc3Nl",
            "dC5sZWRnZXIuYXBpLnYxLmFkbWluQiFDb25maWdNYW5hZ2VtZW50U2Vydmlj",
            "ZU91dGVyQ2xhc3OqAiRDb20uRGlnaXRhbEFzc2V0LkxlZGdlci5BcGkuVjEu",
            "QWRtaW5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.GetTimeModelResponse.Parser, new[]{ "ConfigurationGeneration", "TimeModel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest), global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelRequest.Parser, new[]{ "SubmissionId", "MaximumRecordTime", "ConfigurationGeneration", "NewTimeModel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse), global::Com.DigitalAsset.Ledger.Api.V1.Admin.SetTimeModelResponse.Parser, new[]{ "ConfigurationGeneration" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel), global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel.Parser, new[]{ "MinTransactionLatency", "MaxClockSkew", "MaxTtl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetTimeModelRequest : pb::IMessage<GetTimeModelRequest> {
    private static readonly pb::MessageParser<GetTimeModelRequest> _parser = new pb::MessageParser<GetTimeModelRequest>(() => new GetTimeModelRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTimeModelRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.ConfigManagementServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeModelRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeModelRequest(GetTimeModelRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeModelRequest Clone() {
      return new GetTimeModelRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTimeModelRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTimeModelRequest other) {
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
    public void MergeFrom(GetTimeModelRequest other) {
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

  public sealed partial class GetTimeModelResponse : pb::IMessage<GetTimeModelResponse> {
    private static readonly pb::MessageParser<GetTimeModelResponse> _parser = new pb::MessageParser<GetTimeModelResponse>(() => new GetTimeModelResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTimeModelResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.ConfigManagementServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeModelResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeModelResponse(GetTimeModelResponse other) : this() {
      configurationGeneration_ = other.configurationGeneration_;
      timeModel_ = other.timeModel_ != null ? other.timeModel_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeModelResponse Clone() {
      return new GetTimeModelResponse(this);
    }

    /// <summary>Field number for the "configuration_generation" field.</summary>
    public const int ConfigurationGenerationFieldNumber = 1;
    private long configurationGeneration_;
    /// <summary>
    /// The current configuration generation. The generation is a monotonically increasing
    /// integer that is incremented on each change. Used when setting the time model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ConfigurationGeneration {
      get { return configurationGeneration_; }
      set {
        configurationGeneration_ = value;
      }
    }

    /// <summary>Field number for the "time_model" field.</summary>
    public const int TimeModelFieldNumber = 2;
    private global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel timeModel_;
    /// <summary>
    /// The current ledger time model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel TimeModel {
      get { return timeModel_; }
      set {
        timeModel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTimeModelResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTimeModelResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigurationGeneration != other.ConfigurationGeneration) return false;
      if (!object.Equals(TimeModel, other.TimeModel)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigurationGeneration != 0L) hash ^= ConfigurationGeneration.GetHashCode();
      if (timeModel_ != null) hash ^= TimeModel.GetHashCode();
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
      if (ConfigurationGeneration != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ConfigurationGeneration);
      }
      if (timeModel_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TimeModel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConfigurationGeneration != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ConfigurationGeneration);
      }
      if (timeModel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeModel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetTimeModelResponse other) {
      if (other == null) {
        return;
      }
      if (other.ConfigurationGeneration != 0L) {
        ConfigurationGeneration = other.ConfigurationGeneration;
      }
      if (other.timeModel_ != null) {
        if (timeModel_ == null) {
          TimeModel = new global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel();
        }
        TimeModel.MergeFrom(other.TimeModel);
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
          case 8: {
            ConfigurationGeneration = input.ReadInt64();
            break;
          }
          case 18: {
            if (timeModel_ == null) {
              TimeModel = new global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel();
            }
            input.ReadMessage(TimeModel);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetTimeModelRequest : pb::IMessage<SetTimeModelRequest> {
    private static readonly pb::MessageParser<SetTimeModelRequest> _parser = new pb::MessageParser<SetTimeModelRequest>(() => new SetTimeModelRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetTimeModelRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.ConfigManagementServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeModelRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeModelRequest(SetTimeModelRequest other) : this() {
      submissionId_ = other.submissionId_;
      maximumRecordTime_ = other.maximumRecordTime_ != null ? other.maximumRecordTime_.Clone() : null;
      configurationGeneration_ = other.configurationGeneration_;
      newTimeModel_ = other.newTimeModel_ != null ? other.newTimeModel_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeModelRequest Clone() {
      return new SetTimeModelRequest(this);
    }

    /// <summary>Field number for the "submission_id" field.</summary>
    public const int SubmissionIdFieldNumber = 1;
    private string submissionId_ = "";
    /// <summary>
    /// Submission identifier used for tracking the request and to reject
    /// duplicate submissions.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SubmissionId {
      get { return submissionId_; }
      set {
        submissionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "maximum_record_time" field.</summary>
    public const int MaximumRecordTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp maximumRecordTime_;
    /// <summary>
    /// Deadline for the configuration change after which the change is rejected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp MaximumRecordTime {
      get { return maximumRecordTime_; }
      set {
        maximumRecordTime_ = value;
      }
    }

    /// <summary>Field number for the "configuration_generation" field.</summary>
    public const int ConfigurationGenerationFieldNumber = 3;
    private long configurationGeneration_;
    /// <summary>
    /// The current configuration generation which we're submitting the change against.
    /// This is used to perform a compare-and-swap of the configuration to
    /// safeguard against concurrent modifications.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ConfigurationGeneration {
      get { return configurationGeneration_; }
      set {
        configurationGeneration_ = value;
      }
    }

    /// <summary>Field number for the "new_time_model" field.</summary>
    public const int NewTimeModelFieldNumber = 4;
    private global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel newTimeModel_;
    /// <summary>
    /// The new time model that replaces the current one.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel NewTimeModel {
      get { return newTimeModel_; }
      set {
        newTimeModel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetTimeModelRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetTimeModelRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SubmissionId != other.SubmissionId) return false;
      if (!object.Equals(MaximumRecordTime, other.MaximumRecordTime)) return false;
      if (ConfigurationGeneration != other.ConfigurationGeneration) return false;
      if (!object.Equals(NewTimeModel, other.NewTimeModel)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SubmissionId.Length != 0) hash ^= SubmissionId.GetHashCode();
      if (maximumRecordTime_ != null) hash ^= MaximumRecordTime.GetHashCode();
      if (ConfigurationGeneration != 0L) hash ^= ConfigurationGeneration.GetHashCode();
      if (newTimeModel_ != null) hash ^= NewTimeModel.GetHashCode();
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
      if (SubmissionId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SubmissionId);
      }
      if (maximumRecordTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MaximumRecordTime);
      }
      if (ConfigurationGeneration != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ConfigurationGeneration);
      }
      if (newTimeModel_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(NewTimeModel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SubmissionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SubmissionId);
      }
      if (maximumRecordTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaximumRecordTime);
      }
      if (ConfigurationGeneration != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ConfigurationGeneration);
      }
      if (newTimeModel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NewTimeModel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetTimeModelRequest other) {
      if (other == null) {
        return;
      }
      if (other.SubmissionId.Length != 0) {
        SubmissionId = other.SubmissionId;
      }
      if (other.maximumRecordTime_ != null) {
        if (maximumRecordTime_ == null) {
          MaximumRecordTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        MaximumRecordTime.MergeFrom(other.MaximumRecordTime);
      }
      if (other.ConfigurationGeneration != 0L) {
        ConfigurationGeneration = other.ConfigurationGeneration;
      }
      if (other.newTimeModel_ != null) {
        if (newTimeModel_ == null) {
          NewTimeModel = new global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel();
        }
        NewTimeModel.MergeFrom(other.NewTimeModel);
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
            SubmissionId = input.ReadString();
            break;
          }
          case 18: {
            if (maximumRecordTime_ == null) {
              MaximumRecordTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MaximumRecordTime);
            break;
          }
          case 24: {
            ConfigurationGeneration = input.ReadInt64();
            break;
          }
          case 34: {
            if (newTimeModel_ == null) {
              NewTimeModel = new global::Com.DigitalAsset.Ledger.Api.V1.Admin.TimeModel();
            }
            input.ReadMessage(NewTimeModel);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetTimeModelResponse : pb::IMessage<SetTimeModelResponse> {
    private static readonly pb::MessageParser<SetTimeModelResponse> _parser = new pb::MessageParser<SetTimeModelResponse>(() => new SetTimeModelResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetTimeModelResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.ConfigManagementServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeModelResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeModelResponse(SetTimeModelResponse other) : this() {
      configurationGeneration_ = other.configurationGeneration_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeModelResponse Clone() {
      return new SetTimeModelResponse(this);
    }

    /// <summary>Field number for the "configuration_generation" field.</summary>
    public const int ConfigurationGenerationFieldNumber = 1;
    private long configurationGeneration_;
    /// <summary>
    /// The configuration generation of the committed time model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ConfigurationGeneration {
      get { return configurationGeneration_; }
      set {
        configurationGeneration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetTimeModelResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetTimeModelResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigurationGeneration != other.ConfigurationGeneration) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigurationGeneration != 0L) hash ^= ConfigurationGeneration.GetHashCode();
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
      if (ConfigurationGeneration != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ConfigurationGeneration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConfigurationGeneration != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ConfigurationGeneration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetTimeModelResponse other) {
      if (other == null) {
        return;
      }
      if (other.ConfigurationGeneration != 0L) {
        ConfigurationGeneration = other.ConfigurationGeneration;
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
          case 8: {
            ConfigurationGeneration = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TimeModel : pb::IMessage<TimeModel> {
    private static readonly pb::MessageParser<TimeModel> _parser = new pb::MessageParser<TimeModel>(() => new TimeModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.ConfigManagementServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeModel(TimeModel other) : this() {
      minTransactionLatency_ = other.minTransactionLatency_ != null ? other.minTransactionLatency_.Clone() : null;
      maxClockSkew_ = other.maxClockSkew_ != null ? other.maxClockSkew_.Clone() : null;
      maxTtl_ = other.maxTtl_ != null ? other.maxTtl_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeModel Clone() {
      return new TimeModel(this);
    }

    /// <summary>Field number for the "min_transaction_latency" field.</summary>
    public const int MinTransactionLatencyFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration minTransactionLatency_;
    /// <summary>
    /// The expected minimum latency of a transaction.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration MinTransactionLatency {
      get { return minTransactionLatency_; }
      set {
        minTransactionLatency_ = value;
      }
    }

    /// <summary>Field number for the "max_clock_skew" field.</summary>
    public const int MaxClockSkewFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration maxClockSkew_;
    /// <summary>
    /// The maximum allowed clock skew between the ledger and clients.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration MaxClockSkew {
      get { return maxClockSkew_; }
      set {
        maxClockSkew_ = value;
      }
    }

    /// <summary>Field number for the "max_ttl" field.</summary>
    public const int MaxTtlFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration maxTtl_;
    /// <summary>
    /// The maximum allowed time to live for a transaction.
    /// Must be greater than the derived minimum time to live.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration MaxTtl {
      get { return maxTtl_; }
      set {
        maxTtl_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MinTransactionLatency, other.MinTransactionLatency)) return false;
      if (!object.Equals(MaxClockSkew, other.MaxClockSkew)) return false;
      if (!object.Equals(MaxTtl, other.MaxTtl)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (minTransactionLatency_ != null) hash ^= MinTransactionLatency.GetHashCode();
      if (maxClockSkew_ != null) hash ^= MaxClockSkew.GetHashCode();
      if (maxTtl_ != null) hash ^= MaxTtl.GetHashCode();
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
      if (minTransactionLatency_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MinTransactionLatency);
      }
      if (maxClockSkew_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MaxClockSkew);
      }
      if (maxTtl_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MaxTtl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (minTransactionLatency_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MinTransactionLatency);
      }
      if (maxClockSkew_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxClockSkew);
      }
      if (maxTtl_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxTtl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeModel other) {
      if (other == null) {
        return;
      }
      if (other.minTransactionLatency_ != null) {
        if (minTransactionLatency_ == null) {
          MinTransactionLatency = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        MinTransactionLatency.MergeFrom(other.MinTransactionLatency);
      }
      if (other.maxClockSkew_ != null) {
        if (maxClockSkew_ == null) {
          MaxClockSkew = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        MaxClockSkew.MergeFrom(other.MaxClockSkew);
      }
      if (other.maxTtl_ != null) {
        if (maxTtl_ == null) {
          MaxTtl = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        MaxTtl.MergeFrom(other.MaxTtl);
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
            if (minTransactionLatency_ == null) {
              MinTransactionLatency = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MinTransactionLatency);
            break;
          }
          case 18: {
            if (maxClockSkew_ == null) {
              MaxClockSkew = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MaxClockSkew);
            break;
          }
          case 26: {
            if (maxTtl_ == null) {
              MaxTtl = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MaxTtl);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code