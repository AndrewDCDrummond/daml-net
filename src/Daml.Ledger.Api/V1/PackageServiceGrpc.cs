// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/package_service.proto
// </auto-generated>
// Original file comments:
// Copyright (c) 2019 The DAML Authors. All rights reserved.
// SPDX-License-Identifier: Apache-2.0
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.DigitalAsset.Ledger.Api.V1 {
  /// <summary>
  /// Allows clients to query the DAML-LF packages that are supported by the server.
  /// </summary>
  public static partial class PackageService
  {
    static readonly string __ServiceName = "com.digitalasset.ledger.api.v1.PackageService";

    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest> __Marshaller_com_digitalasset_ledger_api_v1_ListPackagesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse> __Marshaller_com_digitalasset_ledger_api_v1_ListPackagesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest> __Marshaller_com_digitalasset_ledger_api_v1_GetPackageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse> __Marshaller_com_digitalasset_ledger_api_v1_GetPackageResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest> __Marshaller_com_digitalasset_ledger_api_v1_GetPackageStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse> __Marshaller_com_digitalasset_ledger_api_v1_GetPackageStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest, global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse> __Method_ListPackages = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest, global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPackages",
        __Marshaller_com_digitalasset_ledger_api_v1_ListPackagesRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_ListPackagesResponse);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest, global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse> __Method_GetPackage = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest, global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPackage",
        __Marshaller_com_digitalasset_ledger_api_v1_GetPackageRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_GetPackageResponse);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest, global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse> __Method_GetPackageStatus = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest, global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPackageStatus",
        __Marshaller_com_digitalasset_ledger_api_v1_GetPackageStatusRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_GetPackageStatusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.PackageServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PackageService</summary>
    [grpc::BindServiceMethod(typeof(PackageService), "BindService")]
    public abstract partial class PackageServiceBase
    {
      /// <summary>
      /// Returns the identifiers of all supported packages.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse> ListPackages(global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the contents of a single package, or a ``NOT_FOUND`` error if the requested package is unknown.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse> GetPackage(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the status of a single package.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse> GetPackageStatus(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PackageService</summary>
    public partial class PackageServiceClient : grpc::ClientBase<PackageServiceClient>
    {
      /// <summary>Creates a new client for PackageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PackageServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PackageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PackageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PackageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PackageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the identifiers of all supported packages.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse ListPackages(global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPackages(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the identifiers of all supported packages.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse ListPackages(global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPackages, null, options, request);
      }
      /// <summary>
      /// Returns the identifiers of all supported packages.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse> ListPackagesAsync(global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPackagesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the identifiers of all supported packages.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse> ListPackagesAsync(global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPackages, null, options, request);
      }
      /// <summary>
      /// Returns the contents of a single package, or a ``NOT_FOUND`` error if the requested package is unknown.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse GetPackage(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPackage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the contents of a single package, or a ``NOT_FOUND`` error if the requested package is unknown.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse GetPackage(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPackage, null, options, request);
      }
      /// <summary>
      /// Returns the contents of a single package, or a ``NOT_FOUND`` error if the requested package is unknown.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse> GetPackageAsync(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPackageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the contents of a single package, or a ``NOT_FOUND`` error if the requested package is unknown.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse> GetPackageAsync(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPackage, null, options, request);
      }
      /// <summary>
      /// Returns the status of a single package.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse GetPackageStatus(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPackageStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the status of a single package.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse GetPackageStatus(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPackageStatus, null, options, request);
      }
      /// <summary>
      /// Returns the status of a single package.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse> GetPackageStatusAsync(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPackageStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the status of a single package.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse> GetPackageStatusAsync(global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPackageStatus, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PackageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PackageServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PackageServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListPackages, serviceImpl.ListPackages)
          .AddMethod(__Method_GetPackage, serviceImpl.GetPackage)
          .AddMethod(__Method_GetPackageStatus, serviceImpl.GetPackageStatus).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PackageServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListPackages, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesRequest, global::Com.DigitalAsset.Ledger.Api.V1.ListPackagesResponse>(serviceImpl.ListPackages));
      serviceBinder.AddMethod(__Method_GetPackage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageRequest, global::Com.DigitalAsset.Ledger.Api.V1.GetPackageResponse>(serviceImpl.GetPackage));
      serviceBinder.AddMethod(__Method_GetPackageStatus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusRequest, global::Com.DigitalAsset.Ledger.Api.V1.GetPackageStatusResponse>(serviceImpl.GetPackageStatus));
    }

  }
}
#endregion
