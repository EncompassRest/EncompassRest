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
using EncompassApi.xUnitTests.TestServices;
using Xunit.Abstractions;

namespace EncompassApi.xUnitTests
{
    public class HttpClientTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassHttpClientService;
        public HttpClientTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClientService)
        {
            _outputWriter = outputWriter;
            _mockedEncompassHttpClientService = mockedEncompassHttpClientService;
        }

        [Theory]
        [InlineData(new DecompressionMethods[] { DecompressionMethods.GZip })]
        [InlineData(new DecompressionMethods[] { DecompressionMethods.GZip, DecompressionMethods.Deflate })]
        public async Task AddDefaultHeadersTestAsync(DecompressionMethods[] dms)
        {
            _outputWriter.WriteLine("### Start AddDefaultHeadersTestAsync! ###");
            var MockedCompressionOptions = new Mock<HttpClientCompressionHandlerOptions>();
            MockedCompressionOptions
                .SetupProperty(m => m.DecompressionMethods);
            MockedCompressionOptions.Object.DecompressionMethods = dms;

            MockedCompressionOptions.Object.DecompressionMethods.Should().HaveCount(dms.Count());
            MockedCompressionOptions.Verify();

            _mockedEncompassHttpClientService.SetOptions(options =>
            {
                options.Object.CompressionOptions = MockedCompressionOptions.Object;
            });


            _mockedEncompassHttpClientService.AddDefaultRequestHeaders();
            var hasGzip = _mockedEncompassHttpClientService.MockedClient.DefaultRequestHeaders.AcceptEncoding.Count == dms.Count();
            Assert.True(hasGzip);
        }
    }
}
