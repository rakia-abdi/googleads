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
using gagve = Google.Ads.GoogleAds.V10.Enums;
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
    public sealed class GeneratedAdGroupServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateAdGroupsRequestObject()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupsResponse response = client.MutateAdGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAdGroupsRequestObjectAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupsResponse responseCallSettings = await client.MutateAdGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupsResponse responseCancellationToken = await client.MutateAdGroupsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateAdGroups()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupsResponse response = client.MutateAdGroups(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAdGroupsAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupsResponse responseCallSettings = await client.MutateAdGroupsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupsResponse responseCancellationToken = await client.MutateAdGroupsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
