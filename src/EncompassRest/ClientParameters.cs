using System;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    public sealed class ClientParameters
    {
        private string _apiClientId;
        private string _apiClientSecret;
        private int _timeoutRetryCount;

        public string ApiClientId { get; }

        public string ApiClientSecret { get; }

        public TimeSpan Timeout { get; set; }

        [JsonIgnore]
        public CommonCache CommonCache { get; set; }

        public CacheInitialization CustomFieldsCacheInitialization { get; set; }

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

        public EventHandler<ApiResponseEventArgs> ApiResponse { get; set; }

        public ClientParameters(string apiClientId, string apiClientSecret)
        {
            Preconditions.NotNullOrEmpty(apiClientId, nameof(apiClientId));
            Preconditions.NotNullOrEmpty(apiClientSecret, nameof(apiClientSecret));

            ApiClientId = apiClientId;
            ApiClientSecret = apiClientSecret;
        }
    }
}