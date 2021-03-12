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
using EncompassRest.MessageHandlers;
using EncompassRest.Organizations;
using EncompassRest.Schema;
using EncompassRest.Services;
using EncompassRest.Settings;
using EncompassRest.Token;
using EncompassRest.Utilities;
using EncompassRest.Webhook;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Extensions.Http;

namespace EncompassRest
{
    /// <summary>
    /// The client object to make calls to the Encompass Apis. Use the static factory Create* methods to create a client object.
    /// </summary>
    public interface IEncompassRestClient : IDisposable
#if IASYNC_DISPOSABLE
        , IAsyncDisposable
#endif
    {
        /// <summary>
        /// The http client
        /// </summary>
        HttpClient HttpClient { get; }
        /// <summary>
        /// A base Api client for use when Apis aren't supported directly.
        /// </summary>
        IBaseApiClient BaseApiClient { get; }
        /// <summary>
        /// The Loan Batch Update Apis.
        /// </summary>
        IBatchUpdate BatchUpdate { get; }
        /// <summary>
        /// The Calculators Apis.
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
        /// The EFolder Apis.
        /// </summary>
        IEFolder EFolder { get; }
        /// <summary>
        /// The Loan Folders Apis.
        /// </summary>
        ILoanFolders LoanFolders { get; }
        /// <summary>
        /// The Loans Apis.
        /// </summary>
        ILoans Loans { get; }
        /// <summary>
        /// The Organizations Apis.
        /// </summary>
        IOrganizations Organizations { get; }
        /// <summary>
        /// The Loan Pipeline Apis.
        /// </summary>
        IPipeline Pipeline { get; }
        /// <summary>
        /// The Schema Apis.
        /// </summary>
        ISchema Schema { get; }
        /// <summary>
        /// The Services Apis.
        /// </summary>
        IServices Services { get; }
        /// <summary>
        /// The Settings Apis.
        /// </summary>
        ISettings Settings { get; }

        /// <summary>
        /// Specifies how the client should handle undefined custom fields.
        /// </summary>
        UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }
        /// <summary>
        /// The Webhook Apis.
        /// </summary>
        IWebhook Webhook { get; }
        /// <summary>
        /// Expose Resource Locks from Interface
        /// </summary>
        ResourceLocks.ResourceLocks ResourceLocks { get; }
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
        void InvokeApiResponse(HttpResponseMessage response);
    }

    /// <summary>
    /// The client object to make calls to the Encompass Apis. Use the static factory Create* methods to create a client object.
    /// </summary>
    public sealed class EncompassRestClient : IEncompassRestClient
    {
        private readonly IEncompassRestClient _encompassApiSerice;
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
        public static async Task<EncompassRestClient> CreateAsync(IClientParameters parameters, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            Preconditions.NotNull(parameters, nameof(parameters));

            //TODO HttpClient Private Method setup
            var client = new EncompassRestClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
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
        public static async Task<EncompassRestClient> CreateFromUserCredentialsAsync(IClientParameters parameters, string instanceId, string userId, string password, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            var tokenServiceClientOptions = new TokenServiceClientOptions
            {
                BaseUrl = parameters.BaseAddress,
                ClientId = parameters.ApiClientId,
                ClientSecret = parameters.ApiClientSecret,
                Username = userId,
                Password = password,
                EncompassInstanceId = instanceId
            };

            IOptions<TokenServiceClientOptions> tokenClientIOptions = Options.Create(tokenServiceClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(parameters.TimeoutRetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(parameters.Timeout);

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton(tokenClientIOptions);

            serviceCollection.AddHttpClient("TokenClient")
                .AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(parameters.TimeoutRetryCount))
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(parameters.Timeout));

            serviceCollection.AddScoped<ITokenServiceClient>(sp => new TokenServiceClient(sp.GetService<IHttpClientFactory>().CreateClient("TokenClient"), tokenClientIOptions));

            serviceCollection.AddHttpClient("EncompassHttpClient", c => c.BaseAddress = new Uri(parameters.BaseAddress))
                .AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(parameters.TimeoutRetryCount))
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(parameters.Timeout))
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenServiceClient>()));

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

            //TODO HttpClient Private Method setup
            var client = new EncompassRestClient(parameters, new EncompassApiService(httpClientFactory.CreateClient("EncompassHttpClient"), parameters));
            //removed token initialization
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
        public static async Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(IClientParameters parameters, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            //TODO HttpClient Private Method setup
            var client = new EncompassRestClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
            return client;
        }

        /// <summary>
        /// Creates a client object from an existing access token.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="accessToken">The access token to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassRestClient> CreateFromAccessTokenAsync(IClientParameters parameters, string accessToken, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            //TODO HttpClient Private Method setup
            var client = new EncompassRestClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
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
        public static async Task<EncompassRestClient> CreateFromClientCredentialsAsync(IClientParameters parameters, string instanceId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));

            //TODO HttpClient Private Method setup
            var client = new EncompassRestClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
            return client;
        }

        private EFolder.EFolder? _eFolder;

        #region Properties
        /// <inheritdoc/>
        public UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }

        /// <summary>
        /// The Loans Apis.
        /// </summary>
        public Loans.Loans Loans => (Loans.Loans)_encompassApiSerice.Loans;
        ILoans IEncompassRestClient.Loans => Loans;

        /// <summary>
        /// The Schema Apis.
        /// </summary>
        public Schema.Schema Schema => (Schema.Schema)_encompassApiSerice.Schema;
        ISchema IEncompassRestClient.Schema => Schema;

        /// <summary>
        /// The Webhook Apis.
        /// </summary>
        public Webhook.Webhook Webhook => (Webhook.Webhook)_encompassApiSerice.Webhook;
        IWebhook IEncompassRestClient.Webhook => Webhook;

        /// <summary>
        /// The Loan Pipeline Apis.
        /// </summary>
        public Pipeline Pipeline => (Pipeline)_encompassApiSerice.Pipeline;
        IPipeline IEncompassRestClient.Pipeline => Pipeline;

        /// <summary>
        /// The Loan Batch Update Apis.
        /// </summary>
        public BatchUpdate BatchUpdate => (BatchUpdate)_encompassApiSerice.BatchUpdate;
        IBatchUpdate IEncompassRestClient.BatchUpdate => BatchUpdate;

        /// <summary>
        /// The Contacts Apis.
        /// </summary>
        public Contacts.Contacts Contacts => (Contacts.Contacts)_encompassApiSerice.Contacts;
        IContacts IEncompassRestClient.Contacts => Contacts;

        public ResourceLocks.ResourceLocks ResourceLocks => _encompassApiSerice.ResourceLocks;


        /// <summary>
        /// The Loan Folders Apis.
        /// </summary>
        public LoanFolders.LoanFolders LoanFolders => (LoanFolders.LoanFolders)_encompassApiSerice.LoanFolders;
        ILoanFolders IEncompassRestClient.LoanFolders => LoanFolders;

        /// <summary>
        /// The Settings Apis.
        /// </summary>
        public Settings.Settings Settings => (Settings.Settings)_encompassApiSerice.Settings;
        ISettings IEncompassRestClient.Settings => Settings;

        /// <summary>
        /// The Services Apis.
        /// </summary>
        public Services.Services Services => (Services.Services)_encompassApiSerice.Services;
        IServices IEncompassRestClient.Services => Services;

        /// <summary>
        /// The Company Apis.
        /// </summary>
        public Company.Company Company => (Company.Company)_encompassApiSerice.Company;
        ICompany IEncompassRestClient.Company => Company;

        /// <summary>
        /// The Organizations Apis.
        /// </summary>
        public Organizations.Organizations Organizations => (Organizations.Organizations)_encompassApiSerice.Organizations;
        IOrganizations IEncompassRestClient.Organizations => Organizations;

        /// <summary>
        /// The Calculators Apis.
        /// </summary>
        public Calculators.Calculators Calculators => (Calculators.Calculators)_encompassApiSerice.Calculators;
        ICalculators IEncompassRestClient.Calculators => Calculators;

        /// <summary>
        /// The EFolder Apis.
        /// </summary>
        public EFolder.EFolder EFolder => (EFolder.EFolder)_encompassApiSerice.EFolder;
        IEFolder IEncompassRestClient.EFolder => EFolder;

        /// <inheritdoc/>
        public CommonCache CommonCache { get; }

        public HttpClient HttpClient => _encompassApiSerice.HttpClient;


        /// <summary>
        /// A base Api client for use when Apis aren't supported directly.
        /// </summary>
        public BaseApiClient BaseApiClient => (BaseApiClient)_encompassApiSerice.BaseApiClient;
        IBaseApiClient IEncompassRestClient.BaseApiClient => BaseApiClient;
        #endregion
        /// <inheritdoc/>
        public string BaseAddress 
        { 
            get 
            {
                return _encompassApiSerice.BaseAddress;
            }
            set 
            {
                _encompassApiSerice.BaseAddress = value;
            }
        }


        //TODO: This needs to be separated in the interface.
        //ISP for managing events. Need to be removed from base interface class

        /// <summary>
        /// An event that occurs when an Api response is received.
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? ApiResponse;

        private EventHandler<IApiResponseEventArgs>? _interfaceApiResponse;

        event EventHandler<IApiResponseEventArgs>? IEncompassRestClient.ApiResponse
        {
            add
            {
                var result = _interfaceApiResponse += value;
                if (result != null)
                {
                    ApiResponse += InterfaceApiResponse;
                }
            }
            remove
            {
                var result = _interfaceApiResponse -= value;
                if (result == null)
                {
                    ApiResponse -= InterfaceApiResponse;
                }
            }
        }

        private void InterfaceApiResponse(object sender, ApiResponseEventArgs e)
        {
            _interfaceApiResponse?.Invoke(sender, e);
        }

        public void InvokeApiResponse(HttpResponseMessage response) => _encompassApiSerice.InvokeApiResponse(response);
        

        internal EncompassRestClient(IClientParameters parameters)
        {
            ApiResponse = parameters.ApiResponse;
            CommonCache = (parameters.CommonCache ??= new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
        }

        internal EncompassRestClient(IClientParameters parameters, IEncompassRestClient encompassApiService)
        {
            _encompassApiSerice = encompassApiService;
            ApiResponse = parameters.ApiResponse;
            CommonCache = (parameters.CommonCache ??= new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
        }

        /// <summary>
        /// Disposes of the client object.
        /// </summary>
        public void Dispose()
        {
            _encompassApiSerice.Dispose();
        }

#if IASYNC_DISPOSABLE
        /// <summary>
        /// Revokes the current access token and disposes of the client object asynchronously.
        /// </summary>
        /// <returns></returns>
        public async ValueTask DisposeAsync()
        {
            _encompassApiSerice.Dispose();
            Dispose();
        }
#endif
    }
}