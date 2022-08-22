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
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordPlanCampaignKeywordServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateKeywordPlanCampaignKeywordsRequestObject()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateKeywordPlanCampaignKeywordsResponse response = client.MutateKeywordPlanCampaignKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateKeywordPlanCampaignKeywordsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanCampaignKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateKeywordPlanCampaignKeywordsResponse responseCallSettings = await client.MutateKeywordPlanCampaignKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanCampaignKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanCampaignKeywordsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateKeywordPlanCampaignKeywords()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateKeywordPlanCampaignKeywordsResponse response = client.MutateKeywordPlanCampaignKeywords(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateKeywordPlanCampaignKeywordsAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanCampaignKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateKeywordPlanCampaignKeywordsResponse responseCallSettings = await client.MutateKeywordPlanCampaignKeywordsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanCampaignKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanCampaignKeywordsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
