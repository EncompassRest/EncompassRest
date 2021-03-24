using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.MessageHandlers
{
    public class FairwayTokenClient : ITokenClient
    {
        private readonly HttpClient _httpClient;
        private readonly FairwayTokenClientOptions _options;

        public FairwayTokenClient(HttpClient httpClient, IOptions<FairwayTokenClientOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<string> GetToken()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"{_options.BaseUrl}/core/v1/token");
                request.Headers.Add("requestid", Guid.NewGuid().ToString());
                request.Headers.Add("x-functions-key", _options.HostKey);
                request.Headers.Add("clientid", _options.ClientId);
                request.Headers.Add("clientsecret", _options.ClientSecret);

                var httpResponse = await _httpClient.SendAsync(request);

                httpResponse.EnsureSuccessStatusCode();

                var contents = await httpResponse.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(contents);
                return tokenResponse.access_token;
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
