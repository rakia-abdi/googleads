// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/campaign_shared_set_service.proto
// Original file comments:
// Copyright 2018 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to manage campaign shared sets.
  /// </summary>
  public static partial class CampaignSharedSetService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.CampaignSharedSetService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest> __Marshaller_GetCampaignSharedSetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet> __Marshaller_CampaignSharedSet = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest> __Marshaller_MutateCampaignSharedSetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse> __Marshaller_MutateCampaignSharedSetsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest, global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet> __Method_GetCampaignSharedSet = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest, global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCampaignSharedSet",
        __Marshaller_GetCampaignSharedSetRequest,
        __Marshaller_CampaignSharedSet);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse> __Method_MutateCampaignSharedSets = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCampaignSharedSets",
        __Marshaller_MutateCampaignSharedSetsRequest,
        __Marshaller_MutateCampaignSharedSetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.CampaignSharedSetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CampaignSharedSetService</summary>
    public abstract partial class CampaignSharedSetServiceBase
    {
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet> GetCampaignSharedSet(global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse> MutateCampaignSharedSets(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CampaignSharedSetService</summary>
    public partial class CampaignSharedSetServiceClient : grpc::ClientBase<CampaignSharedSetServiceClient>
    {
      /// <summary>Creates a new client for CampaignSharedSetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CampaignSharedSetServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CampaignSharedSetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CampaignSharedSetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CampaignSharedSetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CampaignSharedSetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet GetCampaignSharedSet(global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCampaignSharedSet(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet GetCampaignSharedSet(global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCampaignSharedSet, null, options, request);
      }
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet> GetCampaignSharedSetAsync(global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCampaignSharedSetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.CampaignSharedSet> GetCampaignSharedSetAsync(global::Google.Ads.GoogleAds.V0.Services.GetCampaignSharedSetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCampaignSharedSet, null, options, request);
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse MutateCampaignSharedSets(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateCampaignSharedSets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse MutateCampaignSharedSets(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCampaignSharedSets, null, options, request);
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateCampaignSharedSetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignSharedSetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCampaignSharedSets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CampaignSharedSetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CampaignSharedSetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CampaignSharedSetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCampaignSharedSet, serviceImpl.GetCampaignSharedSet)
          .AddMethod(__Method_MutateCampaignSharedSets, serviceImpl.MutateCampaignSharedSets).Build();
    }

  }
}
#endregion
