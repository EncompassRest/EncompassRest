using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Moq;
using System.Net.Http;
using Moq.Contrib.HttpClient;
using System.Net;
using Moq.Protected;
using System.Threading;
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
        private readonly ITestOutputHelper _logger;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;

        public WebhookTest(ITestOutputHelper logger, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            logger.WriteLine("### WebhookTest initiating! ###");
            _logger = logger;
            _mockedEncompassClient = mockedEncompassHttpClient;
        }

        /// <summary>
        ///  Test EncompassApi.Webhook.ResourcesAsyncTestAsync()
        /// </summary>
        [Theory]
        [JsonFileData("Payloads/WebhookResources.json", false)]
        public async Task GetResourcesAsyncTestAsync(params JObject[] payloads)
        {
            _logger.WriteLine("### Starting GetResourcesAsyncTestAsync! ###");
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
            _logger.WriteLine("### Starting GetResourcesRawAsyncTestAsync! ###");
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
