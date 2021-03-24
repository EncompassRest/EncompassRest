using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.MessageHandlers
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
                if (_httpClient.DefaultRequestHeaders.Authorization != null)
                {
                    var postData = $"grant_type=password&username={_options.Username}@encompass:{_options.EncompassInstanceId}&password={_options.Password}";
                    var httpResponse = await _httpClient.PostAsync(_options.BaseUrl + "/oauth2/v1/token", new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded"));

                    httpResponse.EnsureSuccessStatusCode();

                    var contents = await httpResponse.Content.ReadAsStringAsync();
                    var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(contents);
                    return tokenResponse.access_token;                    
                }
                else
                {
                    throw new Exception("Token Http Client Authorization Header not Populated. Please follow configuration guidelines in Documentation");
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
