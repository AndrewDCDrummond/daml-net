// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/testing/reset_service.proto
// </auto-generated>
// Original file comments:
// Copyright (c) 2019 Digital Asset (Switzerland) GmbH and/or its affiliates. All rights reserved.
// SPDX-License-Identifier: Apache-2.0
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.DigitalAsset.Ledger.Api.V1.Testing {
  /// <summary>
  /// Service to reset the ledger state. The goal here is to be able to reset the state in a way
  /// that's much faster compared to restarting the whole ledger application (be it a sandbox
  /// or the real ledger server).
  ///
  /// Note that *all* state present in the ledger implementation will be reset, most importantly
  /// including the ledger ID. This means that clients will have to re-fetch the ledger ID
  /// from the identity service after hitting this endpoint.
  ///
  /// The semantics are as follows:
  ///
  /// * When the reset service returns the reset is initiated, but not completed;
  /// * While the reset is performed, the ledger will not accept new requests. In fact we guarantee
  ///   that ledger stops accepting new requests by the time the response to Reset is delivered;
  /// * In-flight requests might be aborted, we make no guarantees on when or how quickly this
  ///   happens;
  /// * The ledger might be unavailable for a period of time before the reset is complete.
  ///
  /// Given the above, the recommended mode of operation for clients of the reset endpoint is to
  /// call it, then call the ledger identity endpoint in a retry loop that will tolerate a brief
  /// window when the ledger is down, and resume operation as soon as the new ledger ID is delivered.
  ///
  /// Note that this service will be available on the sandbox and might be available in some other testing
  /// environments, but will *never* be available in production.
  /// </summary>
  public static partial class ResetService
  {
    static readonly string __ServiceName = "com.digitalasset.ledger.api.v1.testing.ResetService";

    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest> __Marshaller_com_digitalasset_ledger_api_v1_testing_ResetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Reset = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Reset",
        __Marshaller_com_digitalasset_ledger_api_v1_testing_ResetRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ResetService</summary>
    [grpc::BindServiceMethod(typeof(ResetService), "BindService")]
    public abstract partial class ResetServiceBase
    {
      /// <summary>
      /// Resets the ledger state. Note that loaded DARs won't be removed -- this only rolls back the
      /// ledger to genesis.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Reset(global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ResetService</summary>
    public partial class ResetServiceClient : grpc::ClientBase<ResetServiceClient>
    {
      /// <summary>Creates a new client for ResetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ResetServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ResetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ResetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ResetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ResetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Resets the ledger state. Note that loaded DARs won't be removed -- this only rolls back the
      /// ledger to genesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Reset(global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Reset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Resets the ledger state. Note that loaded DARs won't be removed -- this only rolls back the
      /// ledger to genesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Reset(global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Reset, null, options, request);
      }
      /// <summary>
      /// Resets the ledger state. Note that loaded DARs won't be removed -- this only rolls back the
      /// ledger to genesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> ResetAsync(global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ResetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Resets the ledger state. Note that loaded DARs won't be removed -- this only rolls back the
      /// ledger to genesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> ResetAsync(global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Reset, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ResetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ResetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ResetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Reset, serviceImpl.Reset).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ResetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Reset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.Testing.ResetRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Reset));
    }

  }
}
#endregion