using System;
using System.Net.Http;

namespace EncompassApi
{
    /// <summary>
    /// The event args for when a timeout retry will be attempted.
    /// </summary>
    public interface ITimeoutRetryEventArgs
    {
        /// <summary>
        /// The Api request.
        /// </summary>
        HttpRequestMessage Request { get; }
        /// <summary>
        /// The number of times a retry will have been attempted.
        /// </summary>
        int RetryCount { get; }
        /// <summary>
        /// The Api timeout response.
        /// </summary>
        HttpResponseMessage TimeoutResponse { get; }
    }

    /// <summary>
    /// The event args for when a timeout retry will be attempted.
    /// </summary>
    public sealed class TimeoutRetryEventArgs : EventArgs, ITimeoutRetryEventArgs
    {
        /// <inheritdoc/>
        public HttpRequestMessage Request { get; }

        /// <inheritdoc/>
        public HttpResponseMessage TimeoutResponse { get; }

        /// <inheritdoc/>
        public int RetryCount { get; }

        internal TimeoutRetryEventArgs(HttpRequestMessage request, HttpResponseMessage timeoutResponse, int retryCount)
        {
            Request = request;
            TimeoutResponse = timeoutResponse;
            RetryCount = retryCount;
        }
    }
}