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

        internal HttpClient TokenClient
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
            _clientId = clientId;
            _clientSecret = clientSecret;
            Client = client;
        }

        #region Public Methods
        public Task<TokenIntrospectionResponse> IntrospectAsync() => IntrospectAsync(CancellationToken.None);

        public Task<TokenIntrospectionResponse> IntrospectAsync(CancellationToken cancellationToken) => IntrospectInternalAsync(cancellationToken, response => response.IsSuccessStatusCode ? response.Content.ReadAsAsync<TokenIntrospectionResponse>() : Task.FromResult<TokenIntrospectionResponse>(null));

        public Task<string> IntrospectRawAsync() => IntrospectRawAsync(CancellationToken.None);

        public Task<string> IntrospectRawAsync(CancellationToken cancellationToken) => IntrospectInternalAsync(cancellationToken, response => response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync() : Task.FromResult<string>(null));

        private async Task<T> IntrospectInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await TokenClient.PostAsync("token/introspection", CreateAccessTokenContent(), cancellationToken).ConfigureAwait(false))
            {
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> RevokeAsync() => RevokeAsync(CancellationToken.None);

        public async Task<bool> RevokeAsync(CancellationToken cancellationToken)
        {
            using (var response = await TokenClient.PostAsync("token/revocation", CreateAccessTokenContent(), cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }

        public override string ToString() => $"{Type} {Token}";

        internal void Dispose() => _tokenClient?.Dispose();

        internal Task SetTokenWithUserCredentialsAsync(string instanceId, string userId, string password, CancellationToken cancellationToken) => SetTokenAsync(new[]
            {
                KeyValuePair.Create("grant_type", "password"),
                KeyValuePair.Create("username", $"{userId}@encompass:{instanceId}"),
                KeyValuePair.Create("password", password)
            }, cancellationToken);

        internal Task SetTokenWithAuthorizationCodeAsync(string redirectUri, string authorizationCode, CancellationToken cancellationToken) => SetTokenAsync(new[]
            {
                KeyValuePair.Create("grant_type", "authorization_code"),
                KeyValuePair.Create("redirect_uri", redirectUri),
                KeyValuePair.Create("code", authorizationCode)
            }, cancellationToken);

        private async Task SetTokenAsync(IEnumerable<KeyValuePair<string, string>> nameValueCollection, CancellationToken cancellationToken)
        {
            using (var response = await TokenClient.PostAsync("token", new FormUrlEncodedContent(nameValueCollection), cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(SetTokenAsync), response).ConfigureAwait(false);
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