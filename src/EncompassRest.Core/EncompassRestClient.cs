using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Calculators;
using EncompassRest.Company;
using EncompassRest.Contacts;
using EncompassRest.EFolder;
using EncompassRest.LoanBatch;
using EncompassRest.LoanFolders;
using EncompassRest.LoanPipeline;
using EncompassRest.Loans;
using EncompassRest.Organizations;
using EncompassRest.ResourceLocks;
using EncompassRest.Schema;
using EncompassRest.Services;
using EncompassRest.Settings;
using EncompassRest.Token;
using EncompassRest.Utilities;
using EncompassRest.Webhook;

namespace EncompassRest
{
    /// <summary>
    /// The client object to make calls to the Encompass Apis.
    /// </summary>
    public interface IEncompassRestClient : IDisposable
#if IASYNC_DISPOSABLE
        , IAsyncDisposable
#endif
    {
        /// <summary>
        /// The access token and related Apis.
        /// </summary>
        IAccessToken AccessToken { get; }
        /// <summary>
        /// A base Api client for use when Apis aren't supported directly.
        /// </summary>
        IBaseApiClient BaseApiClient { get; }
        /// <summary>
        /// The Loan Batch Update Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.LoanBatch.v1 namespace.
        /// </summary>
        IBatchUpdate BatchUpdate { get; }
        /// <summary>
        /// The Calculators Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Calculators.v1 namespace.
        /// </summary>
        ICalculators Calculators { get; }
        /// <summary>
        /// The Company Apis.
        /// </summary>
        ICompany Company { get; }
        /// <summary>
        /// The Contacts Apis.
        /// </summary>
        IContacts Contacts { get; }
        /// <summary>
        /// The EFolder Apis exposed as extension methods from the EncompassRest.EFolder package
        /// within the EncompassRest.EFolder.v1 namespace.
        /// </summary>
        IEFolder EFolder { get; }
        /// <summary>
        /// The Loan Folders Apis exposed as extension methods
        /// within the EncompassRest.LoanFolders.v1 and v3 namespaces.
        /// </summary>
        ILoanFolders LoanFolders { get; }
        /// <summary>
        /// The Loans Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.v1 namespace.
        /// </summary>
        ILoans Loans { get; }
        /// <summary>
        /// The Organizations Apis exposed as extension methods
        /// within the EncompassRest.Organizations.v1 namespace.
        /// </summary>
        IOrganizations Organizations { get; }
        /// <summary>
        /// The Loan Pipeline Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.LoanPipeline.v1 namespace.
        /// </summary>
        IPipeline Pipeline { get; }
        /// <summary>
        /// The Resource Locks Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.ResourceLocks.v1 namespace.
        /// </summary>
        IResourceLocks ResourceLocks { get; }
        /// <summary>
        /// The Schema Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Schema.v1 namespace.
        /// </summary>
        ISchema Schema { get; }
        /// <summary>
        /// The Services Apis exposed as extension methods from the EncompassRest.Services package
        /// within the EncompassRest.Services.v1 namespace.
        /// </summary>
        IServices Services { get; }
        /// <summary>
        /// The Settings Apis.
        /// </summary>
        ISettings Settings { get; }
        /// <summary>
        /// The time span before Api requests are considered timed-out. Default is 100 seconds.
        /// </summary>
        TimeSpan Timeout { get; }
        /// <summary>
        /// The number of times to retry requests when there's a gateway timeout. Default is 0.
        /// </summary>
        int TimeoutRetryCount { get; set; }
        /// <summary>
        /// Indicates how an expired token is handled by the client.
        /// </summary>
        TokenExpirationHandling TokenExpirationHandling { get; }
        /// <summary>
        /// Specifies how the client should handle undefined custom fields.
        /// </summary>
        UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }
        /// <summary>
        /// The Webhook Apis exposed as extension methods
        /// within the EncompassRest.Webhook.v1 namespace.
        /// </summary>
        IWebhook Webhook { get; }
        /// <summary>
        /// Property for sharing common cache between multiple clients such as custom field descriptors.
        /// </summary>
        CommonCache CommonCache { get; }

        /// <summary>
        /// Set by ClientParameters.BaseAddress. The URL to call for API calls. Defaults to "https://api.elliemae.com/".
        /// </summary>
        string BaseAddress { get; set; }

        /// <summary>
        /// An event that occurs when an Api response is received.
        /// </summary>
        event EventHandler<IApiResponseEventArgs> ApiResponse;
        /// <summary>
        /// An event that occurs before attempting to retry a request when there's a gateway timeout.
        /// </summary>
        event EventHandler<ITimeoutRetryEventArgs> TimeoutRetry;
    }

    /// <summary>
    /// The client object to make calls to the Encompass Apis. Use the static factory Create* methods to create a client object.
    /// </summary>
    public sealed class EncompassRestClient : IEncompassRestClient
#if IASYNC_DISPOSABLE
        , IAsyncDisposable
#endif
    {
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
            Preconditions.NotNull(tokenInitializer, nameof(tokenInitializer));

            var client = new EncompassRestClient(parameters, tokenInitializer);
            var accessToken = await tokenInitializer(new TokenCreator(client, cancellationToken)).ConfigureAwait(false);
            client._accessToken.Token = accessToken;
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
            var accessToken = await client._accessToken.GetTokenFromUserCredentialsAsync(instanceId, userId, password, nameof(CreateFromUserCredentialsAsync), cancellationToken).ConfigureAwait(false);
            client._accessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

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
            var accessToken = await client._accessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(CreateFromAuthorizationCodeAsync), cancellationToken).ConfigureAwait(false);
            client._accessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

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
            client._accessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

        /// <summary>
        /// This method is for partner API integration only. You probably want <see cref="CreateFromUserCredentialsAsync(ClientParameters, string, string, string, CancellationToken)"/> instead.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="instanceId">The encompass instance id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        [Obsolete("This method is for partner API integration only. You probably want CreateFromUserCredentialsAsync instead.")]
        public static async Task<EncompassRestClient> CreateFromClientCredentialsAsync(ClientParameters parameters, string instanceId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));

            var client = new EncompassRestClient(parameters);
            var accessToken = await client._accessToken.GetTokenFromClientCredentialsAsync(instanceId, nameof(CreateFromClientCredentialsAsync), cancellationToken).ConfigureAwait(false);
            client._accessToken.Token = accessToken;
            await parameters.TryInitializeAsync(client, client.CommonCache, cancellationToken).ConfigureAwait(false);
            return client;
        }

        private readonly Func<TokenCreator, Task<string>>? _tokenInitializer;
        internal readonly AccessToken _accessToken;
        private int _timeoutRetryCount;

        private HttpClient? _httpClient;
        private Loans.Loans? _loans;
        private Schema.Schema? _schema;
        private Webhook.Webhook? _webhook;
        private Pipeline? _pipeline;
        private BatchUpdate? _batchUpdate;
        private Contacts.Contacts? _contacts;
        private ResourceLocks.ResourceLocks? _resourceLocks;
        private LoanFolders.LoanFolders? _loanFolders;
        private Settings.Settings? _settings;
        private Services.Services? _services;
        private Company.Company? _company;
        private Organizations.Organizations? _organizations;
        private Calculators.Calculators? _calculators;
        private BaseApiClient? _baseApiClient;
        private EFolder.EFolder? _eFolder;

        #region Properties
        /// <inheritdoc/>
        public IAccessToken AccessToken => _accessToken;

        /// <inheritdoc/>
        public TokenExpirationHandling TokenExpirationHandling => _tokenInitializer != null ? TokenExpirationHandling.RetrieveNewToken : TokenExpirationHandling.Default;

        /// <inheritdoc/>
        public TimeSpan Timeout { get; }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public event EventHandler<ITimeoutRetryEventArgs>? TimeoutRetry;

        /// <inheritdoc/>
        public UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }

        /// <inheritdoc/>
        public ILoans Loans
        {
            get
            {
                var loans = _loans;
                return loans ?? Interlocked.CompareExchange(ref _loans, (loans = new Loans.Loans(this)), null) ?? loans;
            }
        }

        /// <inheritdoc/>
        public ISchema Schema
        {
            get
            {
                var schema = _schema;
                return schema ?? Interlocked.CompareExchange(ref _schema, (schema = new Schema.Schema(this)), null) ?? schema;
            }
        }

        /// <inheritdoc/>
        public IWebhook Webhook
        {
            get
            {
                var webhook = _webhook;
                return webhook ?? Interlocked.CompareExchange(ref _webhook, (webhook = new Webhook.Webhook(this)), null) ?? webhook;
            }
        }

        /// <inheritdoc/>
        public IPipeline Pipeline
        {
            get
            {
                var pipeline = _pipeline;
                return pipeline ?? Interlocked.CompareExchange(ref _pipeline, (pipeline = new Pipeline(this)), null) ?? pipeline;
            }
        }

        /// <inheritdoc/>
        public IBatchUpdate BatchUpdate
        {
            get
            {
                var batchUpdate = _batchUpdate;
                return batchUpdate ?? Interlocked.CompareExchange(ref _batchUpdate, (batchUpdate = new BatchUpdate(this)), null) ?? batchUpdate;
            }
        }

        /// <inheritdoc/>
        public IContacts Contacts
        {
            get
            {
                var contacts = _contacts;
                return contacts ?? Interlocked.CompareExchange(ref _contacts, (contacts = new Contacts.Contacts(this)), null) ?? contacts;
            }
        }

        /// <inheritdoc/>
        public IResourceLocks ResourceLocks
        {
            get
            {
                var resourceLocks = _resourceLocks;
                return resourceLocks ?? Interlocked.CompareExchange(ref _resourceLocks, (resourceLocks = new ResourceLocks.ResourceLocks(this)), null) ?? resourceLocks;
            }
        }

        /// <inheritdoc/>
        public ILoanFolders LoanFolders
        {
            get
            {
                var loanFolders = _loanFolders;
                return loanFolders ?? Interlocked.CompareExchange(ref _loanFolders, (loanFolders = new LoanFolders.LoanFolders(this)), null) ?? loanFolders;
            }
        }

        /// <inheritdoc/>
        public ISettings Settings
        {
            get
            {
                var settings = _settings;
                return settings ?? Interlocked.CompareExchange(ref _settings, (settings = new Settings.Settings(this)), null) ?? settings;
            }
        }

        /// <inheritdoc/>
        public IServices Services
        {
            get
            {
                var services = _services;
                return services ?? Interlocked.CompareExchange(ref _services, (services = new Services.Services(this)), null) ?? services;
            }
        }

        /// <inheritdoc/>
        public ICompany Company
        {
            get
            {
                var company = _company;
                return company ?? Interlocked.CompareExchange(ref _company, (company = new Company.Company(this)), null) ?? company;
            }
        }

        /// <inheritdoc/>
        public IOrganizations Organizations
        {
            get
            {
                var organizations = _organizations;
                return organizations ?? Interlocked.CompareExchange(ref _organizations, (organizations = new Organizations.Organizations(this)), null) ?? organizations;
            }
        }

        /// <inheritdoc/>
        public ICalculators Calculators
        {
            get
            {
                var calculators = _calculators;
                return calculators ?? Interlocked.CompareExchange(ref _calculators, (calculators = new Calculators.Calculators(this)), null) ?? calculators;
            }
        }

        /// <inheritdoc/>
        public IEFolder EFolder
        {
            get
            {
                var eFolder = _eFolder;
                return eFolder ?? Interlocked.CompareExchange(ref _eFolder, (eFolder = new EFolder.EFolder(this)), null) ?? eFolder;
            }
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public IBaseApiClient BaseApiClient
        {
            get
            {
                var baseApiClient = _baseApiClient;
                return baseApiClient ?? Interlocked.CompareExchange(ref _baseApiClient, (baseApiClient = new BaseApiClient(this)), null) ?? baseApiClient;
            }
        }

        /// <inheritdoc/>
        public string BaseAddress { get; set; }
        #endregion

        /// <inheritdoc/>
        public event EventHandler<IApiResponseEventArgs>? ApiResponse;

        internal void InvokeApiResponse(HttpResponseMessage response)
        {
            ApiResponse?.Invoke(this, new ApiResponseEventArgs(response));
        }

        internal EncompassRestClient(ClientParameters parameters, Func<TokenCreator, Task<string>>? tokenInitializer = null)
        {
            Timeout = parameters.Timeout > TimeSpan.Zero ? parameters.Timeout : TimeSpan.FromSeconds(100);
            _timeoutRetryCount = parameters.TimeoutRetryCount;
            _accessToken = new AccessToken(parameters.ApiClientId, parameters.ApiClientSecret, this);
            _tokenInitializer = tokenInitializer;
            ApiResponse = parameters.ApiResponse;
            CommonCache = (parameters.CommonCache ??= new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
            BaseAddress = (parameters.BaseAddress?.Length ?? 0) == 0 ? "https://api.elliemae.com/" : parameters.BaseAddress!;
        }

#if IASYNC_DISPOSABLE
        /// <summary>
        /// Revokes the current access token and disposes of the client object asynchronously.
        /// </summary>
        /// <returns></returns>
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
            _accessToken.Dispose();
            _httpClient?.Dispose();
            if (_eFolder != null)
            {
                foreach (var value in _eFolder.ExtensionData.Values)
                {
                    if (value is IDisposable disposable)
                    {
                        disposable.Dispose();
                    }
                }
            }
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
                                        _client._accessToken.Token = await _client._tokenInitializer!(new TokenCreator(_client, cancellationToken)).ConfigureAwait(false);
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
                _client.InvokeApiResponse(response);
                return response;
            }
        }
    }
}