using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace EncompassApi.xUnitTests.TestServices
{
    public interface IMockedEncompassHttpClientService
    {
        IHttpClientFactory HttpFactory { get; }
        HttpClient MockedClient { get; }
        EncompassApiService MockedEncompassClient { get; }
        Mock<HttpMessageHandler> MockedHandler { get; }

        void SetupResponseMessage(Action<HttpResponseMessage> action, KeyValuePair<string, string>? testHeader = null);
    }
}