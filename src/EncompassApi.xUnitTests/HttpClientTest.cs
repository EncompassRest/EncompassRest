using System;
using Xunit;
using EncompassApi.Extensions;

using Moq;
using System.Net.Http;
using Moq.Contrib.HttpClient;
using System.Net;
using System.Threading.Tasks;
using EncompassApi.Configuration;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using FluentAssertions;

namespace EncompassApi.xUnitTests
{
    public class HttpClientTest
    {
        private readonly Mock<HttpMessageHandler> _handler;
        private readonly IHttpClientFactory _factory;
        private readonly HttpClient _client;
        const string HTTPCLIENT_NAME = "EncompassClient";
        public HttpClientTest()
        {
            _handler = new Mock<HttpMessageHandler>();
            _factory = _handler.CreateClientFactory();
            _client = _factory.CreateClient("EncompassClient");
        }

        [Fact]
        public async Task ReturnNotFoundTestAsync()
        {
            // A simple example that returns 404 for any request
            _handler.SetupAnyRequest()
                .ReturnsResponse(HttpStatusCode.NotFound);
            var resp = await _client.GetAsync("https://fakerapi.it/api/v1/");
            Assert.True(resp.StatusCode == HttpStatusCode.NotFound);
        }

        [Theory]
        [InlineData(new DecompressionMethods[] { DecompressionMethods.GZip })]
        [InlineData(new DecompressionMethods[] { DecompressionMethods.GZip, DecompressionMethods.Deflate })]
        public async Task AddDefaultHeadersTestAsync(DecompressionMethods[] dms)
        {
            var MockedHttpClientOptions = new Mock<IHttpClientOptions>();

            var MockedCompressionOptions = new Mock<HttpClientCompressionHandlerOptions>();
            var f = Enum.GetValues(typeof(DecompressionMethods)).Cast<DecompressionMethods>().AsEnumerable();
            MockedCompressionOptions
                .SetupProperty(m => m.DecompressionMethods);
            MockedCompressionOptions.Object.DecompressionMethods = dms;
            MockedCompressionOptions.Object.DecompressionMethods.Should().HaveCount(dms.Count());
            MockedCompressionOptions.Verify();


            MockedHttpClientOptions.SetupProperty(m => m.CompressionOptions);
            MockedHttpClientOptions.Object.CompressionOptions = MockedCompressionOptions.Object;
            // MockedHttpClientOptions.VerifySet(m => m.CompressionOptions = MockedCompressionOptions.Object);

            _client.AddDefaultRequestHeaders(MockedHttpClientOptions.Object);
            var hasGzip = _client.DefaultRequestHeaders.AcceptEncoding.Count == dms.Count();
            Assert.True(hasGzip);
        }
    }
}
