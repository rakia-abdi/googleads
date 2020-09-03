// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to manage ads.
  /// </summary>
  public static partial class AdService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.AdService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetAdRequest> __Marshaller_google_ads_googleads_v3_services_GetAdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetAdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.Ad> __Marshaller_google_ads_googleads_v3_resources_Ad = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.Ad.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest> __Marshaller_google_ads_googleads_v3_services_MutateAdsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse> __Marshaller_google_ads_googleads_v3_services_MutateAdsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdRequest, global::Google.Ads.GoogleAds.V3.Resources.Ad> __Method_GetAd = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdRequest, global::Google.Ads.GoogleAds.V3.Resources.Ad>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAd",
        __Marshaller_google_ads_googleads_v3_services_GetAdRequest,
        __Marshaller_google_ads_googleads_v3_resources_Ad);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse> __Method_MutateAds = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAds",
        __Marshaller_google_ads_googleads_v3_services_MutateAdsRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateAdsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdService</summary>
    [grpc::BindServiceMethod(typeof(AdService), "BindService")]
    public abstract partial class AdServiceBase
    {
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.Ad> GetAd(global::Google.Ads.GoogleAds.V3.Services.GetAdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates ads. Operation statuses are returned. Updating ads is not supported
      /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse> MutateAds(global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdService</summary>
    public partial class AdServiceClient : grpc::ClientBase<AdServiceClient>
    {
      /// <summary>Creates a new client for AdService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.Ad GetAd(global::Google.Ads.GoogleAds.V3.Services.GetAdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAd(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.Ad GetAd(global::Google.Ads.GoogleAds.V3.Services.GetAdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAd, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.Ad> GetAdAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.Ad> GetAdAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAd, null, options, request);
      }
      /// <summary>
      /// Updates ads. Operation statuses are returned. Updating ads is not supported
      /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse MutateAds(global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates ads. Operation statuses are returned. Updating ads is not supported
      /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse MutateAds(global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAds, null, options, request);
      }
      /// <summary>
      /// Updates ads. Operation statuses are returned. Updating ads is not supported
      /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse> MutateAdsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates ads. Operation statuses are returned. Updating ads is not supported
      /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse> MutateAdsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAd, serviceImpl.GetAd)
          .AddMethod(__Method_MutateAds, serviceImpl.MutateAds).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAd, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.GetAdRequest, global::Google.Ads.GoogleAds.V3.Resources.Ad>(serviceImpl.GetAd));
      serviceBinder.AddMethod(__Method_MutateAds, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.MutateAdsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdsResponse>(serviceImpl.MutateAds));
    }

  }
}
#endregion
