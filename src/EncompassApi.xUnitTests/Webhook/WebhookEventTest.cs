using EncompassApi.xUnitTests.TestServices;
using EncompassApi.Webhook;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using EncompassApi.xUnitTests.Extensions;
using System.Net.Http;

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookEventTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;
        public WebhookEventTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### WebhookTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;

        }

        [Theory]
        [WebhookEventFile(JsonFileTypes.Array)]
        public async Task GetEventsAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var target = objs.Should().BeSerializable<JObject, WebhookEvent>(objs);
            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetEventsAsync().ConfigureAwait(false);

            source.Should()
                .HaveCount(target.Count())
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return t.Id.Equals(s.Id);
                });
        }


        [Theory]
        [WebhookEventFile(JsonFileTypes.Array)]
        public async Task GetEventsAsyncWithOptionsTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookEvent>(objs);

            var randomTarget = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            var mockedTargets = targets.Where(_ => _.Event.ResourceId == randomTarget.Event.ResourceId);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(mockedTargets));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetEventsAsync(new WebhookEventOptions()
                {
                    ResourceId = randomTarget.Event.ResourceId
                }).ConfigureAwait(false);

            source.Should()
                .HaveCount(mockedTargets.Count())
                .And
                .BeEqual(mockedTargets, source, (t, s) =>
                {
                    return t.Id.Equals(s.Id);
                });
        }


        [Theory]
        [WebhookEventFile(JsonFileTypes.Array)]
        public async Task GetEventsRawAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookEvent>(objs);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(targets));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetEventsRawAsync().ConfigureAwait(false);

            source.Should()
                .BeEqual<WebhookEvent>(targets, source, (t, s) =>
                {
                    return t.Event.ResourceId.Equals(s.Event.ResourceId);
                });
        }

        [Theory]
        [WebhookEventFile(JsonFileTypes.Array)]
        public async Task GetEventAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookEvent>(objs);
            var randomTarget = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            var mockedTargets = targets.Where(_ => _.Id == randomTarget.Id);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(mockedTargets));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetEventAsync(randomTarget.Id).ConfigureAwait(false);

            source.Should()
                .BeEqual<WebhookEvent>(mockedTargets, source, (t, s) =>
                {
                    return t.Event.ResourceId.Equals(s.Event.ResourceId);
                });
        }

        [Theory]
        [WebhookEventFile(JsonFileTypes.Array)]
        public async Task GetEventRawAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var targets = objs.Should().BeSerializable<JObject, WebhookEvent>(objs);
            var randomTarget = targets.ToArray()[Faker.RandomNumber.Next(0, targets.Count() - 1)];
            var mockedTargets = targets.Where(_ => _.Id == randomTarget.Id);

            var source = await _mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(mockedTargets));
            }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .MockedEncompassClient.Webhook.GetEventRawAsync(randomTarget.Id).ConfigureAwait(false);

            source.Should()
                .BeEqual<WebhookEvent>(mockedTargets, source, (t, s) =>
                {
                    return t.Event.ResourceId.Equals(s.Event.ResourceId);
                });
        }
    }
}
