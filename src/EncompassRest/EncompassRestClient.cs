using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.LoanBatch;
using EncompassRest.LoanPipeline;
using EncompassRest.Token;
using EncompassRest.Utilities;
using EncompassRest.Contacts;
using EncompassRest.CustomDataObjects;

namespace EncompassRest
{
    public sealed class EncompassRestClient : IDisposable
    {
        public static Task<EncompassRestClient> CreateAsync(string apiClientId, string apiClientSecret, string instanceId, Func<TokenCreator, Task<string>> tokenInitializer, CancellationToken cancellationToken = default) =>
            CreateAsync(apiClientId, apiClientSecret, instanceId, (tokenCreator, ct) => tokenInitializer(tokenCreator), cancellationToken);

        public static async Task<EncompassRestClient> CreateAsync(string apiClientId, string apiClientSecret, string instanceId, Func<TokenCreator, CancellationToken, Task<string>> tokenInitializer, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(apiClientId, nameof(apiClientId));
            Preconditions.NotNullOrEmpty(apiClientSecret, nameof(apiClientSecret));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNull(tokenInitializer, nameof(tokenInitializer));

            var client = new EncompassRestClient(apiClientId, apiClientSecret, instanceId, tokenInitializer);
            var accessToken = await tokenInitializer(new TokenCreator(client), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            return client;
        }

        public static Task<EncompassRestClient> CreateFromUserCredentialsAsync(string apiClientId, string apiClientSecret, string instanceId, string userId, string password, CancellationToken cancellationToken = default) =>
            CreateFromUserCredentialsAsync(apiClientId, apiClientSecret, instanceId, userId, password, TokenExpirationHandling.Default, cancellationToken);

        [Obsolete("To avoid storing user credentials this method has been made obsolete. Use the CreateAsync method instead.")]
        public static async Task<EncompassRestClient> CreateFromUserCredentialsAsync(string apiClientId, string apiClientSecret, string instanceId, string userId, string password, TokenExpirationHandling tokenExpirationHandling, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            if (tokenExpirationHandling == TokenExpirationHandling.RetrieveNewToken)
            {
                return await CreateAsync(apiClientId, apiClientSecret, instanceId, (tokenCreator, ct) => tokenCreator.FromUserCredentialsAsync(userId, password, ct), cancellationToken).ConfigureAwait(false);
            }

            Preconditions.NotNullOrEmpty(apiClientId, nameof(apiClientId));
            Preconditions.NotNullOrEmpty(apiClientSecret, nameof(apiClientSecret));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));

            var client = new EncompassRestClient(apiClientId, apiClientSecret, instanceId, null);
            var accessToken = await client.AccessToken.GetTokenFromUserCredentialsAsync(userId, password, nameof(CreateFromUserCredentialsAsync), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            return client;
        }

        public static async Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(string apiClientId, string apiClientSecret, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(apiClientId, nameof(apiClientId));
            Preconditions.NotNullOrEmpty(apiClientSecret, nameof(apiClientSecret));
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            var client = new EncompassRestClient(apiClientId, apiClientSecret);
            var accessToken = await client.AccessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(CreateFromAuthorizationCodeAsync), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            return client;
        }

        public static EncompassRestClient CreateFromAccessToken(string apiClientId, string apiClientSecret, string accessToken)
        {
            Preconditions.NotNullOrEmpty(apiClientId, nameof(apiClientId));
            Preconditions.NotNullOrEmpty(apiClientSecret, nameof(apiClientSecret));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            var client = new EncompassRestClient(apiClientId, apiClientSecret);
            client.AccessToken.Token = accessToken;
            return client;
        }

        internal readonly string InstanceId;
        private readonly Func<TokenCreator, CancellationToken, Task<string>> _tokenInitializer;
        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1);

        private HttpClient _httpClient;
        private Loans.Loans _loans;
        private Schema.Schema _schema;
        private Webhook.Webhook _webhook;
        private Pipeline _pipeline;
        private BatchUpdate _batchUpdate;
        private BorrowerContacts _borrowerContacts;
        private BusinessContacts _businessContacts;
        private BorrowerContactSelector _borrowerContactSelector;
        private BusinessContactSelector _businessContactSelector;
        private ResourceLocks.ResourceLocks _resourceLocks;
        private GlobalCustomDataObjects _globalCustomDataObjects;
        private Users.Users _users;
        private LoanFolders.LoanFolders _loanFolders;
        private Settings.Settings _settings;

        #region Properties
        public AccessToken AccessToken { get; }

        public TokenExpirationHandling TokenExpirationHandling => _tokenInitializer != null ? TokenExpirationHandling.RetrieveNewToken : TokenExpirationHandling.Default;

        public TimeSpan Timeout
        {
            get => HttpClient.Timeout;
            set
            {
                HttpClient.Timeout = value;
                AccessToken.TokenClient.Timeout = value;
            }
        }

        public Loans.Loans Loans
        {
            get
            {
                var loans = _loans;
                return loans ?? Interlocked.CompareExchange(ref _loans, (loans = new Loans.Loans(this)), null) ?? loans;
            }
        }

        public Schema.Schema Schema
        {
            get
            {
                var schema = _schema;
                return schema ?? Interlocked.CompareExchange(ref _schema, (schema = new Schema.Schema(this)), null) ?? schema;
            }
        }

        public Webhook.Webhook Webhook
        {
            get
            {
                var webhook = _webhook;
                return webhook ?? Interlocked.CompareExchange(ref _webhook, (webhook = new Webhook.Webhook(this)), null) ?? webhook;
            }
        }

        public Pipeline Pipeline
        {
            get
            {
                var pipeline = _pipeline;
                return pipeline ?? Interlocked.CompareExchange(ref _pipeline, (pipeline = new Pipeline(this)), null) ?? pipeline;
            }
        }

        public BatchUpdate BatchUpdate
        {
            get
            {
                var batchUpdate = _batchUpdate;
                return batchUpdate ?? Interlocked.CompareExchange(ref _batchUpdate, (batchUpdate = new BatchUpdate(this)), null) ?? batchUpdate;
            }
        }

        public BorrowerContacts BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContacts(this)), null) ?? borrowerContacts;
            }
        }

        public BusinessContacts BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContacts(this)), null) ?? businessContacts;
            }
        }

        public BorrowerContactSelector BorrowerContactSelector
        {
            get
            {
                var borrowerContactSelector = _borrowerContactSelector;
                return borrowerContactSelector ?? Interlocked.CompareExchange(ref _borrowerContactSelector, (borrowerContactSelector = new BorrowerContactSelector(this)), null) ?? borrowerContactSelector;
            }
        }

        public BusinessContactSelector BusinessContactSelector
        {
            get
            {
                var businessContactSelector = _businessContactSelector;
                return businessContactSelector ?? Interlocked.CompareExchange(ref _businessContactSelector, (businessContactSelector = new BusinessContactSelector(this)), null) ?? businessContactSelector;
            }
        }

        internal ResourceLocks.ResourceLocks ResourceLocks
        {
            get
            {
                var resourceLocks = _resourceLocks;
                return resourceLocks ?? Interlocked.CompareExchange(ref _resourceLocks, (resourceLocks = new ResourceLocks.ResourceLocks(this)), null) ?? resourceLocks;
            }
        }

        public GlobalCustomDataObjects GlobalCustomDataObjects
        {
            get
            {
                var globalCustomDataObjects = _globalCustomDataObjects;
                return globalCustomDataObjects ?? Interlocked.CompareExchange(ref _globalCustomDataObjects, (globalCustomDataObjects = new GlobalCustomDataObjects(this)), null) ?? globalCustomDataObjects;
            }
        }

        public Users.Users Users
        {
            get
            {
                var users = _users;
                return users ?? Interlocked.CompareExchange(ref _users, (users = new Users.Users(this)), null) ?? users;
            }
        }

        public LoanFolders.LoanFolders LoanFolders
        {
            get
            {
                var loanFolders = _loanFolders;
                return loanFolders ?? Interlocked.CompareExchange(ref _loanFolders, (loanFolders = new LoanFolders.LoanFolders(this)), null) ?? loanFolders;
            }
        }

        public Settings.Settings Settings
        {
            get
            {
                var settings = _settings;
                return settings ?? Interlocked.CompareExchange(ref _settings, (settings = new Settings.Settings(this)), null) ?? settings;
            }
        }

        internal HttpClient HttpClient
        {
            get
            {
                var httpClient = _httpClient;
                if (httpClient == null)
                {
                    HttpMessageHandler handler = new HttpClientHandler();
                    if (TokenExpirationHandling == TokenExpirationHandling.RetrieveNewToken)
                    {
                        handler = new RetryHandler(handler, async (requestAuthorizationHeader, cancellationToken) =>
                        {
                            await _semaphoreSlim.WaitAsync(cancellationToken).ConfigureAwait(false);
                            try
                            {
                                if (string.Equals(requestAuthorizationHeader.Parameter, AccessToken.Token, StringComparison.Ordinal))
                                {
                                    AccessToken.Token = await _tokenInitializer(new TokenCreator(this), cancellationToken).ConfigureAwait(false);
                                    httpClient.DefaultRequestHeaders.Authorization = CreateAuthorizationHeader();
                                }
                            }
                            finally
                            {
                                _semaphoreSlim.Release();
                            }
                            return httpClient.DefaultRequestHeaders.Authorization;
                        });
                    }
                    httpClient = new HttpClient(handler);
                    httpClient.DefaultRequestHeaders.Authorization = CreateAuthorizationHeader();
                    httpClient = Interlocked.CompareExchange(ref _httpClient, httpClient, null) ?? httpClient;
                }
                return httpClient;
            }
        }
        #endregion

        internal EncompassRestClient(string apiClientId, string apiClientSecret)
        {
            AccessToken = new AccessToken(apiClientId, apiClientSecret, this);
        }

        private EncompassRestClient(string apiClientId, string apiClientSecret, string instanceId, Func<TokenCreator, CancellationToken, Task<string>> tokenInitializer)
            : this(apiClientId, apiClientSecret)
        {
            InstanceId = instanceId;
            _tokenInitializer = tokenInitializer;
        }

        public void Dispose()
        {
            AccessToken.Dispose();
            _httpClient?.Dispose();
        }

        private AuthenticationHeaderValue CreateAuthorizationHeader() => new AuthenticationHeaderValue(AccessToken.Type, AccessToken.Token);

        private sealed class RetryHandler : DelegatingHandler
        {
            private readonly Func<AuthenticationHeaderValue, CancellationToken, Task<AuthenticationHeaderValue>> _reinitializeAuthorizationHeader;

            public RetryHandler(HttpMessageHandler innerHandler, Func<AuthenticationHeaderValue, CancellationToken, Task<AuthenticationHeaderValue>> reinitializeAuthorizationHeader)
                : base(innerHandler)
            {
                _reinitializeAuthorizationHeader = reinitializeAuthorizationHeader;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    request.Headers.Authorization = await _reinitializeAuthorizationHeader(request.Headers.Authorization, cancellationToken).ConfigureAwait(false);
                    response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                }
                return response;
            }
        }
    }
}