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
using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V10.Services;

namespace Google.Ads.GoogleAds.Tests.V10.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCustomerRequestObject()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerOperation(),
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse
            {
                Result = new MutateCustomerResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerResponse response = client.MutateCustomer(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCustomerRequestObjectAsync()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerOperation(),
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse
            {
                Result = new MutateCustomerResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerResponse responseCallSettings = await client.MutateCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerResponse responseCancellationToken = await client.MutateCustomerAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateCustomer()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerOperation(),
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse
            {
                Result = new MutateCustomerResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerResponse response = client.MutateCustomer(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCustomerAsync()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerOperation(),
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse
            {
                Result = new MutateCustomerResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerResponse responseCallSettings = await client.MutateCustomerAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerResponse responseCancellationToken = await client.MutateCustomerAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void ListAccessibleCustomersRequestObject()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            ListAccessibleCustomersRequest request = new ListAccessibleCustomersRequest { };
            ListAccessibleCustomersResponse expectedResponse = new ListAccessibleCustomersResponse
            {
                ResourceNames =
                {
                    "resource_namese9b75273",
                },
            };
            mockGrpcClient.Setup(x => x.ListAccessibleCustomers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            ListAccessibleCustomersResponse response = client.ListAccessibleCustomers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task ListAccessibleCustomersRequestObjectAsync()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            ListAccessibleCustomersRequest request = new ListAccessibleCustomersRequest { };
            ListAccessibleCustomersResponse expectedResponse = new ListAccessibleCustomersResponse
            {
                ResourceNames =
                {
                    "resource_namese9b75273",
                },
            };
            mockGrpcClient.Setup(x => x.ListAccessibleCustomersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListAccessibleCustomersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            ListAccessibleCustomersResponse responseCallSettings = await client.ListAccessibleCustomersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListAccessibleCustomersResponse responseCancellationToken = await client.ListAccessibleCustomersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void CreateCustomerClientRequestObject()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "customer_id3b3724cb",
                CustomerClient = new gagvr::Customer(),
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                ValidateOnly = true,
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceNameAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                InvitationLink = "invitation_linkd5742ce9",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateCustomerClientResponse response = client.CreateCustomerClient(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task CreateCustomerClientRequestObjectAsync()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "customer_id3b3724cb",
                CustomerClient = new gagvr::Customer(),
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                ValidateOnly = true,
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceNameAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                InvitationLink = "invitation_linkd5742ce9",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateCustomerClientResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateCustomerClientResponse responseCallSettings = await client.CreateCustomerClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateCustomerClientResponse responseCancellationToken = await client.CreateCustomerClientAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void CreateCustomerClient()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "customer_id3b3724cb",
                CustomerClient = new gagvr::Customer(),
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceNameAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                InvitationLink = "invitation_linkd5742ce9",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateCustomerClientResponse response = client.CreateCustomerClient(request.CustomerId, request.CustomerClient);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task CreateCustomerClientAsync()
        {
            moq::Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new moq::Mock<CustomerService.CustomerServiceClient>(moq::MockBehavior.Strict);
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "customer_id3b3724cb",
                CustomerClient = new gagvr::Customer(),
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceNameAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                InvitationLink = "invitation_linkd5742ce9",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateCustomerClientResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null, null);
            CreateCustomerClientResponse responseCallSettings = await client.CreateCustomerClientAsync(request.CustomerId, request.CustomerClient, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateCustomerClientResponse responseCancellationToken = await client.CreateCustomerClientAsync(request.CustomerId, request.CustomerClient, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
