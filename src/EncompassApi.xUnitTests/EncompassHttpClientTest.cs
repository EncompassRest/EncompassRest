using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EncompassApi.xUnitTests
{
    public class EncompassHttpClientTest
    {
        private readonly IEncompassApiClient _client;

        public EncompassHttpClientTest(IEncompassApiClient client)
        {
            _client = client;
        }

        [Fact]
        public void ClientBaseAddressTest()
        {
            var baseUri = _client.HttpClient.BaseAddress;
            Assert.Equal("https://fakerapi.it/api", baseUri.AbsoluteUri);
        }

        [Fact]
        public async Task ClientTest()
        {
            try
            {
               var subs = await _client.Webhook.GetSubscriptionsAsync();
               await Assert.ThrowsAsync<HttpRequestException>(( ) => _client.HttpClient.GetAsync("v1"));
            }
            catch(Exception ex)
            {
                var t = ex.GetType();
            }
        }
    }
}
