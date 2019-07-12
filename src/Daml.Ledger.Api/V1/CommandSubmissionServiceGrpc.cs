// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/command_submission_service.proto
// </auto-generated>
// Original file comments:
// Copyright (c) 2019 Digital Asset (Switzerland) GmbH and/or its affiliates. All rights reserved.
// SPDX-License-Identifier: Apache-2.0
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.DigitalAsset.Ledger.Api.V1 {
  /// <summary>
  /// Allows clients to attempt advancing the ledger's state by submitting commands.
  /// The final states of their submissions are disclosed by the Command Completion Service.
  /// The on-ledger effects of their submissions are disclosed by the Transaction Service.
  /// Commands may fail in 4 distinct manners:
  ///
  /// 1) ``INVALID_PARAMETER`` gRPC error on malformed payloads and missing required fields.
  /// 2) Failure communicated in the gRPC error.
  /// 3) Failure communicated in a Completion.
  /// 4) A Checkpoint with ``record_time`` > command ``mrt`` arrives through the Completion Stream, and the command's Completion was not visible before. In this case the command is lost.
  ///
  /// Clients that do not receive a successful completion about their submission MUST NOT assume that it was successful.
  /// Clients SHOULD subscribe to the CompletionStream before starting to submit commands to prevent race conditions.
  ///
  /// Interprocess tracing of command submissions may be achieved via Zipkin by filling out the ``trace_context`` field.
  /// The server will return a child context of the submitted one, (or a new one if the context was missing) on both the Completion and Transaction streams.
  /// </summary>
  public static partial class CommandSubmissionService
  {
    static readonly string __ServiceName = "com.digitalasset.ledger.api.v1.CommandSubmissionService";

    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest> __Marshaller_com_digitalasset_ledger_api_v1_SubmitRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Submit = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Submit",
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.CommandSubmissionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CommandSubmissionService</summary>
    [grpc::BindServiceMethod(typeof(CommandSubmissionService), "BindService")]
    public abstract partial class CommandSubmissionServiceBase
    {
      /// <summary>
      /// Submit a single composite command.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Submit(global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CommandSubmissionService</summary>
    public partial class CommandSubmissionServiceClient : grpc::ClientBase<CommandSubmissionServiceClient>
    {
      /// <summary>Creates a new client for CommandSubmissionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CommandSubmissionServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CommandSubmissionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CommandSubmissionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CommandSubmissionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CommandSubmissionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Submit a single composite command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Submit(global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Submit(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submit a single composite command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Submit(global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Submit, null, options, request);
      }
      /// <summary>
      /// Submit a single composite command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SubmitAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submit a single composite command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SubmitAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Submit, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CommandSubmissionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CommandSubmissionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CommandSubmissionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Submit, serviceImpl.Submit).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CommandSubmissionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Submit, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Submit));
    }

  }
}
#endregion