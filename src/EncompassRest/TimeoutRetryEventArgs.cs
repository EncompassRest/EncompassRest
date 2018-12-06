using System;
using System.Net.Http;

namespace EncompassRest
{
    /// <summary>
    /// The event args for when a timeout retry will be attempted.
    /// </summary>
    public sealed class TimeoutRetryEventArgs : EventArgs
    {
        /// <summary>
        /// The Api request.
        /// </summary>
        public HttpRequestMessage Request { get; }

        /// <summary>
        /// The Api timeout response.
        /// </summary>
        public HttpResponseMessage TimeoutResponse { get; }

        /// <summary>
        /// The number of times a retry will have been attempted.
        /// </summary>
        public int RetryCount { get; }

        internal TimeoutRetryEventArgs(HttpRequestMessage request, HttpResponseMessage timeoutResponse, int retryCount)
        {
            Request = request;
            TimeoutResponse = timeoutResponse;
            RetryCount = retryCount;
        }
    }
}