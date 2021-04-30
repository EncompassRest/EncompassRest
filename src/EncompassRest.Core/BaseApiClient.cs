using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// A base Api client for use when Apis aren't supported directly.
    /// </summary>
    public interface IBaseApiClient : IApiObject
    {
        /// <summary>
        /// The internal <see cref="System.Net.Http.HttpClient"/> used by the client.
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        /// Sends an HTTP DELETE request to the specified <paramref name="uri"/> and returns whether the response had a success status code.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteAsync(string uri, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP DELETE request to the specified <paramref name="uri"/> and returns whether the response had a success status code.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteAsync(string uri, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP GET request to the specified <paramref name="uri"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The anonymous type to return. This can't be specified traditionally and must be inferred from the anonymous type passed as a parameter.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="anonymousTypeObject">The anonymous type object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> GetAnonymousTypeAsync<TResponse>(string uri, TResponse anonymousTypeObject, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP GET request to the specified <paramref name="uri"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> GetAsync<TResponse>(string uri, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP GET request to the specified <paramref name="uri"/> and returns the response body as raw json.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRawAsync(string uri, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PATCH request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The anonymous type to return. This can't be specified traditionally and must be inferred from the anonymous type passed as a parameter.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="anonymousTypeObject">The anonymous type object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> PatchAnonymousTypeAsync<TResponse>(string uri, object content, TResponse anonymousTypeObject, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PATCH request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/>.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task PatchAsync(string uri, object content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PATCH request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> PatchAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PATCH request to the specified <paramref name="uri"/> with the raw json <paramref name="content"/> and returns the response body as raw json.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> PatchRawAsync(string uri, string content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP POST request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The anonymous type to return. This can't be specified traditionally and must be inferred from the anonymous type passed as a parameter.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="anonymousTypeObject">The anonymous type object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> PostAnonymousTypeAsync<TResponse>(string uri, object content, TResponse anonymousTypeObject, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP POST request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/>.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task PostAsync(string uri, object content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP POST request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> PostAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP POST request to the specified <paramref name="uri"/> with the raw json <paramref name="content"/> and returns the response body as raw json.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> PostRawAsync(string uri, string content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PUT request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The anonymous type to return. This can't be specified traditionally and must be inferred from the anonymous type passed as a parameter.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="anonymousTypeObject">The anonymous type object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> PutAnonymousTypeAsync<TResponse>(string uri, object content, TResponse anonymousTypeObject, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PUT request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/>.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task PutAsync(string uri, object content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PUT request to the specified <paramref name="uri"/> with the specified json serializable <paramref name="content"/> and returns the response body as a <typeparamref name="TResponse"/>.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The json serializable content to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TResponse> PutAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default);
        /// <summary>
        /// Sends an HTTP PUT request to the specified <paramref name="uri"/> with the raw json <paramref name="content"/> and returns the response body as raw json.
        /// </summary>
        /// <param name="uri">The request uri including any query parameters.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> PutRawAsync(string uri, string content, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// A base Api client for use when Apis aren't supported directly.
    /// </summary>
    public sealed class BaseApiClient : ApiObject, IBaseApiClient
    {
        internal override string? BaseAddress => null;

        /// <inheritdoc/>
        public HttpClient HttpClient => Client.HttpClient;

        internal BaseApiClient(EncompassRestClient client)
            : base(client, null)
        {
        }

        /// <inheritdoc/>
        public Task<TResponse> GetAsync<TResponse>(string uri, CancellationToken cancellationToken = default) => GetAsync<TResponse>(uri, null, nameof(GetAsync), null, cancellationToken);


        /// <inheritdoc/>
#pragma warning disable IDE0060 // Remove unused parameter
        public Task<TResponse> GetAnonymousTypeAsync<TResponse>(string uri, TResponse anonymousTypeObject, CancellationToken cancellationToken = default) => GetAsync<TResponse>(uri, null, nameof(GetAnonymousTypeAsync), null, cancellationToken);
#pragma warning restore IDE0060 // Remove unused parameter

        /// <inheritdoc/>
        public Task<string> GetRawAsync(string uri, CancellationToken cancellationToken = default) => GetRawAsync(uri, null, nameof(GetRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task PostAsync(string uri, object content, CancellationToken cancellationToken = default) => PostAsync<string>(uri, null, JsonStreamContent.Create(content), nameof(PostAsync), null, cancellationToken, null);

        /// <inheritdoc/>
        public Task<TResponse> PostAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default) => PostAsync<TResponse>(uri, null, JsonStreamContent.Create(content), nameof(PostAsync), null, cancellationToken);

        /// <inheritdoc/>
#pragma warning disable IDE0060 // Remove unused parameter
        public Task<TResponse> PostAnonymousTypeAsync<TResponse>(string uri, object content, TResponse anonymousTypeObject, CancellationToken cancellationToken = default) => PostAsync<TResponse>(uri, null, JsonStreamContent.Create(content), nameof(PostAnonymousTypeAsync), null, cancellationToken);
#pragma warning restore IDE0060 // Remove unused parameter

        /// <inheritdoc/>
        public Task<string> PostRawAsync(string uri, string content, CancellationToken cancellationToken = default) => PostRawAsync(uri, null, new JsonStringContent(content), nameof(PostRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task PatchAsync(string uri, object content, CancellationToken cancellationToken = default) => PatchAsync(uri, null, JsonStreamContent.Create(content), nameof(PatchAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<TResponse> PatchAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default) => PatchAsync(uri, null, JsonStreamContent.Create(content), nameof(PatchAsync), null, cancellationToken, FuncCache<TResponse>.ReadAsFunc);

        /// <inheritdoc/>
#pragma warning disable IDE0060 // Remove unused parameter
        public Task<TResponse> PatchAnonymousTypeAsync<TResponse>(string uri, object content, TResponse anonymousTypeObject, CancellationToken cancellationToken = default) => PatchAsync(uri, null, JsonStreamContent.Create(content), nameof(PatchAnonymousTypeAsync), null, cancellationToken, FuncCache<TResponse>.ReadAsFunc);
#pragma warning restore IDE0060 // Remove unused parameter

        /// <inheritdoc/>
        public Task<string> PatchRawAsync(string uri, string content, CancellationToken cancellationToken = default) => PatchRawAsync(uri, null, new JsonStringContent(content), nameof(PatchRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task PutAsync(string uri, object content, CancellationToken cancellationToken = default) => PutAsync(uri, null, JsonStreamContent.Create(content), nameof(PutAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<TResponse> PutAsync<TResponse>(string uri, object content, CancellationToken cancellationToken = default) => PutAsync(uri, null, JsonStreamContent.Create(content), nameof(PutAsync), null, cancellationToken, FuncCache<TResponse>.ReadAsFunc);

        /// <inheritdoc/>
#pragma warning disable IDE0060 // Remove unused parameter
        public Task<TResponse> PutAnonymousTypeAsync<TResponse>(string uri, object content, TResponse anonymousTypeObject, CancellationToken cancellationToken = default) => PutAsync(uri, null, JsonStreamContent.Create(content), nameof(PutAnonymousTypeAsync), null, cancellationToken, FuncCache<TResponse>.ReadAsFunc);
#pragma warning restore IDE0060 // Remove unused parameter

        /// <inheritdoc/>
        public Task<string> PutRawAsync(string uri, string content, CancellationToken cancellationToken = default) => PutRawAsync(uri, null, new JsonStringContent(content), nameof(PutRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<bool> TryDeleteAsync(string uri, CancellationToken cancellationToken = default) => TryDeleteAsync(uri, null, cancellationToken);

        /// <inheritdoc/>
        public Task DeleteAsync(string uri, CancellationToken cancellationToken = default) => DeleteAsync(uri, null, cancellationToken);
    }
}