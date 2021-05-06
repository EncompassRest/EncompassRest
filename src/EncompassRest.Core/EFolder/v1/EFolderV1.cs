using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.EFolder.v1
{
    /// <summary>
    /// The EFolder Apis.
    /// </summary>
    public interface IEFolderV1 : IApiObject
    {
        /// <summary>
        /// This API starts the export job. When attachments are exported, they are merged for download. Files of native and cloud types are supported with this API.
        /// </summary>
        /// <param name="parameters">The export attachments parameters.</param>
        /// <param name="options">The export attachments options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ExportAttachmentsJob> ExportAttachmentsAsync(ExportAttachmentsParameters parameters, ExportAttachmentsOptions? options = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// This API starts the export job from raw json. When attachments are exported, they are merged for download. Files of native and cloud types are supported with this API.
        /// </summary>
        /// <param name="parameters">The export attachments parameters as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ExportAttachmentsRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the status of the specified export job. If the job was a success, the URL to download the PDF document will be provided along with the status of the job.
        /// The authorizationHeader value that is returned as part of the response must be sent as a Request Header for the GET call with the URL when downloading the PDF file.
        /// </summary>
        /// <param name="jobId">Unique identifier of the export job.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ExportAttachmentsJob> GetExportStatusAsync(string jobId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the status of the specified export job as raw json. If the job was a success, the URL to download the PDF document will be provided along with the status of the job.
        /// The authorizationHeader value that is returned as part of the response must be sent as a Request Header for the GET call with the URL when downloading the PDF file.
        /// </summary>
        /// <param name="jobId">Unique identifier of the export job.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetExportStatusRawAsync(string jobId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachments for the specified export job as a pdf file byte array.
        /// </summary>
        /// <param name="job">The export job whose file entity uri and authorization header is populated.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> DownloadAttachmentsAsync(ExportAttachmentsJob job, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachments for the specified export job as a pdf file stream.
        /// </summary>
        /// <param name="job">The export job whose file entity uri and authorization header is populated.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> DownloadAttachmentsStreamAsync(ExportAttachmentsJob job, CancellationToken cancellationToken = default);
        /// <summary>
        /// Refreshes the specified export job's status.
        /// </summary>
        /// <param name="job">The export job to refresh.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task RefreshExportJobAsync(ExportAttachmentsJob job, CancellationToken cancellationToken = default);
    }

    internal sealed class EFolderV1 : ApiObject, IEFolderV1, IDisposable
    {
        private AttachmentJobApiObject? _attachmentJobApi;

        private AttachmentJobApiObject AttachmentJobApi
        {
            get
            {
                var attachmentJobApi = _attachmentJobApi;
                return attachmentJobApi ?? Interlocked.CompareExchange(ref _attachmentJobApi, attachmentJobApi = new AttachmentJobApiObject(Client), null) ?? attachmentJobApi;
            }
        }

        internal EFolderV1(EncompassRestClient client)
            : base(client, "efolder/v1/exportjobs")
        {
        }

        public async Task<ExportAttachmentsJob> ExportAttachmentsAsync(ExportAttachmentsParameters parameters, ExportAttachmentsOptions? options = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var job = await PostAsync<ExportAttachmentsJob>(null, options?.GetQueryParameters().ToString(), new JsonStreamContent(parameters), nameof(ExportAttachmentsAsync), null, cancellationToken).ConfigureAwait(false);
            job.Initialize(Client);
            return job;
        }

        public Task<string> ExportAttachmentsRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default) => PostRawAsync(null, queryString, new JsonStringContent(parameters), nameof(ExportAttachmentsRawAsync), null, cancellationToken);

        public async Task<ExportAttachmentsJob> GetExportStatusAsync(string jobId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(jobId, nameof(jobId));

            var job = await GetAsync<ExportAttachmentsJob>(jobId, null, nameof(GetExportStatusAsync), null, cancellationToken).ConfigureAwait(false);
            job.Initialize(Client);
            return job;
        }

        public Task<string> GetExportStatusRawAsync(string jobId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(jobId, nameof(jobId));

            return GetRawAsync(jobId, queryString, nameof(GetExportStatusRawAsync), jobId, cancellationToken);
        }

        public Task<byte[]> DownloadAttachmentsAsync(ExportAttachmentsJob job, CancellationToken cancellationToken = default) => DownloadAttachmentsInternalAsync(job, nameof(DownloadAttachmentsAsync), cancellationToken, ReadAsByteArrayFunc, disposeResponse: true);

        public Task<Stream> DownloadAttachmentsStreamAsync(ExportAttachmentsJob job, CancellationToken cancellationToken = default) => DownloadAttachmentsInternalAsync(job, nameof(DownloadAttachmentsStreamAsync), cancellationToken, ReadAsStreamFunc, disposeResponse: false);

        private Task<T> DownloadAttachmentsInternalAsync<T>(ExportAttachmentsJob job, string methodName, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func, bool disposeResponse)
        {
            Preconditions.NotNull(job, nameof(job));
            Preconditions.NotNullOrEmpty(job.JobId, nameof(job.JobId));

            if (string.IsNullOrEmpty(job.File.EntityUri))
            {
                if (job.Error != null)
                {
                    throw new InvalidOperationException($"Cannot download export job as there was the following error message: {job.Error.Summary}");
                }
                else
                {
                    throw new InvalidOperationException($"Status of retrieved job must be Success but is currently {job.Status}. Please try refreshing the job to see if it's ready to be downloaded.");
                }
            }

            return AttachmentJobApi.DownloadAttachmentsAsync(job, methodName, cancellationToken, func, disposeResponse);
        }

        public Task RefreshExportJobAsync(ExportAttachmentsJob job, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(job, nameof(job));
            Preconditions.NotNullOrEmpty(job.JobId, nameof(job.JobId));

            if (job.Client == null)
            {
                job.Initialize(Client);
            }
            return GetPopulateAsync(job.JobId, null, nameof(RefreshExportJobAsync), job.JobId, job, true, cancellationToken);
        }

        public void Dispose() => _attachmentJobApi?.Dispose();

        private sealed class AttachmentJobApiObject : ApiObject
        {
            private readonly HttpClient _httpClient;

            internal AttachmentJobApiObject(EncompassRestClient client)
                : base(client, null)
            {
                _httpClient = new HttpClient
                {
                    Timeout = Client.Timeout
                };
            }

            internal override string? BaseAddress => null;

            internal override HttpClient GetHttpClient() => _httpClient;

            internal override void ApiResponse(HttpResponseMessage response) => Client.InvokeApiResponse(response);

            internal Task<T> DownloadAttachmentsAsync<T>(ExportAttachmentsJob job, string methodName, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func, bool disposeResponse)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, job.File.EntityUri);
                request.Headers.Authorization = AuthenticationHeaderValue.Parse(job.File.AuthorizationHeader);
                return SendFullUriAsync(request, methodName, job.JobId, cancellationToken, func, disposeResponse: disposeResponse);
            }

            internal void Dispose() => _httpClient.Dispose();
        }
    }
}
