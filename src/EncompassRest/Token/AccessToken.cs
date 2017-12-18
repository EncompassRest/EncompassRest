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
    public sealed class AccessToken : ApiObject
    {
        private HttpClient _tokenClient;
        private readonly string _apiClientId;
        private readonly string _apiClientSecret;

        #region Properties
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
                    tokenClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{WebUtility.UrlEncode(_apiClientId)}:{WebUtility.UrlEncode(_apiClientSecret)}")));
                    tokenClient = Interlocked.CompareExchange(ref _tokenClient, tokenClient, null) ?? tokenClient;
                }
                return tokenClient;
            }
        }
        #endregion

        internal AccessToken(string apiClientId, string apiClientSecret, EncompassRestClient client)
            : base(client, "token")
        {
            _apiClientId = apiClientId;
            _apiClientSecret = apiClientSecret;
        }

        #region Public Methods
        public Task<TokenIntrospectionResponse> IntrospectAsync(CancellationToken cancellationToken = default) => PostAsync("introspection", null, CreateAccessTokenContent(), nameof(IntrospectAsync), Token, cancellationToken, response => response.IsSuccessStatusCode ? response.Content.ReadAsAsync<TokenIntrospectionResponse>() : Task.FromResult<TokenIntrospectionResponse>(null), false);

        public Task<string> IntrospectRawAsync(CancellationToken cancellationToken = default) => PostAsync("introspection", null, CreateAccessTokenContent(), nameof(IntrospectRawAsync), Token, cancellationToken, response => response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync() : Task.FromResult<string>(null), false);

        public Task<bool> RevokeAsync(CancellationToken cancellationToken = default) => PostAsync("revocation", null, CreateAccessTokenContent(), nameof(RevokeAsync), Token, cancellationToken, IsSuccessStatusCodeFunc, false); 

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
            var tokenResponse = await PostAsync<TokenResponse>(null, null, new FormUrlEncodedContent(nameValueCollection), nameof(SetTokenAsync), null, cancellationToken).ConfigureAwait(false);
            Token = tokenResponse.AccessToken;
            Type = tokenResponse.TokenType;
        }

        private FormUrlEncodedContent CreateAccessTokenContent() => new FormUrlEncodedContent(new[] { KeyValuePair.Create("token", Token) });

        internal override HttpClient GetHttpClient() => TokenClient;

        [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), ItemRequired = Required.Always)]
        private sealed class TokenResponse
        {
            public string AccessToken { get; set; }

            public string TokenType { get; set; }
        }
        #endregion
    }
}