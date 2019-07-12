// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/admin/package_management_service.proto
// </auto-generated>
// Original file comments:
// Copyright (c) 2019 Digital Asset (Switzerland) GmbH and/or its affiliates. All rights reserved.
// SPDX-License-Identifier: Apache-2.0
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.DigitalAsset.Ledger.Api.V1.Admin {
  /// <summary>
  /// Query the DAML-LF packages supported by the ledger participant and upload
  /// DAR files. We use 'backing participant' to refer to this specific participant
  /// in the methods of this API.
  /// When the participant is run in mode requiring authentication, all the calls 
  /// in this interface will respond with UNAUTHENTICATED, if the caller fails
  /// to provide a valid access token, and will respond with PERMISSION_DENIED, if
  /// the claims in the token are insufficient to perform a given operation.
  /// Subsequently, only specific errors of individual calls not related to 
  /// authorization will be described.
  /// </summary>
  public static partial class PackageManagementService
  {
    static readonly string __ServiceName = "com.digitalasset.ledger.api.v1.admin.PackageManagementService";

    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest> __Marshaller_com_digitalasset_ledger_api_v1_admin_ListKnownPackagesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse> __Marshaller_com_digitalasset_ledger_api_v1_admin_ListKnownPackagesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest> __Marshaller_com_digitalasset_ledger_api_v1_admin_UploadDarFileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse> __Marshaller_com_digitalasset_ledger_api_v1_admin_UploadDarFileResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse> __Method_ListKnownPackages = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListKnownPackages",
        __Marshaller_com_digitalasset_ledger_api_v1_admin_ListKnownPackagesRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_admin_ListKnownPackagesResponse);

    static readonly grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse> __Method_UploadDarFile = new grpc::Method<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UploadDarFile",
        __Marshaller_com_digitalasset_ledger_api_v1_admin_UploadDarFileRequest,
        __Marshaller_com_digitalasset_ledger_api_v1_admin_UploadDarFileResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Admin.PackageManagementServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PackageManagementService</summary>
    [grpc::BindServiceMethod(typeof(PackageManagementService), "BindService")]
    public abstract partial class PackageManagementServiceBase
    {
      /// <summary>
      /// Returns the details of all DAML-LF packages known to the backing
      /// participant.
      /// This request will always succeed.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse> ListKnownPackages(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Upload a DAR file to the backing participant.
      /// Depending on the ledger implementation this might also make the package 
      /// available on the whole ledger. This call might not be supported by some 
      /// ledger implementations. Canton could be an example, where uploading a DAR
      /// is not sufficient to render it usable, it must be activated first.
      /// This call may:
      /// - Succeed, if the package was successfully uploaded, or if the same package
      ///   was already uploaded before. 
      /// - Respond with UNIMPLEMENTED, if DAR package uploading is not supported by
      ///   the backing participant.
      /// - Respond with INVALID_ARGUMENT, if the DAR file is too big or malformed.
      /// The maximum supported size is implementation specific.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse> UploadDarFile(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PackageManagementService</summary>
    public partial class PackageManagementServiceClient : grpc::ClientBase<PackageManagementServiceClient>
    {
      /// <summary>Creates a new client for PackageManagementService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PackageManagementServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PackageManagementService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PackageManagementServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PackageManagementServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PackageManagementServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the details of all DAML-LF packages known to the backing
      /// participant.
      /// This request will always succeed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse ListKnownPackages(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListKnownPackages(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the details of all DAML-LF packages known to the backing
      /// participant.
      /// This request will always succeed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse ListKnownPackages(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListKnownPackages, null, options, request);
      }
      /// <summary>
      /// Returns the details of all DAML-LF packages known to the backing
      /// participant.
      /// This request will always succeed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse> ListKnownPackagesAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListKnownPackagesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the details of all DAML-LF packages known to the backing
      /// participant.
      /// This request will always succeed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse> ListKnownPackagesAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListKnownPackages, null, options, request);
      }
      /// <summary>
      /// Upload a DAR file to the backing participant.
      /// Depending on the ledger implementation this might also make the package 
      /// available on the whole ledger. This call might not be supported by some 
      /// ledger implementations. Canton could be an example, where uploading a DAR
      /// is not sufficient to render it usable, it must be activated first.
      /// This call may:
      /// - Succeed, if the package was successfully uploaded, or if the same package
      ///   was already uploaded before. 
      /// - Respond with UNIMPLEMENTED, if DAR package uploading is not supported by
      ///   the backing participant.
      /// - Respond with INVALID_ARGUMENT, if the DAR file is too big or malformed.
      /// The maximum supported size is implementation specific.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse UploadDarFile(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadDarFile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Upload a DAR file to the backing participant.
      /// Depending on the ledger implementation this might also make the package 
      /// available on the whole ledger. This call might not be supported by some 
      /// ledger implementations. Canton could be an example, where uploading a DAR
      /// is not sufficient to render it usable, it must be activated first.
      /// This call may:
      /// - Succeed, if the package was successfully uploaded, or if the same package
      ///   was already uploaded before. 
      /// - Respond with UNIMPLEMENTED, if DAR package uploading is not supported by
      ///   the backing participant.
      /// - Respond with INVALID_ARGUMENT, if the DAR file is too big or malformed.
      /// The maximum supported size is implementation specific.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse UploadDarFile(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UploadDarFile, null, options, request);
      }
      /// <summary>
      /// Upload a DAR file to the backing participant.
      /// Depending on the ledger implementation this might also make the package 
      /// available on the whole ledger. This call might not be supported by some 
      /// ledger implementations. Canton could be an example, where uploading a DAR
      /// is not sufficient to render it usable, it must be activated first.
      /// This call may:
      /// - Succeed, if the package was successfully uploaded, or if the same package
      ///   was already uploaded before. 
      /// - Respond with UNIMPLEMENTED, if DAR package uploading is not supported by
      ///   the backing participant.
      /// - Respond with INVALID_ARGUMENT, if the DAR file is too big or malformed.
      /// The maximum supported size is implementation specific.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse> UploadDarFileAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadDarFileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Upload a DAR file to the backing participant.
      /// Depending on the ledger implementation this might also make the package 
      /// available on the whole ledger. This call might not be supported by some 
      /// ledger implementations. Canton could be an example, where uploading a DAR
      /// is not sufficient to render it usable, it must be activated first.
      /// This call may:
      /// - Succeed, if the package was successfully uploaded, or if the same package
      ///   was already uploaded before. 
      /// - Respond with UNIMPLEMENTED, if DAR package uploading is not supported by
      ///   the backing participant.
      /// - Respond with INVALID_ARGUMENT, if the DAR file is too big or malformed.
      /// The maximum supported size is implementation specific.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse> UploadDarFileAsync(global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UploadDarFile, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PackageManagementServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PackageManagementServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PackageManagementServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListKnownPackages, serviceImpl.ListKnownPackages)
          .AddMethod(__Method_UploadDarFile, serviceImpl.UploadDarFile).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PackageManagementServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListKnownPackages, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.ListKnownPackagesResponse>(serviceImpl.ListKnownPackages));
      serviceBinder.AddMethod(__Method_UploadDarFile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileRequest, global::Com.DigitalAsset.Ledger.Api.V1.Admin.UploadDarFileResponse>(serviceImpl.UploadDarFile));
    }

  }
}
#endregion