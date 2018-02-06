using System;
using System.Net.Http;

namespace EncompassRest
{
    public sealed class TimeoutRetryEventArgs : EventArgs
    {
        public HttpRequestMessage Request { get; }

        public HttpResponseMessage TimeoutResponse { get; }

        public int RetryCount { get; }

        internal TimeoutRetryEventArgs(HttpRequestMessage request, HttpResponseMessage timeoutResponse, int retryCount)
        {
            Request = request;
            TimeoutResponse = timeoutResponse;
            RetryCount = retryCount;
        }
    }
}