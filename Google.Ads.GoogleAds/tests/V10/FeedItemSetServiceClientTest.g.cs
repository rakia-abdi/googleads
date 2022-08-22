// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V10.Services;

namespace Google.Ads.GoogleAds.Tests.V10.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedItemSetServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateFeedItemSetsRequestObject()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateFeedItemSetsResponse response = client.MutateFeedItemSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateFeedItemSetsRequestObjectAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateFeedItemSetsResponse responseCallSettings = await client.MutateFeedItemSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemSetsResponse responseCancellationToken = await client.MutateFeedItemSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateFeedItemSets()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateFeedItemSetsResponse response = client.MutateFeedItemSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateFeedItemSetsAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateFeedItemSetsResponse responseCallSettings = await client.MutateFeedItemSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemSetsResponse responseCancellationToken = await client.MutateFeedItemSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
