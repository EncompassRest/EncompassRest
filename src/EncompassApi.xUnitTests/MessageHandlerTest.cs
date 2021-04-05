using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using System.Net;
using System.Threading;
using Moq.Protected;


namespace EncompassApi.xUnitTests
{
    public class MessageHandlerTest
    {
        private readonly ILogger<MessageHandlerTest> _logger;

        public MessageHandlerTest(ILogger<MessageHandlerTest> logger)
        {
            _logger = logger;
           
        }

        [Theory]
        [InlineData("X-Concurrency-Limit-Limit", "X-Concurrency-Limit-Remaining", "X-Rate-Limit-Limit", "X-Rate-Limit-Remaining", "X-Rate-Limit-Reset")]
        public void EncompassResponseHeadersLoggingHandlerTest(params string[] headers)
        {

            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(@"[{ ""id"": 1, ""title"": ""Cool post!""}, { ""id"": 100, ""title"": ""Some title""}]"),

            };
            foreach (var header in headers)
            {
                response.Headers.Add(header, Faker.RandomNumber.Next(10, 9999).ToString());
            }
           
            var mockedHandler = new Mock<EncompassApi.MessageHandlers.EncompassResponseHeadersLoggingHandler<MessageHandlerTest>>(_logger, headers);

            mockedHandler.Protected().Setup<Task<HttpResponseMessage>>(
                "SendAsync", 
                ItExpr.IsAny<HttpRequestMessage>(), 
                ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(response);

            var httpClient = new HttpClient(mockedHandler.Object);
            var resp = httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri(Faker.Internet.Url())
            });

            mockedHandler.Object.LogHeaders(resp.Result, Faker.Internet.Url())
                .Should()
                .ContainKey("ConcurrencyRatio")
                .And
                .ContainKey("XRateLimitRatio")
                .And
                .ContainKeys(headers);

        }
    }

}
