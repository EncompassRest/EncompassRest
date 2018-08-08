using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachments : LoanApiObject
    {
        internal LoanAttachments(EncompassRestClient client, string loanId)
            : base(client, loanId, "attachments")
        {
        }

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetDirtyAsync<LoanAttachment>(attachmentId, null, nameof(GetAttachmentAsync), attachmentId, cancellationToken);
        }

        public Task<string> GetAttachmentRawAsync(string attachmentId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetRawAsync(attachmentId, queryString, nameof(GetAttachmentRawAsync), attachmentId, cancellationToken);
        }

        public Task<List<LoanAttachment>> GetAttachmentsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanAttachment>(null, null, nameof(GetAttachmentsAsync), null, cancellationToken);

        public Task<string> GetAttachmentsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetAttachmentsRawAsync), null, cancellationToken);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, CancellationToken cancellationToken = default) => UpdateAttachmentAsync(attachment, false, cancellationToken);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachment, nameof(attachment));
            Preconditions.NotNullOrEmpty(attachment.AttachmentId, $"{nameof(attachment)}{nameof(attachment.AttachmentId)}");

            return PatchPopulateDirtyAsync(attachment.AttachmentId, JsonStreamContent.Create(attachment), nameof(UpdateAttachmentAsync), attachment.AttachmentId, attachment, populate, true, cancellationToken);
        }

        public Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return PatchRawAsync(attachmentId, queryString, new JsonStringContent(attachment), nameof(UpdateAttachmentRawAsync), attachmentId, cancellationToken);
        }

        public Task<string> UploadAttachmentAsync(LoanAttachment attachment, byte[] attachmentData, CancellationToken cancellationToken = default) => UploadAttachmentAsync(attachment, attachmentData, false, cancellationToken);

        public async Task<string> UploadAttachmentAsync(LoanAttachment attachment, byte[] attachmentData, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(populate ? ViewEntityQueryString : null, JsonStreamContent.Create(attachment), nameof(GetUploadAttachmentUrlAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriPopulateDirtyAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new ByteArrayContent(attachmentData), nameof(UploadAttachmentAsync), attachment, populate, cancellationToken).ConfigureAwait(false);
        }

        public Task<string> UploadAttachmentAsync(LoanAttachment attachment, Stream attachmentData, CancellationToken cancellationToken = default) => UploadAttachmentAsync(attachment, attachmentData, false, cancellationToken);

        public async Task<string> UploadAttachmentAsync(LoanAttachment attachment, Stream attachmentData, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(populate ? ViewEntityQueryString : null, JsonStreamContent.Create(attachment), nameof(GetUploadAttachmentUrlAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriPopulateDirtyAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new StreamContent(attachmentData), nameof(UploadAttachmentAsync), attachment, populate, cancellationToken).ConfigureAwait(false);
        }

        public async Task<string> UploadAttachmentRawAsync(string attachment, byte[] attachmentData, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(queryString, new JsonStringContent(attachment), nameof(GetUploadAttachmentUrlRawAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new ByteArrayContent(attachmentData), nameof(UploadAttachmentRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc).ConfigureAwait(false);
        }

        public async Task<string> UploadAttachmentRawAsync(string attachment, Stream attachmentData, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(queryString, new JsonStringContent(attachment), nameof(GetUploadAttachmentUrlRawAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new StreamContent(attachmentData), nameof(UploadAttachmentRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc).ConfigureAwait(false);
        }

        public async Task<byte[]> DownloadAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentUrlAsync(attachmentId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentAsync), attachmentId, cancellationToken, ReadAsByteArrayFunc).ConfigureAwait(false);
        }

        public async Task<Stream> DownloadAttachmentStreamAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentUrlAsync(attachmentId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentStreamAsync), attachmentId, cancellationToken, ReadAsStreamFunc, true, false).ConfigureAwait(false);
        }

        public async Task<byte[]> DownloadAttachmentPageAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsByteArrayFunc).ConfigureAwait(false);
        }

        public async Task<Stream> DownloadAttachmentPageStreamAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageStreamAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsStreamFunc, true, false).ConfigureAwait(false);
        }

        public async Task<byte[]> DownloadAttachmentPageThumbnailAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageThumbnailUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageThumbnailAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsByteArrayFunc).ConfigureAwait(false);
        }

        public async Task<Stream> DownloadAttachmentPageThumbnailStreamAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageThumbnailUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageThumbnailStreamAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsStreamFunc, true, false).ConfigureAwait(false);
        }

        public Task<MediaUrlObject> GetUploadAttachmentUrlAsync(LoanAttachment attachment, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachment, nameof(attachment));
            Preconditions.NullOrEmpty(attachment.AttachmentId, $"{nameof(attachment)}.{nameof(attachment.AttachmentId)}");

            return GetUploadAttachmentUrlInternalAsync(null, JsonStreamContent.Create(attachment), nameof(GetUploadAttachmentUrlAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc);
        }

        public Task<string> GetUploadAttachmentUrlRawAsync(string attachment, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return GetUploadAttachmentUrlInternalAsync(queryString, new JsonStringContent(attachment), nameof(GetUploadAttachmentUrlRawAsync), cancellationToken, ReadAsStringFunc);
        }

        private Task<T> GetUploadAttachmentUrlInternalAsync<T>(string queryString, HttpContent content, string methodName, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func) =>
            PostAsync("url", queryString, content, methodName, null, cancellationToken, func);

        public Task<MediaUrlObject> GetDownloadAttachmentUrlAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return PostAsync<MediaUrlObject>($"{attachmentId}/url", null, null, nameof(GetDownloadAttachmentUrlAsync), attachmentId, cancellationToken);
        }

        public Task<string> GetDownloadAttachmentUrlRawAsync(string attachmentId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return PostRawAsync($"{attachmentId}/url", queryString, null, nameof(GetDownloadAttachmentUrlRawAsync), attachmentId, cancellationToken);
        }

        public Task<MediaUrlObject> GetDownloadAttachmentPageUrlAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostAsync<MediaUrlObject>($"{attachmentId}/pages/{pageId}/url", null, null, nameof(GetDownloadAttachmentPageUrlAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        public Task<string> GetDownloadAttachmentPageUrlRawAsync(string attachmentId, string pageId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostRawAsync($"{attachmentId}/pages/{pageId}/url", queryString, null, nameof(GetDownloadAttachmentPageUrlRawAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        public Task<MediaUrlObject> GetDownloadAttachmentPageThumbnailUrlAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostAsync<MediaUrlObject>($"{attachmentId}/pages/{pageId}/thumbnail/url", null, null, nameof(GetDownloadAttachmentPageThumbnailUrlAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        public Task<string> GetDownloadAttachmentPageThumbnailUrlRawAsync(string attachmentId, string pageId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostRawAsync($"{attachmentId}/pages/{pageId}/thumbnail/url", queryString, null, nameof(GetDownloadAttachmentPageThumbnailUrlRawAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }
    }
}