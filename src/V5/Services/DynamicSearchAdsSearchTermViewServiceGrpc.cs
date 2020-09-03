// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/dynamic_search_ads_search_term_view_service.proto
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

namespace Google.Ads.GoogleAds.V5.Services {
  /// <summary>
  /// Service to fetch dynamic search ads views.
  /// </summary>
  public static partial class DynamicSearchAdsSearchTermViewService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.DynamicSearchAdsSearchTermViewService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest> __Marshaller_google_ads_googleads_v5_services_GetDynamicSearchAdsSearchTermViewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView> __Marshaller_google_ads_googleads_v5_resources_DynamicSearchAdsSearchTermView = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest, global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView> __Method_GetDynamicSearchAdsSearchTermView = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest, global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDynamicSearchAdsSearchTermView",
        __Marshaller_google_ads_googleads_v5_services_GetDynamicSearchAdsSearchTermViewRequest,
        __Marshaller_google_ads_googleads_v5_resources_DynamicSearchAdsSearchTermView);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.DynamicSearchAdsSearchTermViewServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DynamicSearchAdsSearchTermViewService</summary>
    [grpc::BindServiceMethod(typeof(DynamicSearchAdsSearchTermViewService), "BindService")]
    public abstract partial class DynamicSearchAdsSearchTermViewServiceBase
    {
      /// <summary>
      /// Returns the requested dynamic search ads search term view in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermView(global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DynamicSearchAdsSearchTermViewService</summary>
    public partial class DynamicSearchAdsSearchTermViewServiceClient : grpc::ClientBase<DynamicSearchAdsSearchTermViewServiceClient>
    {
      /// <summary>Creates a new client for DynamicSearchAdsSearchTermViewService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DynamicSearchAdsSearchTermViewServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DynamicSearchAdsSearchTermViewService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DynamicSearchAdsSearchTermViewServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DynamicSearchAdsSearchTermViewServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DynamicSearchAdsSearchTermViewServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested dynamic search ads search term view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView GetDynamicSearchAdsSearchTermView(global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDynamicSearchAdsSearchTermView(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested dynamic search ads search term view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView GetDynamicSearchAdsSearchTermView(global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDynamicSearchAdsSearchTermView, null, options, request);
      }
      /// <summary>
      /// Returns the requested dynamic search ads search term view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDynamicSearchAdsSearchTermViewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested dynamic search ads search term view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDynamicSearchAdsSearchTermView, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DynamicSearchAdsSearchTermViewServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DynamicSearchAdsSearchTermViewServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DynamicSearchAdsSearchTermViewServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetDynamicSearchAdsSearchTermView, serviceImpl.GetDynamicSearchAdsSearchTermView).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DynamicSearchAdsSearchTermViewServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetDynamicSearchAdsSearchTermView, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetDynamicSearchAdsSearchTermViewRequest, global::Google.Ads.GoogleAds.V5.Resources.DynamicSearchAdsSearchTermView>(serviceImpl.GetDynamicSearchAdsSearchTermView));
    }

  }
}
#endregion
