using EncompassApi.xUnitTests.Extensions;
using EncompassApi.xUnitTests.TestServices;
using EncompassApi.Webhook;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using System.Net.Http;
using FluentAssertions.Json;
using System.Net;
using System.Net.Http.Headers;

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookSubscriptionsTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;
        public WebhookSubscriptionsTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### WebhookTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;
            
        }


        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task GetSubscriptionsAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var target = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetSubscriptionsAsync().ConfigureAwait(false);

            source.Should()
                .BeOfType<List<EncompassApi.Webhook.WebhookSubscription>>()
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return t.Endpoint.Equals(s.Endpoint) && t.InstanceId.Equals(s.InstanceId);
                });

        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array, args: new string[] { "Loan" }, "move")]

        public async Task GetSubscriptionsAsyncBtResourceTypeStringTestAsync(string methodName, string resourceType, string[] resourceEvents, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var initalTarget = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            var target = initalTarget.Where(_ => _.Events.Any(e => resourceEvents.Any(r => e.Value == r)));
            target.Should().HaveCountGreaterThan(0);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .SetWebhookApiResponseCallback((o, resp) =>
              {
                  resp.Response.Should().NotBeNull();
                  resp.Response.Headers.Should().Contain(k => k.Key.Equals("TestHeader"));
              }).GetSubscriptionsAsync(new string[] { resourceType }, resourceEvents).ConfigureAwait(false);

            source.Should()
                 .BeOfType<List<WebhookSubscription>>()
                 .And
                 .BeEqual(target, source, (t, s) =>
                 {
                     return t.Resource.Value.Equals(s.Resource.Value);
                 }, because: "resource values are not the same")
                 .And.BeEqual(target, source, (t, s) =>
                 {
                     return t.Events.SequenceEqual(s.Events);
                 }, because: "events are not the same");
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array, args: new string[] { "Loan" }, "move")]

        public async Task GetSubscriptionsAsyncBtResourceTypeEnumTestAsync(string methodName, string resourceType, string[] resourceEvents, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var initalTarget = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            var target = initalTarget.Where(_ => _.Events.Any(e => resourceEvents.Any(r => e.Value == r)));
            target.Should().HaveCountGreaterThan(0);

            Enum.TryParse<WebhookResourceType>(resourceType, true, out WebhookResourceType resourceTypeEnum).Should().BeTrue(because: "input resource type {0} is not valid", resourceType);
            var resourceEventEnums = resourceEvents.Select(_ =>
            {
                Enum.TryParse<WebhookResourceEvent>(_, true, out WebhookResourceEvent webhookResourceEvent).Should().BeTrue(because: "input resource event {0} is not valid", _);
                return webhookResourceEvent;
            });
            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetSubscriptionsAsync(new WebhookResourceType[] { resourceTypeEnum }, resourceEventEnums).ConfigureAwait(false);

            source.Should()
                 .BeOfType<List<WebhookSubscription>>()
                 .And
                 .BeEqual(target, source, (t, s) =>
                 {
                     return t.Resource.Value.Equals(s.Resource.Value);
                 }, because: "resource values are not the same")
                 .And
                 .BeEqual(target, source, (t, s) =>
                 {
                     return t.Events.SequenceEqual(s.Events);
                 }, because: "events are not the same");

        }


        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task GetSubscriptionsRawAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var target = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetSubscriptionsRawAsync().ConfigureAwait(false);

            source.Should()
                .BeValidJson(because: "source is not a valid json")
                .And
                .BeOfObjectArray<EncompassApi.Webhook.WebhookSubscription>(source, new string[] { nameof(WebhookSubscription.Endpoint) }, because: "source is not of type {0}", typeof(WebhookSubscription).Name)
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return t.Endpoint.Equals(s.Endpoint) && t.InstanceId.Equals(s.InstanceId);
                });
        }

        [Theory]
        [WebhookSubscriptionByIdFile(JsonFileTypes.Array, resourceTypes: new string[] { "Loan" }, "378ea7a2-428d-4e96-bb0b-0c8907f6af80")]
        public async Task GetSubscriptionAsyncTestAsync(string methodName, string resourceType, string subscriptionId, JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var initalTarget = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            var target = initalTarget.FirstOrDefault(_ => _.SubscriptionId.Equals(subscriptionId));
            target.Should().NotBeNull(because: "there is no subscription with the id : {0}", subscriptionId);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetSubscriptionAsync(subscriptionId).ConfigureAwait(false);

            source.Should()
                .BeOfObject<EncompassApi.Webhook.WebhookSubscription>(source, nameof(EncompassApi.Webhook.WebhookSubscription.Endpoint))
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return t.SubscriptionId.Equals(s.SubscriptionId);
                });
        }

        [Theory]
        [WebhookSubscriptionByIdFile(JsonFileTypes.Array, resourceTypes: new string[] { "Loan" }, "378ea7a2-428d-4e96-bb0b-0c8907f6af80")]

        public async Task GetSubscriptionRawAsyncTestAsync(string methodName, string resourceType, string subscriptionId, JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var initalTarget = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            var target = initalTarget.FirstOrDefault(_ => _.SubscriptionId.Equals(subscriptionId));
            target.Should().NotBeNull(because: "there is no subscription with the id : {0}", subscriptionId);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetSubscriptionRawAsync(subscriptionId).ConfigureAwait(false);


            source.Should()
                .BeOfObject<WebhookSubscription>(source, nameof(WebhookSubscription.Endpoint))
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    Enum.TryParse<WebhookResourceType>(resourceType, out WebhookResourceType resource).Should().BeTrue("resource type input is not of type WebhookResourceType");
                    return s.SubscriptionId.Equals(t.SubscriptionId) && s.Resource.Equals(resource);
                });
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task CreateSubscriptionAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            targets.Should().HaveCountGreaterThan(0, because: "targets array does not have any items");
            var mockedTarget = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            mockedTarget.Should().NotBeNull(because: "test is not able to find a random subscription from target array");
            var mockedSubscriptionId = mockedTarget.SubscriptionId;
            mockedTarget.SubscriptionId = null;
            var mockedUri = new Uri(Faker.Internet.SecureUrl());
            var mockedUriBuilder = new UriBuilder("Https", mockedUri.Host);
            mockedUriBuilder.Path = mockedSubscriptionId;


            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(mockedSubscriptionId);
                resp.Headers.Location = mockedUriBuilder.Uri;
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.CreateSubscriptionAsync(mockedTarget).ConfigureAwait(false);

            Guid.TryParse(source, out Guid outputId)
                .Should().BeTrue(because: "retruned Subscription id is not of type Guid");
            source.Should()
                .BeEqual<string>(mockedSubscriptionId, source, (i, s) =>
                {
                    return i.Equals(s);
                });
        }


        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task CreateSubscriptionRawAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            targets.Should().HaveCountGreaterThan(0, because: "targets array does not have any items");
            var mockedTarget = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            mockedTarget.Should().NotBeNull(because: "test is not able to find a random subscription from target array");
            var mockedSubscriptionId = mockedTarget.SubscriptionId;
            mockedTarget.SubscriptionId = null;
            var mockedUri = new Uri(Faker.Internet.SecureUrl());
            var mockedUriBuilder = new UriBuilder("Https", mockedUri.Host);
            mockedUriBuilder.Path = mockedSubscriptionId;


            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(mockedSubscriptionId);
                resp.Headers.Location = mockedUriBuilder.Uri;
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.CreateSubscriptionRawAsync(Newtonsoft.Json.JsonConvert.SerializeObject(mockedTarget)).ConfigureAwait(false);

            Guid.TryParse(source, out Guid outputId)
                .Should().BeTrue(because: "retruned Subscription id is not of type Guid");
            source.Should()
                .BeEqual<string>(mockedSubscriptionId, source, (i, s) =>
                {
                    return i.Equals(s);
                });
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task UpdateSubscriptionAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            targets.Should().HaveCountGreaterThan(0, because: "targets array does not have any items");
            var mockedTarget = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            // MAKE SOME CHANGES TO MOCKED TARGET
            var inputTargetEndpoint = mockedTarget.Endpoint;
            mockedTarget.Endpoint = Faker.Internet.Url();

            mockedTarget.Should().NotBeNull(because: "test is not able to find a random subscription from target array");
            var mockedUri = new Uri(Faker.Internet.SecureUrl());
            var mockedUriBuilder = new UriBuilder("Https", mockedUri.Host);
            mockedUriBuilder.Path = mockedTarget.SubscriptionId;

            await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(mockedTarget.SubscriptionId);
                resp.Headers.Location = mockedUriBuilder.Uri;
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
               .SetWebhookApiResponseCallback((e, a) =>
               {
                   _ = a.Response.Headers.Should().Contain(k => k.Key.Equals("TestHeader"));
                   _ = a.Response.Content.ReadAsStringAsync().Result.Should().Be(mockedTarget.SubscriptionId);
               })
               .UpdateSubscriptionAsync(mockedTarget).ConfigureAwait(false);

            // NOT CLEAR AS WHAT TO TEST AT THE TIME OF WRITING THIS UNIT TEST
            // ADD TEST
            // ....
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task UpdateSubscriptionRawAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            targets.Should().HaveCountGreaterThan(0, because: "targets array does not have any items");
            var target = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            var mockedTarget = target.ShallowCopy();
            // MAKE SOME CHANGES TO MOCKED TARGET
            mockedTarget.Endpoint = Faker.Internet.Url();

            mockedTarget.Should().NotBeNull(because: "test is not able to find a random subscription from target array");
            var mockedUri = new Uri(Faker.Internet.SecureUrl());
            var mockedUriBuilder = new UriBuilder("Https", mockedUri.Host);
            mockedUriBuilder.Path = target.SubscriptionId;

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(target.SubscriptionId);
                resp.Headers.Location = mockedUriBuilder.Uri;
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .SetWebhookApiResponseCallback((e, a) =>
                {
                    a.Response.Headers.Should().Contain(k => k.Key.Equals("TestHeader"));
                })
                .UpdateSubscriptionRawAsync(target.SubscriptionId, Newtonsoft.Json.JsonConvert.SerializeObject(mockedTarget)).ConfigureAwait(false);

            Guid.TryParse(source, out Guid result).Should().BeTrue(because: "source is not a guid");
            source.Should()
                .BeEqual<WebhookSubscription, string>(target, source, (t, s) =>
                {
                    return t.SubscriptionId.Equals(s);
                });

            // NOT CLEAR AS WHAT TO TEST AT THE TIME OF WRITING THIS UNIT TEST
            // ADD TEST
            // ....
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task TryDeleteSubscriptionAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            targets.Should().HaveCountGreaterThan(0, because: "targets array does not have any items");
            var target = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(target.SubscriptionId);
                
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .SetWebhookApiResponseCallback((e, a) =>
                {
                    a.Response.Headers.Should().Contain(k => k.Key.Equals("TestHeader"));
                    // FIND OUT WHAT THE ACTUAL DELETE CALL SENDS BACK AS RESPONSE AND USE IT HEARE
                    a.Response.Content.ReadAsStringAsync().Result.Should().Be(target.SubscriptionId);
                })
                .TryDeleteSubscriptionAsync(target.SubscriptionId).ConfigureAwait(false);

            source.Should().BeTrue();
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public async Task DeleteSubscriptionAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookSubscription>(objs);
            targets.Should().HaveCountGreaterThan(0, because: "targets array does not have any items");
            var target = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];

            await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(target.SubscriptionId);
            }, new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .SetWebhookApiResponseCallback((e, a) =>
                {
                    a.Response.Headers.Should().Contain(k => k.Key.Equals("TestHeader"));
                    // FIND OUT WHAT THE ACTUAL DELETE CALL SENDS BACK AS RESPONSE AND USE IT HEARE
                    a.Response.Content.ReadAsStringAsync().Result.Should().Be(target.SubscriptionId);
                })
                .DeleteSubscriptionAsync(target.SubscriptionId).ConfigureAwait(false);
            
        }

    }
    
}
