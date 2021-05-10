using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// The parameters for initializing a client object.
    /// </summary>
    public class ClientParameters
    {
        private int _timeoutRetryCount;
        internal event Func<ClientParameters, EncompassRestClient, CommonCache, CancellationToken, Task>? Initialization;

        /// <summary>
        /// The Api Client Id.
        /// </summary>
        public string ApiClientId { get; }

        /// <summary>
        /// The Api Client Secret.
        /// </summary>
        public string ApiClientSecret { get; }

        /// <summary>
        /// The time span before Api requests are considered timed-out. Default is 100 seconds.
        /// </summary>
        public TimeSpan Timeout { get; set; }

        /// <summary>
        /// Property for sharing common cache between multiple clients such as custom field descriptors.
        /// </summary>
        [JsonIgnore]
        public CommonCache? CommonCache { get; set; }

        /// <summary>
        /// Specifies when the custom fields cache should be initialized or refreshed.
        /// </summary>
        public CacheInitialization CustomFieldsCacheInitialization { get; set; }

        /// <summary>
        /// Specifies when the standard fields cache should be refreshed.
        /// </summary>
        public CacheInitialization StandardFieldsCacheInitialization { get; set; }

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
        /// The event handler to attach to the <see cref="EncompassRestClient.ApiResponse"/> event of the created client.
        /// </summary>
        public EventHandler<IApiResponseEventArgs>? ApiResponse { get; set; }

        /// <summary>
        /// Specifies how the client should handle undefined custom fields.
        /// </summary>
        public UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }

        /// <summary>
        /// The URL to call for API calls. Defaults to "https://api.elliemae.com/".
        /// </summary>
        public string? BaseAddress { get; set; }

        /// <summary>
        /// The client parameters constructor.
        /// </summary>
        /// <param name="apiClientId">The Api Client Id.</param>
        /// <param name="apiClientSecret">The Api Client Secret.</param>
        public ClientParameters(string apiClientId, string apiClientSecret)
        {
            Preconditions.NotNullOrEmpty(apiClientId, nameof(apiClientId));
            Preconditions.NotNullOrEmpty(apiClientSecret, nameof(apiClientSecret));

            ApiClientId = apiClientId;
            ApiClientSecret = apiClientSecret;
        }

        internal Task TryInitializeAsync(EncompassRestClient client, CommonCache commonCache, CancellationToken cancellationToken) => Initialization?.Invoke(this, client, commonCache, cancellationToken) ?? TaskHelper.CompletedTask;
    }
}