using EncompassApi.xUnitTests.TestServices;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using EncompassApi.xUnitTests.Extensions;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using EncompassApi.Webhook;

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookResourceEventTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;
        public WebhookResourceEventTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### WebhookTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;
        }

        [Theory]
        [WebhookResourceEventFile(JsonFileTypes.Array, "Loan", "Transaction", "TaskGroup")]
        public async Task GetResourceEventsByEnumAsyncTestAsync(string methodName, string resourceType, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! with resourcetype {1} ###", methodName, resourceType);
            Enum.TryParse<EncompassApi.Webhook.WebhookResourceType>(resourceType, out WebhookResourceType resourceTypeEnum).Should().Be(true);
            var target = objs.Should().BeSerializable<JObject, WebhookResourceEventObject>(objs);
            var source = await (_mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceEventsAsync(resourceTypeEnum).ConfigureAwait(false);


            source.Should()
                .AllBeOfType<WebhookResourceEventObject>()
                .And
                .HaveCount(target.Count())
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Name.Value.Equals(t.Name.Value, StringComparison.OrdinalIgnoreCase);
                });
        }

        [Theory]
        [WebhookResourceEventFile(JsonFileTypes.Array, "Loan", "Transaction", "TaskGroup")]
        public async Task GetResourceEventsByStringAsyncTestAsync(string methodName, string resourceType, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! with resourcetype {1} ###", methodName, resourceType);
            var target = objs.Should().BeSerializable<JObject, EncompassApi.Webhook.WebhookResourceEventObject>(objs);
            var source = await (_mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceEventsAsync(resourceType).ConfigureAwait(false);


            source.Should()
                .AllBeOfType<WebhookResourceEventObject>()
                .And
                .HaveCount(target.Count())
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Name.Value.Equals(t.Name.Value, StringComparison.OrdinalIgnoreCase);
                });
        }

        [Theory]
        [WebhookResourceEventFile(JsonFileTypes.Array, "Loan", "Transaction", "TaskGroup")]
        public async Task GetResourceEventsRawAsyncTestAsync(string methodName, string resourceType, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! with resourcetype {1} ###", methodName, resourceType);
            var target = objs.Should().BeSerializable<JObject, EncompassApi.Webhook.WebhookResourceEventObject>(objs);
            var source = await (_mockedEncompassClient.SetupResponseMessage(resp =>
            {
                resp.StatusCode = System.Net.HttpStatusCode.OK;
                resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceEventsRawAsync(resourceType).ConfigureAwait(false);


            source.Should()
                .BeOfObjectArray<WebhookResourceEventObject>(source, nameof(WebhookResourceEventObject.Name))
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Name.Value.Equals(t.Name.Value, StringComparison.OrdinalIgnoreCase);
                });
        }
    }
}
