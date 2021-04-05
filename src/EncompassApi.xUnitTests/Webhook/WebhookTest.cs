using Microsoft.Extensions.Logging;
using System;
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

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookTest
    {
        private readonly ILogger<WebhookTest> _logger;
        private readonly Mock<HttpMessageHandler> _mockedHandler;
        private readonly IHttpClientFactory _factory;
        private readonly HttpClient _mockedClient;
        private readonly EncompassApiService _mockedEncompassClient;

        public WebhookTest(ILogger<WebhookTest> logger)
        {
            _logger = logger;


            _mockedHandler = new Mock<HttpMessageHandler>();
            _factory = _mockedHandler.CreateClientFactory();
            _mockedClient = _factory.CreateClient("EncompassClient");
            _mockedClient.BaseAddress = new Uri("https://api.elliemae.com");
            _mockedEncompassClient = new EncompassApiService(_mockedClient, new ClientParameters());
        }


        /// <summary>
        ///  Test EncompassApi.Webhook.ResourcesAsyncTestAsync()
        /// </summary>
        [Theory]
        [JsonFileData("Payloads/WebhookResources.json", false)]
        public async Task GetResourcesAsyncTestAsync(params JObject[] payloads)
        {
            foreach (var item in payloads)
            {
                Assert.IsType<EncompassApi.Webhook.WebhookResource>(item.ToObject<EncompassApi.Webhook.WebhookResource>());
            }
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payloads))
                // new StringContent(@"[{ ""id"": 1, ""title"": ""Cool post!""}, { ""id"": 100, ""title"": ""Some title""}]"),

            };
            response.Headers.Add("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString());

            _mockedHandler.Protected().Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(response);

            var resps = await _mockedEncompassClient.Webhook.GetResourcesAsync();
            resps.Count().Should().Be(payloads.Length);
            for (int i = 0; i < payloads.Length; i++)
            {
                resps[i].IsEqual(payloads[i].ToObject<EncompassApi.Webhook.WebhookResource>()).Should().Be(true);
            }
        }
       
    }

    public static class MockWebhookResource
    {
        public static bool IsEqual(this EncompassApi.Webhook.WebhookResource source, EncompassApi.Webhook.WebhookResource target)
        {
            return source.Description.Equals(target.Description, StringComparison.OrdinalIgnoreCase);
        }
    }
}
