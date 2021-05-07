using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.EFolder.v1
{
    public static class EFolderExtensions
    {
        public static IEFolderV1? V1 { get; set; }

        private static IEFolderV1 GetV1(IEFolder eFolder)
        {
            var v1 = V1;
            if (eFolder is EFolder f)
            {
                v1 = (IEFolderV1)f.ExtensionData.GetOrAdd("v1", k => new EFolderV1(f.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(eFolder, nameof(eFolder));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// This API starts the export job. When attachments are exported, they are merged for download. Files of native and cloud types are supported with this API.
        /// </summary>
        /// <param name="parameters">The export attachments parameters.</param>
        /// <param name="options">The export attachments options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ExportAttachmentsJob> ExportAttachmentsAsync(this IEFolder eFolder, ExportAttachmentsParameters parameters, ExportAttachmentsOptions? options = null, CancellationToken cancellationToken = default) => GetV1(eFolder).ExportAttachmentsAsync(parameters, options, cancellationToken);

        /// <summary>
        /// This API starts the export job from raw json. When attachments are exported, they are merged for download. Files of native and cloud types are supported with this API.
        /// </summary>
        /// <param name="parameters">The export attachments parameters as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ExportAttachmentsRawAsync(this IEFolder eFolder, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(eFolder).ExportAttachmentsRawAsync(parameters, queryString, cancellationToken);

        /// <summary>
        /// Returns the status of the specified export job. If the job was a success, the URL to download the PDF document will be provided along with the status of the job.
        /// The authorizationHeader value that is returned as part of the response must be sent as a Request Header for the GET call with the URL when downloading the PDF file.
        /// </summary>
        /// <param name="jobId">Unique identifier of the export job.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ExportAttachmentsJob> GetExportStatusAsync(this IEFolder eFolder, string jobId, CancellationToken cancellationToken = default) => GetV1(eFolder).GetExportStatusAsync(jobId, cancellationToken);

        /// <summary>
        /// Returns the status of the specified export job as raw json. If the job was a success, the URL to download the PDF document will be provided along with the status of the job.
        /// The authorizationHeader value that is returned as part of the response must be sent as a Request Header for the GET call with the URL when downloading the PDF file.
        /// </summary>
        /// <param name="jobId">Unique identifier of the export job.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetExportStatusRawAsync(this IEFolder eFolder, string jobId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(eFolder).GetExportStatusRawAsync(jobId, queryString, cancellationToken);

        /// <summary>
        /// Downloads the attachments for the specified export job as a pdf file byte array.
        /// </summary>
        /// <param name="job">The export job whose file entity uri and authorization header is populated.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> DownloadAttachmentsAsync(this IEFolder eFolder, ExportAttachmentsJob job, CancellationToken cancellationToken = default) => GetV1(eFolder).DownloadAttachmentsAsync(job, cancellationToken);

        /// <summary>
        /// Downloads the attachments for the specified export job as a pdf file stream.
        /// </summary>
        /// <param name="job">The export job whose file entity uri and authorization header is populated.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> DownloadAttachmentsStreamAsync(this IEFolder eFolder, ExportAttachmentsJob job, CancellationToken cancellationToken = default) => GetV1(eFolder).DownloadAttachmentsStreamAsync(job, cancellationToken);

        /// <summary>
        /// Refreshes the specified export job's status.
        /// </summary>
        /// <param name="job">The export job to refresh.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task RefreshExportJobAsync(this IEFolder eFolder, ExportAttachmentsJob job, CancellationToken cancellationToken = default) => GetV1(eFolder).RefreshExportJobAsync(job, cancellationToken);
    }
}
