using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Base Api object.
    /// </summary>
    public interface IApiObject
    {
        IEncompassRestClient Client { get; }
    }

    internal abstract class ApiObject : IApiObject
    {
        internal static readonly HttpMethod PatchMethod = new HttpMethod("PATCH");

        internal static readonly Func<HttpResponseMessage, Task<string>> ReadAsStringFunc = response => response.Content.ReadAsStringAsync();

        internal static readonly Func<HttpResponseMessage, Task<string>> ReadLocationFunc = response => Task.FromResult(GetLocation(response));

        internal static readonly Func<HttpResponseMessage, Task<string>> ReadAsStringElseLocationFunc = response => response.Content.Headers.ContentLength > 0 ? response.Content.ReadAsStringAsync() : Task.FromResult(GetLocation(response));

        internal static readonly Func<HttpResponseMessage, Task<bool>> IsSuccessStatusCodeFunc = response => Task.FromResult(response.IsSuccessStatusCode);

        internal static readonly Func<HttpResponseMessage, Task<byte[]>> ReadAsByteArrayFunc = response => response.Content.ReadAsByteArrayAsync();

        internal static readonly Func<HttpResponseMessage, Task<Stream>> ReadAsStreamFunc = response => response.Content.ReadAsStreamAsync();

        internal const string ViewEntityQueryString = "?view=entity";

        internal static string GetLocation(HttpResponseMessage response) => Path.GetFileName(response.Headers.Location.OriginalString);

        private readonly string? _baseApiPath;
        private ConcurrentDictionary<string, object>? _extensionData;

        internal ConcurrentDictionary<string, object> ExtensionData
        {
            get
            {
                var extensionData = _extensionData;
                return extensionData ?? Interlocked.CompareExchange(ref _extensionData, (extensionData = new ConcurrentDictionary<string, object>(StringComparer.OrdinalIgnoreCase)), null) ?? extensionData;
            }
        }

        /// <summary>
        /// The <see cref="IEncompassRestClient"/> associated with the Api object.
        /// </summary>
        public EncompassRestClient Client { get; }

        IEncompassRestClient IApiObject.Client => Client;

        internal ApiObject(EncompassRestClient client, string? baseApiPath)
        {
            Client = client;
            _baseApiPath = baseApiPath;
        }

        internal Task<T> GetAsync<T>(string? requestUri, string? queryString, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, FuncCache<T>.ReadAsFunc);

        internal async Task<List<T>> GetListAsync<T>(string? requestUri, string? queryString, string methodName, string? resourceId, CancellationToken cancellationToken)
        {
            var list = await SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, FuncCache<List<T>>.ReadAsFunc, NonSuccessStatusCodeHandling.ThrowOnNon404).ConfigureAwait(false);
            return list ?? new List<T>();
        }

        internal Task<T> GetDirtyAsync<T>(string? requestUri, string? queryString, string methodName, string? resourceId, CancellationToken cancellationToken) where T : class, IDirty => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, DirtyFuncCache<T>.ReadAsDirtyFunc);

        internal async Task<List<T>> GetDirtyListAsync<T>(string? requestUri, string? queryString, string methodName, string? resourceId, CancellationToken cancellationToken) where T : class, IDirty
        {
            var list = await SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, DirtyFuncCache<T>.ReadAsDirtyListFunc, NonSuccessStatusCodeHandling.ThrowOnNon404).ConfigureAwait(false);
            return list ?? new List<T>();
        }

        internal Task GetPopulateDirtyAsync(string? requestUri, string? queryString, string methodName, string? resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, target, populate, cancellationToken);

        internal Task GetPopulateAsync(string? requestUri, string? queryString, string methodName, string? resourceId, object target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, target, populate, cancellationToken);

        internal Task<string> GetRawAsync(string? requestUri, string? queryString, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task<T> PostAsync<T>(string? requestUri, string? queryString, HttpContent? content, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Post, requestUri, queryString, content, methodName, resourceId, cancellationToken, FuncCache<T>.ReadAsFunc);

        internal Task<string> PostRawAsync(string? requestUri, string? queryString, HttpContent? content, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Post, requestUri, queryString, content, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task<string> PostPopulateDirtyAsync<T>(string? requestUri, string methodName, T value, bool populate, CancellationToken cancellationToken) where T : class, IDirty, IIdentifiable => PostPopulateDirtyAsync(requestUri, populate ? ViewEntityQueryString : null, methodName, value, populate, cancellationToken);

        internal Task<string> PostPopulateDirtyAsync<T>(string? requestUri, string? queryString, string methodName, T value, bool populate, CancellationToken cancellationToken) where T : class, IDirty, IIdentifiable => SendFullUriPopulateDirtyAsync(HttpMethod.Post, GetFullUri(requestUri), queryString, JsonStreamContent.Create(value), methodName, value, populate, cancellationToken);

        internal Task<string> PostPopulateDirtyAsync<T>(string? requestUri, string? queryString, HttpContent content, string methodName, T? value, bool populate, CancellationToken cancellationToken) where T : class, IDirty, IIdentifiable => SendFullUriPopulateDirtyAsync(HttpMethod.Post, GetFullUri(requestUri), queryString, content, methodName, value, populate, cancellationToken);

        internal Task<string> SendFullUriPopulateDirtyAsync<T>(HttpMethod method, string? requestUri, string? queryString, HttpContent content, string methodName, T? value, bool populate, CancellationToken cancellationToken) where T : class, IDirty, IIdentifiable => SendFullUriAsync(method, requestUri, queryString, content, methodName, null, cancellationToken, async response =>
        {
            var id = GetLocation(response);
            if (value != null)
            {
                value.Id = id;
            }
            if (populate)
            {
                await response.Content.PopulateAsync(value!).ConfigureAwait(false);
            }
            if (value != null)
            {
                value.Dirty = false;
            }
            return id;
        });

        internal Task<T> PostAsync<T>(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>>? func, NonSuccessStatusCodeHandling nonSuccessStatusCodeHandling = NonSuccessStatusCodeHandling.Throw) => SendAsync(HttpMethod.Post, requestUri, queryString, content, methodName, resourceId, cancellationToken, func, nonSuccessStatusCodeHandling);

        internal Task PatchAsync(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync<string>(PatchMethod, requestUri, queryString, content, methodName, resourceId, cancellationToken, null);

        internal Task<string> PatchRawAsync(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync(PatchMethod, requestUri, queryString, content, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task PatchPopulateDirtyAsync(string? requestUri, HttpContent content, string methodName, string? resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(PatchMethod, requestUri, populate ? ViewEntityQueryString : null, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task PatchPopulateDirtyAsync(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(PatchMethod, requestUri, queryString, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task<T> PatchAsync<T>(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func) => SendAsync(PatchMethod, requestUri, queryString, content, methodName, resourceId, cancellationToken, func);

        internal Task PutAsync(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync<string>(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, cancellationToken, null);

        internal Task<string> PutRawAsync(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task PutPopulateDirtyAsync(string? requestUri, HttpContent content, string methodName, string? resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(HttpMethod.Put, requestUri, populate ? ViewEntityQueryString : null, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task PutPopulateDirtyAsync(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task<T> PutAsync<T>(string? requestUri, string? queryString, HttpContent content, string methodName, string? resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func) => SendAsync(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, cancellationToken, func);

        internal Task<bool> TryDeleteAsync(string? requestUri, string? queryString, CancellationToken cancellationToken) => SendAsync(HttpMethod.Delete, requestUri, queryString, null, null, null, cancellationToken, IsSuccessStatusCodeFunc, NonSuccessStatusCodeHandling.NoThrow);

        internal Task DeleteAsync(string? requestUri, string? queryString, CancellationToken cancellationToken) => SendAsync<string>(HttpMethod.Delete, requestUri, queryString, null, null, null, cancellationToken, null);

        private Task PopulateDirtyInternalAsync(HttpMethod method, string? requestUri, string? queryString, HttpContent? content, string methodName, string? resourceId, object target, bool populate, CancellationToken cancellationToken) => SendAsync(method, requestUri, queryString, content, methodName, resourceId, cancellationToken, async response =>
        {
            if (populate)
            {
                await response.Content.PopulateAsync(target).ConfigureAwait(false);
            }
            if (target is IDirty d)
            {
                d.Dirty = false;
            }
            return string.Empty;
        });

        internal Task<T> SendAsync<T>(HttpMethod method, string? requestUri, string? queryString, HttpContent? content, string? methodName, string? resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>>? func, NonSuccessStatusCodeHandling nonSuccessStatusCodeHandling = NonSuccessStatusCodeHandling.Throw, bool disposeResponse = true) =>
            SendFullUriAsync(method, GetFullUri(requestUri), queryString, content, methodName, resourceId, cancellationToken, func, nonSuccessStatusCodeHandling, disposeResponse);

        internal Task<T> SendFullUriAsync<T>(HttpMethod method, string? requestUri, string? queryString, HttpContent? content, string? methodName, string? resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>>? func, NonSuccessStatusCodeHandling nonSuccessStatusCodeHandling = NonSuccessStatusCodeHandling.Throw, bool disposeResponse = true) => SendFullUriAsync(new HttpRequestMessage(method, $"{requestUri}{queryString?.PrecedeWith("?")}") { Content = content }, methodName, resourceId, cancellationToken, func, nonSuccessStatusCodeHandling, disposeResponse);

        internal async Task<T> SendFullUriAsync<T>(HttpRequestMessage request, string? methodName, string? resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>>? func, NonSuccessStatusCodeHandling nonSuccessStatusCodeHandling = NonSuccessStatusCodeHandling.Throw, bool disposeResponse = true)
        {
            using (request)
            {
                var response = await GetHttpClient().SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                ApiResponse(response);
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        if (func != null)
                        {
                            return await func(response).ConfigureAwait(false);
                        }
                    }
                    else if (nonSuccessStatusCodeHandling == NonSuccessStatusCodeHandling.Throw || (nonSuccessStatusCodeHandling == NonSuccessStatusCodeHandling.ThrowOnNon404 && response.StatusCode != HttpStatusCode.NotFound))
                    {
                        throw await EncompassRestException.CreateAsync(CreateErrorMessage(methodName!, resourceId), response).ConfigureAwait(false);
                    }
                    return default!;
                }
                finally
                {
                    if (disposeResponse)
                    {
                        response.Dispose();
                    }
                }
            }
        }

        internal virtual string CreateErrorMessage(string methodName, string? resourceId = null) => $"{methodName}{resourceId?.PrecedeWith(": ")}";

        internal virtual HttpClient GetHttpClient() => Client.HttpClient;

        internal virtual string? BaseAddress => Client.BaseAddress;

        internal virtual void ApiResponse(HttpResponseMessage response)
        {
        }

        private string GetFullUri(string? requestUri)
        {
            var sb = new StringBuilder();
            sb.Append(BaseAddress);
            if (sb.Length > 0 && sb[sb.Length - 1] != '/')
            {
                sb.Append('/');
            }
            sb.Append(_baseApiPath);
            if (sb.Length > 0 && sb[sb.Length - 1] != '/' && requestUri?.Length > 0 && requestUri[0] != '/')
            {
                sb.Append('/');
            }
            sb.Append(requestUri);
            return sb.ToString();
        }

        internal static class FuncCache<T>
        {
            public static readonly Func<HttpResponseMessage, Task<T>> ReadAsFunc = response => response.Content.ReadAsAsync<T>();
        }

        internal static class DirtyFuncCache<T>
            where T : class, IDirty
        {
            public static readonly Func<HttpResponseMessage, Task<T>> ReadAsDirtyFunc = async response =>
            {
                var value = await response.Content.ReadAsAsync<T>().ConfigureAwait(false);
                value.Dirty = false;
                return value;
            };

            public static readonly Func<HttpResponseMessage, Task<List<T>>> ReadAsDirtyListFunc = async response =>
            {
                var list = await response.Content.ReadAsAsync<List<T>>().ConfigureAwait(false);
                foreach (var item in list)
                {
                    item.Dirty = false;
                }
                return list;
            };
        }

        internal enum NonSuccessStatusCodeHandling
        {
            Throw = 0,
            ThrowOnNon404 = 1,
            NoThrow = 2
        }
    }
}