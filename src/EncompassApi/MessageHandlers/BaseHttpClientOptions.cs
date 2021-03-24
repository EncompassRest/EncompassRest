using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class BaseHttpClientOptions
    {
        /// <summary>
        /// HttpOptions
        /// </summary>
        public bool Retry { get; set; }
        public int RetryCount { get; set; }
        public int TimeoutInSeconds { get; set; }
        public string ClientName { get; set; }
        public string BaseUrl { get; set; }
    }
}
