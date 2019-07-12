// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/command_service.proto
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
  /// Command Service is able to correlate submitted commands with completion data, identify timeouts, and return contextual
  /// information with each tracking result. This supports the implementation of stateless clients.
  /// </summary>
  public static partial class CommandService
  {
    static readonly string __ServiceName = "com.digitalasset.ledger.api.v1.CommandService";

    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest> __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse> __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitForTransactionIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse> __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitForTransactionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse> __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitForTransactionTreeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SubmitAndWait = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitAndWait",
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse> __Method_SubmitAndWaitForTransactionId = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitAndWaitForTransactionId",
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitForTransactionIdResponse);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse> __Method_SubmitAndWaitForTransaction = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitAndWaitForTransaction",
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitForTransactionResponse);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse> __Method_SubmitAndWaitForTransactionTree = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitAndWaitForTransactionTree",
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_SubmitAndWaitForTransactionTreeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.CommandServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CommandService</summary>
    [grpc::BindServiceMethod(typeof(CommandService), "BindService")]
    public abstract partial class CommandServiceBase
    {
      /// <summary>
      /// Submits a single composite command and waits for its result.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SubmitAndWait(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction id.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse> SubmitAndWaitForTransactionId(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse> SubmitAndWaitForTransaction(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction tree.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse> SubmitAndWaitForTransactionTree(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CommandService</summary>
    public partial class CommandServiceClient : grpc::ClientBase<CommandServiceClient>
    {
      /// <summary>Creates a new client for CommandService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CommandServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CommandService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CommandServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CommandServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CommandServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Submits a single composite command and waits for its result.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SubmitAndWait(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWait(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command and waits for its result.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SubmitAndWait(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitAndWait, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command and waits for its result.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SubmitAndWaitAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command and waits for its result.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SubmitAndWaitAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitAndWait, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction id.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse SubmitAndWaitForTransactionId(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitForTransactionId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction id.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse SubmitAndWaitForTransactionId(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitAndWaitForTransactionId, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction id.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse> SubmitAndWaitForTransactionIdAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitForTransactionIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction id.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse> SubmitAndWaitForTransactionIdAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitAndWaitForTransactionId, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse SubmitAndWaitForTransaction(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitForTransaction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse SubmitAndWaitForTransaction(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitAndWaitForTransaction, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse> SubmitAndWaitForTransactionAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitForTransactionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse> SubmitAndWaitForTransactionAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitAndWaitForTransaction, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction tree.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse SubmitAndWaitForTransactionTree(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitForTransactionTree(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction tree.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse SubmitAndWaitForTransactionTree(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitAndWaitForTransactionTree, null, options, request);
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction tree.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse> SubmitAndWaitForTransactionTreeAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitAndWaitForTransactionTreeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Submits a single composite command, waits for its result, and returns the transaction tree.
      /// Returns ``RESOURCE_EXHAUSTED`` if the number of in-flight commands reached the maximum (if a limit is configured).
      /// Propagates the gRPC error of failed submissions including DAML interpretation errors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse> SubmitAndWaitForTransactionTreeAsync(global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitAndWaitForTransactionTree, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CommandServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CommandServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CommandServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SubmitAndWait, serviceImpl.SubmitAndWait)
          .AddMethod(__Method_SubmitAndWaitForTransactionId, serviceImpl.SubmitAndWaitForTransactionId)
          .AddMethod(__Method_SubmitAndWaitForTransaction, serviceImpl.SubmitAndWaitForTransaction)
          .AddMethod(__Method_SubmitAndWaitForTransactionTree, serviceImpl.SubmitAndWaitForTransactionTree).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CommandServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SubmitAndWait, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.SubmitAndWait));
      serviceBinder.AddMethod(__Method_SubmitAndWaitForTransactionId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionIdResponse>(serviceImpl.SubmitAndWaitForTransactionId));
      serviceBinder.AddMethod(__Method_SubmitAndWaitForTransaction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionResponse>(serviceImpl.SubmitAndWaitForTransaction));
      serviceBinder.AddMethod(__Method_SubmitAndWaitForTransactionTree, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitRequest, global::Com.DigitalAsset.Ledger.Api.V1.SubmitAndWaitForTransactionTreeResponse>(serviceImpl.SubmitAndWaitForTransactionTree));
    }

  }
}
#endregion
