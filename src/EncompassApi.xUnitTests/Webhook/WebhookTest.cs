using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using EncompassApi.xUnitTests.TestServices;
using EncompassApi.xUnitTests.Extensions;
using System;
using Xunit.Abstractions;

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;

        public WebhookTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### WebhookTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;
        }

        /// <summary>
        ///  Test EncompassApi.Webhook.ResourcesAsyncTestAsync()
        /// </summary>
        [Theory]
        [JsonFileData("Payloads/WebhookResources.json", false)]
        public async Task GetResourcesAsyncTestAsync(params JObject[] payloads)
        {
            _outputWriter.WriteLine("### Starting GetResourcesAsyncTestAsync! ###");
            payloads.ShouldBeOfType<EncompassApi.Webhook.WebhookResource>();
           
            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            _mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payloads));
            }, testHeader: new System.Collections.Generic.KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString()));

            var webhookResources = await _mockedEncompassClient.MockedEncompassClient.Webhook.GetResourcesAsync();

            webhookResources.Count().Should().Be(payloads.Length);
            payloads.AreEqual(webhookResources.ToArray(), (source, target) =>
            {
                return source.Description.Equals(target.Description, StringComparison.OrdinalIgnoreCase);
            });
        }

        [Theory]
        [JsonFileData("Payloads/WebhookResources.json", false)]
        public async Task GetResourcesRawAsyncTestAsync(params JObject[] payloads)
        {
            _outputWriter.WriteLine("### Starting GetResourcesRawAsyncTestAsync! ###");
            payloads.ShouldBeOfType<EncompassApi.Webhook.WebhookResource>();

            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            _mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payloads));
            }, testHeader: new System.Collections.Generic.KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString()));

            var webhookResourcesString = await _mockedEncompassClient.MockedEncompassClient.Webhook.GetResourcesRawAsync();

            var webhookResources = webhookResourcesString.ShouldBeObjectArray<EncompassApi.Webhook.WebhookResource>("Description", "Events");
            webhookResources.Count().Should().Be(payloads.Length);
            payloads.AreEqual(webhookResources.ToArray(), (source, target) =>
            {
                return source.Description.Equals(target.Description, StringComparison.OrdinalIgnoreCase);
            });
        }
    }
}
