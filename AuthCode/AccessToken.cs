using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EncompassREST.Exceptions;
using EncompassREST.HelperClasses;
using Newtonsoft.Json;

namespace EncompassREST
{
    public class AccessToken
    {
        private const string _accessTokenUrlV2 = "https://api.elliemae.com/oauth2/v1/";

        private readonly HttpClient _authClient;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _instanceId;
        private readonly string _basicAuthValue;

        private TokenResponse _token;

        #region Properties
        public Session Session { get; }

        public string Token => _token.AccessToken;

        public string Type => _token.TokenType;

        public string AuthenticationString => $"{Type} {Token}";
        #endregion

        public AccessToken(string clientId, string clientSecret, string instanceId, Session session)
        {
            Session = session;
            _clientSecret = WebUtility.UrlEncode(clientSecret);
            _authClient = new HttpClient()
            {
                BaseAddress = new Uri(_accessTokenUrlV2)
            };
            _basicAuthValue = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{_clientSecret}"));
            _authClient.DefaultRequestHeaders.Add("Authorization", _basicAuthValue);

            _clientId = clientId;
            _instanceId = instanceId;
        }

        #region Public Methods
        public async Task<TokenValidateResponse> GetTokenValidationAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "token/introspection");
            var rp = new RequestParameters
            {
                { "token", _token.AccessToken }
            };

            //message.Headers.Authorization = new AuthenticationHeaderValue(_basicAuthValue);

            message.Content = rp.BuildPostContent();
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await _authClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TokenValidateResponse>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RESTException(nameof(GetTokenValidationAsync), response);
            }
        }

        public async Task<bool> DeleteTokenAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "token/revocation");
            //message.Headers.Authorization = new AuthenticationHeaderValue(_basicAuthValue);

            var rp = new RequestParameters
            {
                { "token", _token.AccessToken }
            };
            message.Content = rp.BuildPostContent();
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            var response = await _authClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
                return true;
            else
            {
                throw new RESTException(nameof(DeleteTokenAsync), response);
            }
        }

        public async Task<bool> GetTokenAsync(string username, string password)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "token");
            //message.Headers.Add("Authorization",_basicAuthValue);

            var rp = new RequestParameters
            {
                { "grant_type", "password" },
                { "username", $"{username}@encompass:{_instanceId}" },
                { "password", password }
            };
            message.Content = rp.BuildPostContent();
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await _authClient.SendAsync(message);

            //var response = await AuthClient.PostAsync("token", rp.buildPostContent());

            if (response.IsSuccessStatusCode)
            {
                var tokenData = await response.Content.ReadAsStringAsync();
                var tr = JsonConvert.DeserializeObject<TokenResponse>(tokenData);
                _token = tr;
                return true;
            }
            else
            {
                throw new RESTException(nameof(GetTokenAsync), response);
            }
        }
        #endregion
    }
}
