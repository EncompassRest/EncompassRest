using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Token
{
    public sealed class AccessToken
    {
        private HttpClient _tokenClient;
        private readonly string _clientId;
        private readonly string _clientSecret;

        #region Properties
        public EncompassRestClient Client { get; }

        public string Token { get; internal set; }

        public string Type { get; internal set; }

        private HttpClient TokenClient
        {
            get
            {
                var tokenClient = _tokenClient;
                if (tokenClient == null)
                {
                    tokenClient = new HttpClient
                    {
                        BaseAddress = new Uri("https://api.elliemae.com/oauth2/v1/")
                    };
                    tokenClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{WebUtility.UrlEncode(_clientId)}:{WebUtility.UrlEncode(_clientSecret)}")));
                    tokenClient = Interlocked.CompareExchange(ref _tokenClient, tokenClient, null) ?? tokenClient;
                }
                return tokenClient;
            }
        }
        #endregion

        internal AccessToken(string clientId, string clientSecret, EncompassRestClient client)
        {
            Preconditions.NotNullOrEmpty(clientId, nameof(clientId));
            Preconditions.NotNullOrEmpty(clientSecret, nameof(clientSecret));

            _clientId = clientId;
            _clientSecret = clientSecret;
            Client = client;
        }

        #region Public Methods
        public async Task<TokenIntrospectionResponse> IntrospectAsync()
        {
            using (var response = await TokenClient.PostAsync("token/introspection", CreateAccessTokenContent()).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                return await response.Content.ReadAsAsync<TokenIntrospectionResponse>().ConfigureAwait(false);
            }
        }

        public async Task<bool> RevokeAsync()
        {
            using (var response = await TokenClient.PostAsync("token/revocation", CreateAccessTokenContent()).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }

        public override string ToString() => $"{Type} {Token}";

        internal void Dispose() => _tokenClient?.Dispose();

        internal Task SetTokenWithUserCredentialsAsync(string instanceId, string userId, string password) => SetTokenAsync(new[]
            {
                KeyValuePair.Create("grant_type", "password"),
                KeyValuePair.Create("username", $"{userId}@encompass:{instanceId}"),
                KeyValuePair.Create("password", password)
            });

        internal Task SetTokenWithAuthorizationCodeAsync(string redirectUri, string authorizationCode) => SetTokenAsync(new[]
            {
                KeyValuePair.Create("grant_type", "authorization_code"),
                KeyValuePair.Create("redirect_uri", redirectUri),
                KeyValuePair.Create("code", authorizationCode)
            });

        private async Task SetTokenAsync(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
        {
            using (var response = await TokenClient.PostAsync("token", new FormUrlEncodedContent(nameValueCollection)).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(SetTokenAsync), response).ConfigureAwait(false);
                }

                var tokenResponse = await response.Content.ReadAsAsync<TokenResponse>().ConfigureAwait(false);
                Token = tokenResponse.AccessToken;
                Type = tokenResponse.TokenType;
            }
        }

        private FormUrlEncodedContent CreateAccessTokenContent() => new FormUrlEncodedContent(new[] { KeyValuePair.Create("token", Token) });

        [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), ItemRequired = Required.Always)]
        private sealed class TokenResponse
        {
            public string AccessToken { get; set; }

            public string TokenType { get; set; }
        }
        #endregion
    }
}