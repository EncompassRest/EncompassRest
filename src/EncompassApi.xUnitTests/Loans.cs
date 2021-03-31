using System;
using Xunit;
using EncompassApi;
using Moq;
using System.Net.Http;
using Moq.Contrib.HttpClient;

namespace EncompassApi.xUnitTests
{
    public class Loans
    {
        private readonly HttpClient _client;

        public Loans()
        {
            var handler = new Mock<HttpMessageHandler>();
            var factory = handler.CreateClientFactory();
            _client = factory.CreateClient();
        }

        [Fact]
        public void Test1()
        {

            Assert.True(true);
        }
    }
}
