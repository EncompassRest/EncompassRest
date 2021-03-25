using EncompassApi.Configuration;
using EncompassApi.MessageHandlers;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.Clients
{
    public class EncompassTokenClient : ITokenClient
    {
        private readonly HttpClient _httpClient;
        private readonly EncompassTokenClientOptions _options;
        public EncompassTokenClient(HttpClient httpClient, IOptions<EncompassTokenClientOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

       public async Task<string> GetToken()
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(
                        $"{WebUtility.UrlEncode(_options.ClientId)}:{WebUtility.UrlEncode(_options.ClientSecret)}")));
                var payload = $"grant_type=password&username={_options.Username}@encompass:{_options.EncompassInstanceId}&password={_options.Password}";
                var httpResponse = await _httpClient.PostAsync(_options.BaseUrl + "/oauth2/v1/token", new StringContent(payload, Encoding.UTF8, "application/x-www-form-urlencoded"));

                httpResponse.EnsureSuccessStatusCode();

                var contents = await httpResponse.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(contents);
                return tokenResponse.access_token;                    

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
