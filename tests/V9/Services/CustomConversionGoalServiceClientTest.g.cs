// Copyright 2021 Google LLC
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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomConversionGoalServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCustomConversionGoalsRequestObject()
        {
            moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomConversionGoalsRequest request = new MutateCustomConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomConversionGoalOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomConversionGoalsResponse expectedResponse = new MutateCustomConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomConversionGoals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomConversionGoalServiceClient client = new CustomConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomConversionGoalsResponse response = client.MutateCustomConversionGoals(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomConversionGoalsRequestObjectAsync()
        {
            moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomConversionGoalsRequest request = new MutateCustomConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomConversionGoalOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomConversionGoalsResponse expectedResponse = new MutateCustomConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomConversionGoalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomConversionGoalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomConversionGoalServiceClient client = new CustomConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomConversionGoalsResponse responseCallSettings = await client.MutateCustomConversionGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomConversionGoalsResponse responseCancellationToken = await client.MutateCustomConversionGoalsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomConversionGoals()
        {
            moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomConversionGoalsRequest request = new MutateCustomConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomConversionGoalOperation(),
                },
            };
            MutateCustomConversionGoalsResponse expectedResponse = new MutateCustomConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomConversionGoals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomConversionGoalServiceClient client = new CustomConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomConversionGoalsResponse response = client.MutateCustomConversionGoals(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomConversionGoalsAsync()
        {
            moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomConversionGoalService.CustomConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomConversionGoalsRequest request = new MutateCustomConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomConversionGoalOperation(),
                },
            };
            MutateCustomConversionGoalsResponse expectedResponse = new MutateCustomConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomConversionGoalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomConversionGoalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomConversionGoalServiceClient client = new CustomConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomConversionGoalsResponse responseCallSettings = await client.MutateCustomConversionGoalsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomConversionGoalsResponse responseCancellationToken = await client.MutateCustomConversionGoalsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
