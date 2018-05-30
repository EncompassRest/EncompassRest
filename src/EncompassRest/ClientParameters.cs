using System;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public sealed class ClientParameters
    {
        private string _apiClientId;
        private string _apiClientSecret;
        private int _timeoutRetryCount;

        public string ApiClientId
        {
            get => _apiClientId;
            set
            {
                Preconditions.NotNullOrEmpty(value, nameof(ApiClientId));

                _apiClientId = value;
            }
        }

        public string ApiClientSecret
        {
            get => _apiClientSecret;
            set
            {
                Preconditions.NotNullOrEmpty(value, nameof(ApiClientSecret));

                _apiClientSecret = value;
            }
        }

        public TimeSpan Timeout { get; set; }

        public bool InitializeCustomFieldsCache { get; set; }

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

        public ClientParameters(string apiClientId, string apiClientSecret)
        {
            ApiClientId = apiClientId;
            ApiClientSecret = apiClientSecret;
        }
    }
}