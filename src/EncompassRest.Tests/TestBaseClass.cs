using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Token;
using EncompassRest.Utilities;

namespace EncompassRest.Tests
{
    public class TestBaseClass
    {
        private static EncompassRestClient s_testClient;

        /// <summary>
        /// Do not dispose of this object as it is reused on tests
        /// </summary>
        /// <returns></returns>
        public static async Task<EncompassRestClient> GetTestClientAsync()
        {
            var client = s_testClient;
            if (client == null)
            {
                const string testClientCredentialsFile = "C:\\EncompassRestTestClientCredentials.json"; // Never include this file in source control
                if (File.Exists(testClientCredentialsFile))
                {
                    TestClientCredentials credentials;
                    using (var fs = File.OpenRead(testClientCredentialsFile))
                    {
                        using (var sr = new StreamReader(fs))
                        {
                            credentials = JsonHelper.FromJson<TestClientCredentials>(sr);
                        }
                    }
                    client = await EncompassRestClient.CreateFromUserCredentialsAsync(credentials.ClientId, credentials.ClientSecret, credentials.InstanceId, credentials.UserId, credentials.Password, TokenExpirationHandling.RetrieveNewToken).ConfigureAwait(false);
                    Console.WriteLine("Using test client credentials file");
                }
                else
                {
                    client = new EncompassRestClient("ClientId", "ClientSecret");
                    var accessToken = client.AccessToken;
                    accessToken.Token = "Token";
                    var httpClient = client.HttpClient;
                    httpClient.BaseAddress = new Uri("https://try.readme.io/");
                    var defaultRequestHeaders = httpClient.DefaultRequestHeaders;
                    defaultRequestHeaders.Clear();
                    defaultRequestHeaders.Add("x-api-key", "9JsmcmHyzJuokoWeJJ8HGiRgS5GR8cSKVswz");
                    defaultRequestHeaders.Add("origin", string.Empty);
                    Console.WriteLine("Using Encompass Developer Connect Try It endpoint");
                }
                client = Interlocked.CompareExchange(ref s_testClient, client, null) ?? client;
            }
            return client;
        }

        private sealed class TestClientCredentials
        {
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string InstanceId { get; set; }
            public string UserId { get; set; }
            public string Password { get; set; }
        }
    }
}