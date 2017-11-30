using EncompassRest.Utilities;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest
{
    public abstract class ApiObject
    {
        private static Func<HttpResponseMessage, Task<string>> s_readAsString = response => response.Content.ReadAsStringAsync();

        private readonly string _baseApiPath;

        public EncompassRestClient Client { get; }

        internal ApiObject(EncompassRestClient client, string baseApiPath)
        {
            Client = client;
            _baseApiPath = baseApiPath;
        }

        internal Task<T> GetAsync<T>(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => GetAsync(requestUri, queryString, methodName, resourceId, cancellationToken, request => request.Content.ReadAsAsync<T>());

        internal Task<string> GetRawAsync(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => GetAsync(requestUri, queryString, methodName, resourceId, cancellationToken, s_readAsString);

        internal async Task<T> GetAsync<T>(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_baseApiPath}{(!string.IsNullOrEmpty(requestUri) && requestUri[0] != '/' ? "/" : string.Empty)}{requestUri}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(CreateErrorMessage(methodName, resourceId), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        internal Task<T> PostAsync<T>(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => PostAsync(content, requestUri, queryString, methodName, resourceId, cancellationToken, request => request.Content.ReadAsAsync<T>());

        internal Task<string> PostRawAsync(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => PostAsync(content, requestUri, queryString, methodName, resourceId, cancellationToken, s_readAsString);

        internal async Task<T> PostAsync<T>(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_baseApiPath}{(!string.IsNullOrEmpty(requestUri) && requestUri[0] != '/' ? "/" : string.Empty)}{requestUri}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(CreateErrorMessage(methodName, resourceId), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        internal Task PatchAsync(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => PatchAsync<string>(content, requestUri, queryString, methodName, resourceId, cancellationToken, null);

        internal Task<string> PatchRawAsync(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => PatchAsync(content, requestUri, queryString, methodName, resourceId, cancellationToken, s_readAsString);

        internal async Task<T> PatchAsync<T>(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_baseApiPath}{(!string.IsNullOrEmpty(requestUri) && requestUri[0] != '/' ? "/" : string.Empty)}{requestUri}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(CreateErrorMessage(methodName, resourceId), response).ConfigureAwait(false);
                }

                if (func != null)
                {
                    return await func.Invoke(response).ConfigureAwait(false);
                }
                return default(T);
            }
        }

        internal Task PutAsync(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => PutAsync<string>(content, requestUri, queryString, methodName, resourceId, cancellationToken, null);

        internal Task<string> PutRawAsync(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => PutAsync(content, requestUri, queryString, methodName, resourceId, cancellationToken, s_readAsString);

        internal async Task<T> PutAsync<T>(HttpContent content, string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.PutAsync($"{_baseApiPath}{(!string.IsNullOrEmpty(requestUri) && requestUri[0] != '/' ? "/" : string.Empty)}{requestUri}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(CreateErrorMessage(methodName, resourceId), response).ConfigureAwait(false);
                }

                if (func != null)
                {
                    return await func.Invoke(response).ConfigureAwait(false);
                }
                return default(T);
            }
        }

        internal async Task<bool> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.DeleteAsync($"{_baseApiPath}{(!string.IsNullOrEmpty(requestUri) && requestUri[0] != '/' ? "/" : string.Empty)}{requestUri}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }

        internal virtual string CreateErrorMessage(string methodName, string resourceId = null) => $"{methodName}{(string.IsNullOrEmpty(resourceId) ? string.Empty : $": {resourceId}")}";
    }
}