using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.FuncApp.Configuration
{
    public class HttpClientOptions
    {
        /// <summary>
        /// HttpOptions
        /// </summary>
        public bool Retry { get; set; }
        public int RetryCount { get; set; }
        public int TimeoutInSeconds { get; set; }
        public string ClientName { get; set; }
        public string ClientURL { get; set; }
    }
}
