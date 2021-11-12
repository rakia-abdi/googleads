// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/services/customer_feed_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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

namespace Google.Ads.GoogleAds.V9.Services {
  /// <summary>
  /// Service to manage customer feeds.
  /// </summary>
  public static partial class CustomerFeedService
  {
    static readonly string __ServiceName = "google.ads.googleads.v9.services.CustomerFeedService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest> __Marshaller_google_ads_googleads_v9_services_GetCustomerFeedRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed> __Marshaller_google_ads_googleads_v9_resources_CustomerFeed = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest> __Marshaller_google_ads_googleads_v9_services_MutateCustomerFeedsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse> __Marshaller_google_ads_googleads_v9_services_MutateCustomerFeedsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest, global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed> __Method_GetCustomerFeed = new grpc::Method<global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest, global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerFeed",
        __Marshaller_google_ads_googleads_v9_services_GetCustomerFeedRequest,
        __Marshaller_google_ads_googleads_v9_resources_CustomerFeed);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest, global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse> __Method_MutateCustomerFeeds = new grpc::Method<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest, global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomerFeeds",
        __Marshaller_google_ads_googleads_v9_services_MutateCustomerFeedsRequest,
        __Marshaller_google_ads_googleads_v9_services_MutateCustomerFeedsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V9.Services.CustomerFeedServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerFeedService</summary>
    [grpc::BindServiceMethod(typeof(CustomerFeedService), "BindService")]
    public abstract partial class CustomerFeedServiceBase
    {
      /// <summary>
      /// Returns the requested customer feed in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed> GetCustomerFeed(global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CustomerFeedError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [FunctionError]()
      ///   [FunctionParsingError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse> MutateCustomerFeeds(global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerFeedService</summary>
    public partial class CustomerFeedServiceClient : grpc::ClientBase<CustomerFeedServiceClient>
    {
      /// <summary>Creates a new client for CustomerFeedService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CustomerFeedServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerFeedService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CustomerFeedServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CustomerFeedServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CustomerFeedServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested customer feed in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed GetCustomerFeed(global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerFeed(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested customer feed in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed GetCustomerFeed(global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerFeed, null, options, request);
      }
      /// <summary>
      /// Returns the requested customer feed in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed> GetCustomerFeedAsync(global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerFeedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested customer feed in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed> GetCustomerFeedAsync(global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerFeed, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CustomerFeedError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [FunctionError]()
      ///   [FunctionParsingError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse MutateCustomerFeeds(global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerFeeds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CustomerFeedError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [FunctionError]()
      ///   [FunctionParsingError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse MutateCustomerFeeds(global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomerFeeds, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CustomerFeedError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [FunctionError]()
      ///   [FunctionParsingError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerFeedsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CustomerFeedError]()
      ///   [DatabaseError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [FunctionError]()
      ///   [FunctionParsingError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NotEmptyError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomerFeeds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CustomerFeedServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerFeedServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CustomerFeedServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerFeed, serviceImpl.GetCustomerFeed)
          .AddMethod(__Method_MutateCustomerFeeds, serviceImpl.MutateCustomerFeeds).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerFeedServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerFeed, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V9.Services.GetCustomerFeedRequest, global::Google.Ads.GoogleAds.V9.Resources.CustomerFeed>(serviceImpl.GetCustomerFeed));
      serviceBinder.AddMethod(__Method_MutateCustomerFeeds, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsRequest, global::Google.Ads.GoogleAds.V9.Services.MutateCustomerFeedsResponse>(serviceImpl.MutateCustomerFeeds));
    }

  }
}
#endregion
