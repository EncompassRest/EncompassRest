using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EncompassApi.xUnitTests.TestServices;

namespace EncompassApi.xUnitTests
{
    public class EncompassHttpClientTest
    {
        private readonly IMockedEncompassHttpClientService _client;

        public EncompassHttpClientTest(IMockedEncompassHttpClientService client)
        {
            _client = client;
        }

        [Fact]
        public void ClientBaseAddressTest()
        {
            var baseUri = _client.MockedClient.BaseAddress;
            Assert.Equal(_client.BaseAddress.ToString(), baseUri.AbsoluteUri);
        }
    }
}
