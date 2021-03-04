using EncompassRest.Calculators;
using EncompassRest.Company;
using EncompassRest.Contacts;
using EncompassRest.EFolder;
using EncompassRest.LoanBatch;
using EncompassRest.LoanFolders;
using EncompassRest.LoanPipeline;
using EncompassRest.Loans;
using EncompassRest.Organizations;
using EncompassRest.Schema;
using EncompassRest.Services;
using EncompassRest.Settings;
using EncompassRest.Token;
using EncompassRest.Utilities;
using EncompassRest.Webhook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static EncompassRest.EncompassRestClient;

namespace EncompassRest
{
    public class EncompassApiService : IEncompassRestClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IClientParameters _clientParameters;

        private readonly Func<TokenCreator, Task<string>>? _tokenInitializer;
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

        public EncompassApiService(IHttpClientFactory httpClientFactory, IClientParameters parameters)
        {
            _httpClientFactory = httpClientFactory;
            _clientParameters = parameters;

            Timeout = parameters.Timeout > TimeSpan.Zero ? parameters.Timeout : TimeSpan.FromSeconds(100);
            _timeoutRetryCount = parameters.TimeoutRetryCount;
            AccessToken = new AccessToken(parameters.ApiClientId, parameters.ApiClientSecret, this);
            //_tokenInitializer = tokenInitializer;
            ApiResponse = parameters.ApiResponse;
            CommonCache = parameters.CommonCache ?? (parameters.CommonCache = new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
            BaseAddress = (parameters.BaseAddress?.Length ?? 0) == 0 ? "https://api.elliemae.com/" : parameters.BaseAddress!;

        }

        #region Properties
        /// <summary>
        /// The access token and related Apis.
        /// </summary>
        public AccessToken AccessToken { get; }

        public Func<TokenCreator, Task<string>>? TokenInitializer { get; private set; }

        IAccessToken IEncompassRestClient.AccessToken => AccessToken;

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
        public event EventHandler<TimeoutRetryEventArgs>? TimeoutRetry;

        private EventHandler<ITimeoutRetryEventArgs>? _interfaceTimeoutRetry;

        event EventHandler<ITimeoutRetryEventArgs>? IEncompassRestClient.TimeoutRetry
        {
            add
            {
                var result = _interfaceTimeoutRetry += value;
                if (result != null)
                {
                    TimeoutRetry += InterfaceTimeoutRetry;
                }
            }
            remove
            {
                var result = _interfaceTimeoutRetry -= value;
                if (result == null)
                {
                    TimeoutRetry -= InterfaceTimeoutRetry;
                }
            }
        }

        private void InterfaceTimeoutRetry(object sender, TimeoutRetryEventArgs e)
        {
            _interfaceTimeoutRetry?.Invoke(sender, e);
        }

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

        Loans.ILoans IEncompassRestClient.Loans => Loans;

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

        Schema.ISchema IEncompassRestClient.Schema => Schema;

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

        Webhook.IWebhook IEncompassRestClient.Webhook => Webhook;

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

        IPipeline IEncompassRestClient.Pipeline => Pipeline;

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

        IBatchUpdate IEncompassRestClient.BatchUpdate => BatchUpdate;

        /// <summary>
        /// The Borrower Contacts Apis.
        /// </summary>
        [Obsolete("Use EncompassRestClient.Contacts.BorrowerContacts instead.")]
        public BorrowerContacts BorrowerContacts => Contacts.BorrowerContacts;

        /// <summary>
        /// The Business Contacts Apis.
        /// </summary>
        [Obsolete("Use EncompassRestClient.Contacts.BusinessContacts instead.")]
        public BusinessContacts BusinessContacts => Contacts.BusinessContacts;

        /// <summary>
        /// The Borrower Contact Selector Apis.
        /// </summary>
        [Obsolete("Use EncompassRestClient.Contacts.BorrowerContactSelector instead.")]
        public BorrowerContactSelector BorrowerContactSelector => Contacts.BorrowerContactSelector;

        /// <summary>
        /// The Business Contact Selector Apis.
        /// </summary>
        [Obsolete("Use EncompassRestClient.Contacts.BusinessContactSelector instead.")]
        public BusinessContactSelector BusinessContactSelector => Contacts.BusinessContactSelector;

        /// <summary>
        /// The Contact Groups Apis.
        /// </summary>
        [Obsolete("Use EncompassRestClient.Contacts.Groups instead.")]
        public ContactGroups ContactGroups => Contacts.Groups;

        /// <summary>
        /// The Contacts Apis.
        /// </summary>
        public Contacts.Contacts Contacts
        {
            get
            {
                var contacts = _contacts;
                return contacts ?? Interlocked.CompareExchange(ref _contacts, (contacts = new Contacts.Contacts(this)), null) ?? contacts;
            }
        }

        IContacts IEncompassRestClient.Contacts => Contacts;

        public ResourceLocks.ResourceLocks ResourceLocks
        {
            get
            {
                var resourceLocks = _resourceLocks;
                return resourceLocks ?? Interlocked.CompareExchange(ref _resourceLocks, (resourceLocks = new ResourceLocks.ResourceLocks(this)), null) ?? resourceLocks;
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

        LoanFolders.ILoanFolders IEncompassRestClient.LoanFolders => LoanFolders;

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

        Settings.ISettings IEncompassRestClient.Settings => Settings;

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

        Services.IServices IEncompassRestClient.Services => Services;

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

        Company.ICompany IEncompassRestClient.Company => Company;

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

        Organizations.IOrganizations IEncompassRestClient.Organizations => Organizations;

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

        Calculators.ICalculators IEncompassRestClient.Calculators => Calculators;

        /// <summary>
        /// The EFolder Apis.
        /// </summary>
        public EFolder.EFolder EFolder
        {
            get
            {
                var eFolder = _eFolder;
                return eFolder ?? Interlocked.CompareExchange(ref _eFolder, (eFolder = new EFolder.EFolder(this)), null) ?? eFolder;
            }
        }

        IEFolder IEncompassRestClient.EFolder => EFolder;

        /// <summary>
        /// Property for sharing common cache between multiple clients such as custom field descriptors.
        /// </summary>
        public CommonCache CommonCache { get; }

        public HttpClient HttpClient
        {
            get
            {
                var httpClient = _httpClient;
                if (httpClient == null)
                {
                    httpClient = _httpClientFactory.CreateClient();
                    //TODO timeout in client
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

        IBaseApiClient IEncompassRestClient.BaseApiClient => BaseApiClient;

        /// <summary>
        /// Set by ClientParameters.BaseAddress. The URL to call for API calls. Defaults to "https://api.elliemae.com/".
        /// </summary>
        public string BaseAddress { get; set; }
        #endregion

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

        public void InvokeApiResponse(HttpResponseMessage response)
        {
            ApiResponse?.Invoke(this, new ApiResponseEventArgs(response));
        }

        /// <summary>
        /// Disposes of the service object.
        /// </summary>
        public void Dispose()
        {
            AccessToken.Dispose();
            _httpClient?.Dispose();
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
    }
}
