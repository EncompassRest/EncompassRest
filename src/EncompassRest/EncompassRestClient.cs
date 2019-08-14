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
using System.ComponentModel;

namespace EncompassRest
{
    /// <summary>
    /// The client object to make calls to the Encompass Apis. Use the static factory Create* methods to create a client object.
    /// </summary>
    public sealed class EncompassRestClient : IDisposable
#if IASYNCDISPOSABLE
        , IAsyncDisposable
#endif
    {
#if NET45
        static EncompassRestClient()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
        }
#endif

        /// <summary>
        /// Creates a client object which will automatically invoke the tokenInitializer when making an Api call with an expired token.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="tokenInitializer">The function to retrieve a new token when making an Api call with an expired token.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassRestClient> CreateAsync(ClientParameters parameters, Func<TokenCreator, Task<string>> tokenInitializer, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var client = new EncompassRestClient(parameters, tokenInitializer);
            var accessToken = await tokenInitializer(new TokenCreator(client, cancellationToken)).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

        /// <summary>
        /// Creates a client object from user credentials. It does not automatically retrieve a new token when the current one expires so most of the time you'll probably want to use the CreateAsync method instead.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="instanceId">The encompass instance id.</param>
        /// <param name="userId">The encompass user id.</param>
        /// <param name="password">The encompass user password.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassRestClient> CreateFromUserCredentialsAsync(ClientParameters parameters, string instanceId, string userId, string password, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            var client = new EncompassRestClient(parameters);
            var accessToken = await client.AccessToken.GetTokenFromUserCredentialsAsync(instanceId, userId, password, nameof(CreateFromUserCredentialsAsync), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

        [Obsolete("Use the ClientParameters overload instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static Task<EncompassRestClient> CreateFromUserCredentialsAsync(string apiClientId, string apiClientSecret, string instanceId, string userId, string password, CancellationToken cancellationToken = default) =>
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            CreateFromUserCredentialsAsync(new ClientParameters(apiClientId, apiClientSecret), instanceId, userId, password, cancellationToken);

        /// <summary>
        /// Creates a client object from an authorization code.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="redirectUri">The redirect uri associated with the authorization code.</param>
        /// <param name="authorizationCode">The authorization code to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(ClientParameters parameters, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            var client = new EncompassRestClient(parameters);
            var accessToken = await client.AccessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(CreateFromAuthorizationCodeAsync), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

        [Obsolete("Use the ClientParameters overload instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(string apiClientId, string apiClientSecret, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default) =>
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            CreateFromAuthorizationCodeAsync(new ClientParameters(apiClientId, apiClientSecret), redirectUri, authorizationCode, cancellationToken);

        /// <summary>
        /// Creates a client object from an existing access token.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="accessToken">The access token to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassRestClient> CreateFromAccessTokenAsync(ClientParameters parameters, string accessToken, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            var client = new EncompassRestClient(parameters);
            client.AccessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

        [Obsolete("Use CreateFromAccessTokenAsync instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static EncompassRestClient CreateFromAccessToken(ClientParameters parameters, string accessToken)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            var client = new EncompassRestClient(parameters);
            client.AccessToken.Token = accessToken;
            return client;
        }

        [Obsolete("Use the ClientParameters overload instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static EncompassRestClient CreateFromAccessToken(string apiClientId, string apiClientSecret, string accessToken) => CreateFromAccessToken(new ClientParameters(apiClientId, apiClientSecret), accessToken);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private readonly Func<TokenCreator, Task<string>> _tokenInitializer;
        private int _timeoutRetryCount;

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
        private ContactGroups _contactGroups;
        private ResourceLocks.ResourceLocks _resourceLocks;
        private GlobalCustomDataObjects _globalCustomDataObjects;
        private Users.Users _users;
        private LoanFolders.LoanFolders _loanFolders;
        private Settings.Settings _settings;
        private Services.Services _services;
        private Company.Company _company;
        private Organizations.Organizations _organizations;
        private Calculators.Calculators _calculators;
        private BaseApiClient _baseApiClient;

#region Properties
        /// <summary>
        /// The access token and related Apis.
        /// </summary>
        public AccessToken AccessToken { get; }

        /// <summary>
        /// Indicates how an expired token is handled by the client.
        /// </summary>
        public TokenExpirationHandling TokenExpirationHandling => _tokenInitializer != null ? TokenExpirationHandling.RetrieveNewToken : TokenExpirationHandling.Default;

        /// <summary>
        /// The time span before Api requests are considered timed-out. Default is 100 seconds.
        /// </summary>
        public TimeSpan Timeout { get; }

        /// <summary>
        /// The number of times to retry requests when there's a gateway timeout. Default is 0.
        /// </summary>
        public int TimeoutRetryCount
        {
            get => _timeoutRetryCount;
            set
            {
                Preconditions.GreaterThanOrEquals(value, nameof(TimeoutRetryCount), 0);
                Preconditions.LessThanOrEquals(value, nameof(TimeoutRetryCount), 3);

                _timeoutRetryCount = value;
            }
        }

        /// <summary>
        /// An event that occurs before attempting to retry a request when there's a gateway timeout.
        /// </summary>
        public event EventHandler<TimeoutRetryEventArgs> TimeoutRetry;

        /// <summary>
        /// Specifies how the client should handle undefined custom fields.
        /// </summary>
        public UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }

        /// <summary>
        /// The Loans Apis.
        /// </summary>
        public Loans.Loans Loans
        {
            get
            {
                var loans = _loans;
                return loans ?? Interlocked.CompareExchange(ref _loans, (loans = new Loans.Loans(this)), null) ?? loans;
            }
        }

        /// <summary>
        /// The Schema Apis.
        /// </summary>
        public Schema.Schema Schema
        {
            get
            {
                var schema = _schema;
                return schema ?? Interlocked.CompareExchange(ref _schema, (schema = new Schema.Schema(this)), null) ?? schema;
            }
        }

        /// <summary>
        /// The Webhook Apis.
        /// </summary>
        public Webhook.Webhook Webhook
        {
            get
            {
                var webhook = _webhook;
                return webhook ?? Interlocked.CompareExchange(ref _webhook, (webhook = new Webhook.Webhook(this)), null) ?? webhook;
            }
        }

        /// <summary>
        /// The Loan Pipeline Apis.
        /// </summary>
        public Pipeline Pipeline
        {
            get
            {
                var pipeline = _pipeline;
                return pipeline ?? Interlocked.CompareExchange(ref _pipeline, (pipeline = new Pipeline(this)), null) ?? pipeline;
            }
        }

        /// <summary>
        /// The Loan Batch Update Apis.
        /// </summary>
        public BatchUpdate BatchUpdate
        {
            get
            {
                var batchUpdate = _batchUpdate;
                return batchUpdate ?? Interlocked.CompareExchange(ref _batchUpdate, (batchUpdate = new BatchUpdate(this)), null) ?? batchUpdate;
            }
        }

        /// <summary>
        /// The Borrower Contacts Apis.
        /// </summary>
        public BorrowerContacts BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContacts(this)), null) ?? borrowerContacts;
            }
        }

        /// <summary>
        /// The Business Contacts Apis.
        /// </summary>
        public BusinessContacts BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContacts(this)), null) ?? businessContacts;
            }
        }

        /// <summary>
        /// The Borrower Contact Selector Apis.
        /// </summary>
        public BorrowerContactSelector BorrowerContactSelector
        {
            get
            {
                var borrowerContactSelector = _borrowerContactSelector;
                return borrowerContactSelector ?? Interlocked.CompareExchange(ref _borrowerContactSelector, (borrowerContactSelector = new BorrowerContactSelector(this)), null) ?? borrowerContactSelector;
            }
        }

        /// <summary>
        /// The Business Contact Selector Apis.
        /// </summary>
        public BusinessContactSelector BusinessContactSelector
        {
            get
            {
                var businessContactSelector = _businessContactSelector;
                return businessContactSelector ?? Interlocked.CompareExchange(ref _businessContactSelector, (businessContactSelector = new BusinessContactSelector(this)), null) ?? businessContactSelector;
            }
        }

        /// <summary>
        /// The Contact Groups Apis.
        /// </summary>
        public ContactGroups ContactGroups
        {
            get
            {
                var contactGroups = _contactGroups;
                return contactGroups ?? Interlocked.CompareExchange(ref _contactGroups, (contactGroups = new ContactGroups(this)), null) ?? contactGroups;
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

        [Obsolete("Use EncompassRestClient.Company.GlobalCustomDataObjects instead.")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public GlobalCustomDataObjects GlobalCustomDataObjects
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get
            {
                var globalCustomDataObjects = _globalCustomDataObjects;
                return globalCustomDataObjects ?? Interlocked.CompareExchange(ref _globalCustomDataObjects, (globalCustomDataObjects = new GlobalCustomDataObjects(this)), null) ?? globalCustomDataObjects;
            }
        }

        [Obsolete("Use EncompassRestClient.Company.Users.GetUserApis(userId).CustomDataObjects instead.")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Users.Users Users
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get
            {
                var users = _users;
                return users ?? Interlocked.CompareExchange(ref _users, (users = new Users.Users(this)), null) ?? users;
            }
        }

        /// <summary>
        /// The Loan Folders Apis.
        /// </summary>
        public LoanFolders.LoanFolders LoanFolders
        {
            get
            {
                var loanFolders = _loanFolders;
                return loanFolders ?? Interlocked.CompareExchange(ref _loanFolders, (loanFolders = new LoanFolders.LoanFolders(this)), null) ?? loanFolders;
            }
        }

        /// <summary>
        /// The Settings Apis.
        /// </summary>
        public Settings.Settings Settings
        {
            get
            {
                var settings = _settings;
                return settings ?? Interlocked.CompareExchange(ref _settings, (settings = new Settings.Settings(this)), null) ?? settings;
            }
        }

        /// <summary>
        /// The Services Apis.
        /// </summary>
        public Services.Services Services
        {
            get
            {
                var services = _services;
                return services ?? Interlocked.CompareExchange(ref _services, (services = new Services.Services(this)), null) ?? services;
            }
        }

        /// <summary>
        /// The Company Apis.
        /// </summary>
        public Company.Company Company
        {
            get
            {
                var company = _company;
                return company ?? Interlocked.CompareExchange(ref _company, (company = new Company.Company(this)), null) ?? company;
            }
        }

        /// <summary>
        /// The Organizations Apis.
        /// </summary>
        public Organizations.Organizations Organizations
        {
            get
            {
                var organizations = _organizations;
                return organizations ?? Interlocked.CompareExchange(ref _organizations, (organizations = new Organizations.Organizations(this)), null) ?? organizations;
            }
        }

        /// <summary>
        /// The Calculators Apis.
        /// </summary>
        public Calculators.Calculators Calculators
        {
            get
            {
                var calculators = _calculators;
                return calculators ?? Interlocked.CompareExchange(ref _calculators, (calculators = new Calculators.Calculators(this)), null) ?? calculators;
            }
        }

        /// <summary>
        /// Property for sharing common cache between multiple clients such as custom field descriptors.
        /// </summary>
        public CommonCache CommonCache { get; }

        internal HttpClient HttpClient
        {
            get
            {
                var httpClient = _httpClient;
                if (httpClient == null)
                {
                    httpClient = new HttpClient(new RetryHandler(this, _tokenInitializer != null))
                    {
                        Timeout = Timeout
                    };
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AccessToken.Type, AccessToken.Token);
                    httpClient = Interlocked.CompareExchange(ref _httpClient, httpClient, null) ?? httpClient;
                }
                return httpClient;
            }
        }

        /// <summary>
        /// A base Api client for use when Apis aren't supported directly.
        /// </summary>
        public BaseApiClient BaseApiClient
        {
            get
            {
                var baseApiClient = _baseApiClient;
                return baseApiClient ?? Interlocked.CompareExchange(ref _baseApiClient, (baseApiClient = new BaseApiClient(this)), null) ?? baseApiClient;
            }
        }
#endregion

        /// <summary>
        /// An event that occurs when an Api response is received.
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> ApiResponse;

        internal EncompassRestClient(ClientParameters parameters, Func<TokenCreator, Task<string>> tokenInitializer = null)
        {
            Timeout = parameters.Timeout > TimeSpan.Zero ? parameters.Timeout : TimeSpan.FromSeconds(100);
            _timeoutRetryCount = parameters.TimeoutRetryCount;
            AccessToken = new AccessToken(parameters.ApiClientId, parameters.ApiClientSecret, this);
            _tokenInitializer = tokenInitializer;
            ApiResponse = parameters.ApiResponse;
            CommonCache = parameters.CommonCache ?? (parameters.CommonCache = new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
        }

#if IASYNCDISPOSABLE
        /// <summary>
        /// Revokes the current access token and disposes of the client object asynchronously.
        /// </summary>
        public async ValueTask DisposeAsync()
        {
            await AccessToken.RevokeAsync().ConfigureAwait(false);
            Dispose();
        }
#endif

        /// <summary>
        /// Disposes of the client object.
        /// </summary>
        public void Dispose()
        {
            AccessToken.Dispose();
            _httpClient?.Dispose();
        }

        internal sealed class RetryHandler : DelegatingHandler
        {
            private readonly EncompassRestClient _client;
            private readonly bool _retryOnUnauthorized;
            private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1);

            public RetryHandler(EncompassRestClient client, bool retryOnUnauthorized)
                : base(new HttpClientHandler())
            {
                _client = client;
                _retryOnUnauthorized = retryOnUnauthorized;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.Unauthorized:
                            if (_retryOnUnauthorized)
                            {
                                await _semaphoreSlim.WaitAsync(cancellationToken).ConfigureAwait(false);
                                try
                                {
                                    if (string.Equals(request.Headers.Authorization.Parameter, _client.AccessToken.Token, StringComparison.Ordinal))
                                    {
                                        _client.AccessToken.Token = await _client._tokenInitializer(new TokenCreator(_client, cancellationToken)).ConfigureAwait(false);
                                        _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_client.AccessToken.Type, _client.AccessToken.Token);
                                    }
                                }
                                finally
                                {
                                    _semaphoreSlim.Release();
                                }
                                request.Headers.Authorization = _client.HttpClient.DefaultRequestHeaders.Authorization;
                                response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                            }
                            break;
                        case HttpStatusCode.GatewayTimeout:
                            var retryCount = 0;
                            while (response.StatusCode == HttpStatusCode.GatewayTimeout && retryCount < _client.TimeoutRetryCount)
                            {
                                ++retryCount;
                                _client.TimeoutRetry?.Invoke(_client, new TimeoutRetryEventArgs(request, response, retryCount));
                                response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                            }
                            break;
                    }
                }
                return response;
            }

            private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                _client.ApiResponse?.Invoke(_client, new ApiResponseEventArgs(response));
                return response;
            }
        }
    }
}