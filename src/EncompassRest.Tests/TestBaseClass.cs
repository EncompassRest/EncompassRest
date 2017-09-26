using System;

namespace EncompassRest.Tests
{
    public class TestBaseClass
    {
        public static EncompassRestClient GetTestClient()
        {
            var client = new EncompassRestClient("ClientId", "ClientSecret");
            var accessToken = client.AccessToken;
            accessToken.Type = "Type";
            accessToken.Token = "Token";
            var httpClient = client.HttpClient;
            httpClient.BaseAddress = new Uri("https://try.readme.io/https://api.elliemae.com/");
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;
            defaultRequestHeaders.Clear();
            defaultRequestHeaders.Add("x-api-key", "9JsmcmHyzJuokoWeJJ8HGiRgS5GR8cSKVswz");
            defaultRequestHeaders.Add("origin", string.Empty);
            return client;
        }
    }
}