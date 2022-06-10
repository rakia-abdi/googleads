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

using gagvr = Google.Ads.GoogleAds.V11.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
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
    public sealed class GeneratedExperimentServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateExperimentsRequestObject()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateExperimentsRequest request = new MutateExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExperimentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateExperimentsResponse expectedResponse = new MutateExperimentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateExperimentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateExperiments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateExperimentsResponse response = client.MutateExperiments(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateExperimentsRequestObjectAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateExperimentsRequest request = new MutateExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExperimentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateExperimentsResponse expectedResponse = new MutateExperimentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateExperimentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateExperimentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateExperimentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateExperimentsResponse responseCallSettings = await client.MutateExperimentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateExperimentsResponse responseCancellationToken = await client.MutateExperimentsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateExperiments()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateExperimentsRequest request = new MutateExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExperimentOperation(),
                },
            };
            MutateExperimentsResponse expectedResponse = new MutateExperimentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateExperimentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateExperiments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateExperimentsResponse response = client.MutateExperiments(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateExperimentsAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateExperimentsRequest request = new MutateExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExperimentOperation(),
                },
            };
            MutateExperimentsResponse expectedResponse = new MutateExperimentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateExperimentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateExperimentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateExperimentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateExperimentsResponse responseCallSettings = await client.MutateExperimentsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateExperimentsResponse responseCancellationToken = await client.MutateExperimentsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void EndExperimentRequestObject()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndExperimentRequest request = new EndExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                ValidateOnly = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.EndExperiment(request);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task EndExperimentRequestObjectAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndExperimentRequest request = new EndExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                ValidateOnly = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.EndExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.EndExperimentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void EndExperiment()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndExperimentRequest request = new EndExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.EndExperiment(request.Experiment);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task EndExperimentAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndExperimentRequest request = new EndExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.EndExperimentAsync(request.Experiment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.EndExperimentAsync(request.Experiment, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void EndExperimentResourceNames()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndExperimentRequest request = new EndExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.EndExperiment(request.ExperimentAsExperimentName);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task EndExperimentResourceNamesAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndExperimentRequest request = new EndExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.EndExperimentAsync(request.ExperimentAsExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.EndExperimentAsync(request.ExperimentAsExperimentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void GraduateExperimentRequestObject()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateExperimentRequest request = new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                CampaignBudgetMappings =
                {
                    new CampaignBudgetMapping(),
                },
                ValidateOnly = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.GraduateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.GraduateExperiment(request);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task GraduateExperimentRequestObjectAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateExperimentRequest request = new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                CampaignBudgetMappings =
                {
                    new CampaignBudgetMapping(),
                },
                ValidateOnly = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.GraduateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.GraduateExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.GraduateExperimentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void GraduateExperiment()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateExperimentRequest request = new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                CampaignBudgetMappings =
                {
                    new CampaignBudgetMapping(),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.GraduateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.GraduateExperiment(request.Experiment, request.CampaignBudgetMappings);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task GraduateExperimentAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateExperimentRequest request = new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                CampaignBudgetMappings =
                {
                    new CampaignBudgetMapping(),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.GraduateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.GraduateExperimentAsync(request.Experiment, request.CampaignBudgetMappings, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.GraduateExperimentAsync(request.Experiment, request.CampaignBudgetMappings, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void GraduateExperimentResourceNames()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateExperimentRequest request = new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                CampaignBudgetMappings =
                {
                    new CampaignBudgetMapping(),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.GraduateExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.GraduateExperiment(request.ExperimentAsExperimentName, request.CampaignBudgetMappings);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task GraduateExperimentResourceNamesAsync()
        {
            moq::Mock<ExperimentService.ExperimentServiceClient> mockGrpcClient = new moq::Mock<ExperimentService.ExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateExperimentRequest request = new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gagvr::ExperimentName.FromCustomerTrial("[CUSTOMER_ID]", "[TRIAL_ID]"),
                CampaignBudgetMappings =
                {
                    new CampaignBudgetMapping(),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.GraduateExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExperimentServiceClient client = new ExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.GraduateExperimentAsync(request.ExperimentAsExperimentName, request.CampaignBudgetMappings, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.GraduateExperimentAsync(request.ExperimentAsExperimentName, request.CampaignBudgetMappings, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}