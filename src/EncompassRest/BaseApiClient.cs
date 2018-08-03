using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public sealed class BaseApiClient : ApiObject
    {
        internal override string BaseAddress => null;

        public HttpClient HttpClient => Client.HttpClient;

        internal BaseApiClient(EncompassRestClient client)
            : base(client, null)
        {
        }

        public Task<TResponse> GetAsync<TResponse>(string uri, CancellationToken cancellationToken = default) => GetAsync<TResponse>(uri, null, nameof(GetAsync), null, cancellationToken);

        public Task<string> GetRawAsync(string uri, CancellationToken cancellationToken = default) => GetRawAsync(uri, null, nameof(GetRawAsync), null, cancellationToken);

        public Task PostAsync(string uri, object content, CancellationToken cancellationToken = default) => PostAsync<string>(uri, null, JsonStreamContent.Create(content), nameof(PostAsync), null, cancellationToken, null);

        public Task<TResponse> PostAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default) => PostAsync<TResponse>(uri, null, JsonStreamContent.Create(content), nameof(PostAsync), null, cancellationToken);

        public Task<string> PostRawAsync(string uri, string content, CancellationToken cancellationToken = default) => PostRawAsync(uri, null, new JsonStringContent(content), nameof(PostRawAsync), null, cancellationToken);

        public Task PatchAsync(string uri, object content, CancellationToken cancellationToken = default) => PatchAsync(uri, null, JsonStreamContent.Create(content), nameof(PatchAsync), null, cancellationToken);

        public Task<TResponse> PatchAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default) => PatchAsync(uri, null, JsonStreamContent.Create(content), nameof(PatchAsync), null, cancellationToken, FuncCache<TResponse>.ReadAsFunc);

        public Task<string> PatchRawAsync(string uri, string content, CancellationToken cancellationToken = default) => PatchRawAsync(uri, null, new JsonStringContent(content), nameof(PatchRawAsync), null, cancellationToken);

        public Task PutAsync(string uri, object content, CancellationToken cancellationToken = default) => PutAsync(uri, null, JsonStreamContent.Create(content), nameof(PutAsync), null, cancellationToken);

        public Task<TResponse> PutAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default) => PutAsync(uri, null, JsonStreamContent.Create(content), nameof(PutAsync), null, cancellationToken, FuncCache<TResponse>.ReadAsFunc);

        public Task<string> PutRawAsync(string uri, string content, CancellationToken cancellationToken = default) => PutRawAsync(uri, null, new JsonStringContent(content), nameof(PutRawAsync), null, cancellationToken);

        public Task<bool> DeleteAsync(string uri, CancellationToken cancellationToken = default) => DeleteAsync(uri, null, cancellationToken);
    }
}