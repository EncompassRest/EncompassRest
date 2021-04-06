using EncompassApi.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace EncompassApi.xUnitTests.TestServices
{
    public interface IMockedEncompassHttpClientService
    {
        Uri BaseAddress { get; }
        IHttpClientFactory HttpFactory { get; }
        HttpClient MockedClient { get; }
        EncompassApiService MockedEncompassClient { get; }
        Mock<HttpMessageHandler> MockedHandler { get; }

        void SetupResponseMessage(Action<HttpResponseMessage> action, KeyValuePair<string, string>? testHeader = null);
        void SetOptions(Action<Mock<IHttpClientOptions>> options);
        void SetOptions(Mock<IHttpClientOptions> options);
        void AddDefaultRequestHeaders();
    }
}