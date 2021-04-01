using System;
using Xunit;
using EncompassApi;
using Moq;
using System.Net.Http;
using Moq.Contrib.HttpClient;
using System.Net;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests
{
    public class HttpClientTest
    {
        private readonly HttpClient _client;
        private readonly Mock<HttpMessageHandler> _handler;

        public HttpClientTest()
        {
            _handler = new Mock<HttpMessageHandler>();
            var factory = _handler.CreateClientFactory();
            _client = factory.CreateClient("EncompassClient");
            
            
        }

        [Fact]
        public async Task ReturnNotFoundAsync()
        {
            // A simple example that returns 404 for any request
            _handler.SetupAnyRequest()
                .ReturnsResponse(HttpStatusCode.NotFound);
            var resp = await _client.GetAsync("https://fakerapi.it/api/v1/");
            Assert.True(resp.StatusCode == HttpStatusCode.NotFound);
        }
    }
}
