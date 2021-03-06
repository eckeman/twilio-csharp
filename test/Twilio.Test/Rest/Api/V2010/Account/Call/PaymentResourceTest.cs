/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Api.V2010.Account.Call;

namespace Twilio.Tests.Rest.Api.V2010.Account.Call
{

    [TestFixture]
    public class PaymentTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Calls/CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Payments.json",
                ""
            );
            request.AddPostParam("IdempotencyKey", Serialize("idempotency_key"));
            request.AddPostParam("StatusCallback", Serialize(new Uri("https://example.com")));
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PaymentResource.Create("CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "idempotency_key", new Uri("https://example.com"), client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestStartPaymentSessionSuccessResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"date_updated\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"sid\": \"PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Payments/PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"
                                     ));

            var response = PaymentResource.Create("CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "idempotency_key", new Uri("https://example.com"), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Calls/CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Payments/PKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            request.AddPostParam("IdempotencyKey", Serialize("idempotency_key"));
            request.AddPostParam("StatusCallback", Serialize(new Uri("https://example.com")));
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PaymentResource.Update("CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "idempotency_key", new Uri("https://example.com"), client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCollectCreditCardNumberResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"date_updated\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"sid\": \"PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Payments/PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"
                                     ));

            var response = PaymentResource.Update("CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "idempotency_key", new Uri("https://example.com"), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCollectCreditCardExpiryDateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"date_updated\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"sid\": \"PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Payments/PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"
                                     ));

            var response = PaymentResource.Update("CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "idempotency_key", new Uri("https://example.com"), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCompletePaymentResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"date_updated\": \"Wed, 18 Dec 2019 20:02:01 +0000\",\"sid\": \"PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Payments/PKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"
                                     ));

            var response = PaymentResource.Update("CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "idempotency_key", new Uri("https://example.com"), client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}