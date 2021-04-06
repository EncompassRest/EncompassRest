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

namespace EncompassApi.xUnitTests.TestServices
{
    public class MockedEncompassHttpClientService : IMockedEncompassHttpClientService
    {
        private readonly ILogger<MockedEncompassHttpClientService> _logger;

        public Mock<HttpMessageHandler> MockedHandler { get; private set; }
        public IHttpClientFactory HttpFactory { get; private set; }
        public HttpClient MockedClient { get; private set; }
        public EncompassApiService MockedEncompassClient { get; private set; }

        public MockedEncompassHttpClientService(ILogger<MockedEncompassHttpClientService> logger)
        {
            _logger = logger;
            MockedHandler = new Mock<HttpMessageHandler>();
            HttpFactory = MockedHandler.CreateClientFactory();
            MockedClient = HttpFactory.CreateClient("EncompassClient");
            MockedClient.BaseAddress = new Uri("https://api.elliemae.com");
            MockedEncompassClient = new EncompassApiService(MockedClient, new ClientParameters());
        }

        public void SetupResponseMessage(Action<HttpResponseMessage> action, KeyValuePair<string, string>? testHeader = null)
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
        }
    }

}
