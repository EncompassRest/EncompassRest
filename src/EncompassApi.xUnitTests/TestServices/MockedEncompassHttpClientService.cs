using Microsoft.Extensions.Logging;
using EncompassApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Net.Http;
using Moq.Contrib.HttpClient;
using Moq.Protected;
using System.Threading;
using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;
using EncompassApi.Configuration;
using EncompassApi.Extensions;

namespace EncompassApi.xUnitTests.TestServices
{
    public class MockedEncompassHttpClientService : IMockedEncompassHttpClientService
    {
        private readonly ILogger<MockedEncompassHttpClientService> _logger;

        public Mock<HttpMessageHandler> MockedHandler { get; private set; }
        public IHttpClientFactory HttpFactory { get; private set; }
        public HttpClient MockedClient { get; private set; }
        public EncompassApiService MockedEncompassClient { get; private set; }

        public Uri BaseAddress { get; private set; }
        public Mock<IHttpClientOptions> Options { get; private set; }

        public IMockedEncompassHttpClientService SetOptions(Action<Mock<IHttpClientOptions>> options)
        {
            Options = new Mock<IHttpClientOptions>();
            Options.SetupProperty(m => m.CompressionOptions);
            options(Options);
            return this;
        }

        public IMockedEncompassHttpClientService SetOptions(Mock<IHttpClientOptions> options)
        {
            Options = options;
            return this;
        }

        public IMockedEncompassHttpClientService AddDefaultRequestHeaders()
        {
            MockedClient.AddDefaultRequestHeaders(Options.Object);
            return this;
        }

        public MockedEncompassHttpClientService(ILogger<MockedEncompassHttpClientService> logger)
        {
            _logger = logger;
            MockedHandler = new Mock<HttpMessageHandler>();
            HttpFactory = MockedHandler.CreateClientFactory();
            MockedClient = HttpFactory.CreateClient("EncompassClient");
            BaseAddress = new Uri(Faker.Internet.Url());
            MockedClient.BaseAddress = BaseAddress;
            MockedEncompassClient = new EncompassApiService(MockedClient, new ClientParameters());
        }

        private void _mockedEncompassClient_ApiResponse(object sender, ApiResponseEventArgs e)
        {
            if (MockedEncompassClient_ApiResponse != null)
                MockedEncompassClient_ApiResponse(sender, e);
        }

        

        public IMockedEncompassHttpClientService SetupResponseMessage(Action<HttpResponseMessage> action, KeyValuePair<string, string>? testHeader = null)
        {
            var respMsg = new HttpResponseMessage();
            action(respMsg);

            if (testHeader.HasValue)
                respMsg.Headers.Add(testHeader.Value.Key, testHeader.Value.Value);

            MockedHandler.Protected().Setup<Task<HttpResponseMessage>>(
            "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(respMsg);
            return this;
        }

        public EncompassApi.Webhook.Webhook SetWebhookApiResponseCallback(EventHandler<ApiResponseEventArgs> action)
        {
            MockedEncompassClient.Webhook.ApiResponseEventHandler += action;
            return MockedEncompassClient.Webhook;
        } 


        public event EventHandler<ApiResponseEventArgs> MockedEncompassClient_ApiResponse;
       
    }

}
