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
using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
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
    public sealed class GeneratedOfflineUserDataJobServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void CreateOfflineUserDataJobRequestObject()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
                ValidateOnly = true,
                EnableMatchRateRangePreview = false,
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateOfflineUserDataJobResponse response = client.CreateOfflineUserDataJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task CreateOfflineUserDataJobRequestObjectAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
                ValidateOnly = true,
                EnableMatchRateRangePreview = false,
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateOfflineUserDataJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateOfflineUserDataJobResponse responseCallSettings = await client.CreateOfflineUserDataJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateOfflineUserDataJobResponse responseCancellationToken = await client.CreateOfflineUserDataJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void CreateOfflineUserDataJob()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateOfflineUserDataJobResponse response = client.CreateOfflineUserDataJob(request.CustomerId, request.Job);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task CreateOfflineUserDataJobAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateOfflineUserDataJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateOfflineUserDataJobResponse responseCallSettings = await client.CreateOfflineUserDataJobAsync(request.CustomerId, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateOfflineUserDataJobResponse responseCancellationToken = await client.CreateOfflineUserDataJobAsync(request.CustomerId, request.Job, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void AddOfflineUserDataJobOperationsRequestObject()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = true,
                ValidateOnly = true,
                EnableWarnings = true,
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
                Warning = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task AddOfflineUserDataJobOperationsRequestObjectAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = true,
                ValidateOnly = true,
                EnableWarnings = true,
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
                Warning = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            AddOfflineUserDataJobOperationsResponse responseCallSettings = await client.AddOfflineUserDataJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddOfflineUserDataJobOperationsResponse responseCancellationToken = await client.AddOfflineUserDataJobOperationsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void AddOfflineUserDataJobOperations()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
                Warning = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request.ResourceName, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task AddOfflineUserDataJobOperationsAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
                Warning = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            AddOfflineUserDataJobOperationsResponse responseCallSettings = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceName, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddOfflineUserDataJobOperationsResponse responseCancellationToken = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceName, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void AddOfflineUserDataJobOperationsResourceNames()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
                Warning = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request.ResourceNameAsOfflineUserDataJobName, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task AddOfflineUserDataJobOperationsResourceNamesAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
                Warning = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null, null);
            AddOfflineUserDataJobOperationsResponse responseCallSettings = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceNameAsOfflineUserDataJobName, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddOfflineUserDataJobOperationsResponse responseCancellationToken = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceNameAsOfflineUserDataJobName, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
