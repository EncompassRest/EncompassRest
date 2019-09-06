using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// The Loan Attachments Apis.
    /// </summary>
    public interface ILoanAttachments : ILoanApiObject
    {
        /// <summary>
        /// Downloads the attachment's file contents as a byte array by first getting the download url and then getting the file contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> DownloadAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachment page's contents as a byte array by first getting the download url and then getting the page's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> DownloadAttachmentPageAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachment page's contents as a stream by first getting the download url and then getting the page's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> DownloadAttachmentPageStreamAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachment page's thumbnail image as a byte array by first getting the download url and then getting the thumbnail's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<byte[]> DownloadAttachmentPageThumbnailAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachment page's thumbnail image as a stream by first getting the download url and then getting the thumbnail's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> DownloadAttachmentPageThumbnailStreamAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Downloads the attachment's file contents as a stream by first getting the download url and then getting the file contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Stream> DownloadAttachmentStreamAsync(string attachmentId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/>.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanAttachment> GetAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/> and optionally generates the <see cref="LoanAttachment.MediaUrl"/> for use in downloading the attachment.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="generateUrl">When set to <c>true</c>, returns the mediaURL of the attachment in the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanAttachment> GetAttachmentAsync(string attachmentId, bool? generateUrl, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/> as raw json.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetAttachmentRawAsync(string attachmentId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of files attached to the loan. The response includes all properties for all assigned and unassigned file attachments.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanAttachment>> GetAttachmentsAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of files attached to the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetAttachmentsRawAsync(string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL of a thumbnail image for a specified page within an attachment.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<MediaUrlObject> GetDownloadAttachmentPageThumbnailUrlAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL of a thumbnail image for a specified page within an attachment as raw json.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetDownloadAttachmentPageThumbnailUrlRawAsync(string attachmentId, string pageId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL of a page within an attachment. This can be used for attachments with ids that are in GUID format.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<MediaUrlObject> GetDownloadAttachmentPageUrlAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL of a page within an attachment as raw json. This can be used for attachments with ids that are in GUID format.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetDownloadAttachmentPageUrlRawAsync(string attachmentId, string pageId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL for native attachment for a file in the eFolder. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder. This API supports attachment ids that are in the native format. E.g. Attachment-97f0f34d-7194-4e45-941f-e680dcea91c1.txt.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<MediaUrlObject> GetDownloadAttachmentUrlAsync(string attachmentId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL for native attachment for a file in the eFolder as raw json. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder. This API supports attachment ids that are in the native format. E.g. Attachment-97f0f34d-7194-4e45-941f-e680dcea91c1.txt.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetDownloadAttachmentUrlRawAsync(string attachmentId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL for uploading an attachment. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<MediaUrlObject> GetUploadAttachmentUrlAsync(LoanAttachment attachment, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the URL for uploading an attachment as raw json. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload as json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetUploadAttachmentUrlRawAsync(string attachment, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates properties for a specified file attachment.
        /// </summary>
        /// <param name="attachment">The attachment properties to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateAttachmentAsync(LoanAttachment attachment, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates properties for a specified file attachment and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="attachment">The attachment properties to update.</param>
        /// <param name="populate">Indicates if the attachment object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates properties for a specified file attachment from raw json.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="attachment">The attachment properties to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UploadAttachmentAsync(LoanAttachment attachment, byte[] attachmentData, CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UploadAttachmentAsync(LoanAttachment attachment, byte[] attachmentData, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        Task<string> UploadAttachmentAsync(LoanAttachment attachment, Stream attachmentData, CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UploadAttachmentAsync(LoanAttachment attachment, Stream attachmentData, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads the attachment and it's data to the loan from raw json and returns the response body if not empty else the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload as raw json.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UploadAttachmentRawAsync(string attachment, byte[] attachmentData, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads the attachment and it's data to the loan from raw json and returns the response body if not empty else the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload as raw json.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UploadAttachmentRawAsync(string attachment, Stream attachmentData, string queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Attachments Apis.
    /// </summary>
    public sealed class LoanAttachments : LoanApiObject, ILoanAttachments
    {
        internal LoanAttachments(EncompassRestClient client, string loanId)
            : base(client, loanId, "attachments")
        {
        }

        /// <summary>
        /// Retrieves a list of files attached to the loan. The response includes all properties for all assigned and unassigned file attachments.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<List<LoanAttachment>> GetAttachmentsAsync(CancellationToken cancellationToken = default)
        {
            var list = await GetDirtyListAsync<LoanAttachment>(null, null, nameof(GetAttachmentsAsync), null, cancellationToken).ConfigureAwait(false);
            foreach (var attachment in list)
            {
                attachment.Attachments = this;
            }
            return list;
        }

        /// <summary>
        /// Retrieves a list of files attached to the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetAttachmentsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetAttachmentsRawAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/>.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default) => GetAttachmentAsync(attachmentId, null, cancellationToken);

        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/> and optionally generates the <see cref="LoanAttachment.MediaUrl"/> for use in downloading the attachment.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="generateUrl">When set to <c>true</c>, returns the mediaURL of the attachment in the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<LoanAttachment> GetAttachmentAsync(string attachmentId, bool? generateUrl, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            var queryParameters = new QueryParameters();

            if (generateUrl.HasValue)
            {
                queryParameters.Add("generateURL", generateUrl.ToString().ToLower());
            }

            var attachment = await GetDirtyAsync<LoanAttachment>(attachmentId, queryParameters.ToString(), nameof(GetAttachmentAsync), attachmentId, cancellationToken).ConfigureAwait(false);
            attachment.Attachments = this;
            return attachment;
        }

        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/> as raw json.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetAttachmentRawAsync(string attachmentId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetRawAsync(attachmentId, queryString, nameof(GetAttachmentRawAsync), attachmentId, cancellationToken);
        }

        /// <summary>
        /// Retrieves the URL for uploading an attachment. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<MediaUrlObject> GetUploadAttachmentUrlAsync(LoanAttachment attachment, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachment, nameof(attachment));
            Preconditions.NullOrEmpty(attachment.AttachmentId, $"{nameof(attachment)}.{nameof(attachment.AttachmentId)}");

            return GetUploadAttachmentUrlInternalAsync(null, JsonStreamContent.Create(attachment), nameof(GetUploadAttachmentUrlAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc);
        }

        /// <summary>
        /// Retrieves the URL for uploading an attachment as raw json. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload as json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetUploadAttachmentUrlRawAsync(string attachment, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return GetUploadAttachmentUrlInternalAsync(queryString, new JsonStringContent(attachment), nameof(GetUploadAttachmentUrlRawAsync), cancellationToken, ReadAsStringFunc);
        }

        private Task<T> GetUploadAttachmentUrlInternalAsync<T>(string queryString, HttpContent content, string methodName, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func) =>
            PostAsync("url", queryString, content, methodName, null, cancellationToken, func);

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UploadAttachmentAsync(LoanAttachment attachment, byte[] attachmentData, CancellationToken cancellationToken = default) => UploadAttachmentAsync(attachment, attachmentData, false, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<string> UploadAttachmentAsync(LoanAttachment attachment, byte[] attachmentData, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            attachment.Attachments = this;
            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(populate ? ViewEntityQueryString : null, JsonStreamContent.Create(attachment), nameof(GetUploadAttachmentUrlAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriPopulateDirtyAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new ByteArrayContent(attachmentData), nameof(UploadAttachmentAsync), attachment, populate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        public Task<string> UploadAttachmentAsync(LoanAttachment attachment, Stream attachmentData, CancellationToken cancellationToken = default) => UploadAttachmentAsync(attachment, attachmentData, false, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<string> UploadAttachmentAsync(LoanAttachment attachment, Stream attachmentData, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            attachment.Attachments = this;
            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(populate ? ViewEntityQueryString : null, JsonStreamContent.Create(attachment), nameof(GetUploadAttachmentUrlAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriPopulateDirtyAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new StreamContent(attachmentData), nameof(UploadAttachmentAsync), attachment, populate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads the attachment and it's data to the loan from raw json and returns the response body if not empty else the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload as raw json.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<string> UploadAttachmentRawAsync(string attachment, byte[] attachmentData, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(queryString, new JsonStringContent(attachment), nameof(GetUploadAttachmentUrlRawAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new ByteArrayContent(attachmentData), nameof(UploadAttachmentRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads the attachment and it's data to the loan from raw json and returns the response body if not empty else the uploaded attachment's id.
        /// </summary>
        /// <param name="attachment">The attachment properties to upload as raw json.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<string> UploadAttachmentRawAsync(string attachment, Stream attachmentData, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));
            Preconditions.NotNull(attachmentData, nameof(attachmentData));

            var mediaUrlObject = await GetUploadAttachmentUrlInternalAsync(queryString, new JsonStringContent(attachment), nameof(GetUploadAttachmentUrlRawAsync), cancellationToken, FuncCache<MediaUrlObject>.ReadAsFunc).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Put, mediaUrlObject.MediaUrl, null, new StreamContent(attachmentData), nameof(UploadAttachmentRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the URL for native attachment for a file in the eFolder. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder. This API supports attachment ids that are in the native format. E.g. Attachment-97f0f34d-7194-4e45-941f-e680dcea91c1.txt.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<MediaUrlObject> GetDownloadAttachmentUrlAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return PostAsync<MediaUrlObject>($"{attachmentId}/url", null, null, nameof(GetDownloadAttachmentUrlAsync), attachmentId, cancellationToken);
        }

        /// <summary>
        /// Retrieves the URL for native attachment for a file in the eFolder as raw json. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder. This API supports attachment ids that are in the native format. E.g. Attachment-97f0f34d-7194-4e45-941f-e680dcea91c1.txt.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetDownloadAttachmentUrlRawAsync(string attachmentId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return PostRawAsync($"{attachmentId}/url", queryString, null, nameof(GetDownloadAttachmentUrlRawAsync), attachmentId, cancellationToken);
        }

        /// <summary>
        /// Downloads the attachment's file contents as a byte array by first getting the download url and then getting the file contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<byte[]> DownloadAttachmentAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentUrlAsync(attachmentId, cancellationToken).ConfigureAwait(false);

            return await DownloadAttachmentFromMediaUrlAsync(mediaUrlObject.MediaUrl, cancellationToken).ConfigureAwait(false);
        }

        internal Task<byte[]> DownloadAttachmentFromMediaUrlAsync(string mediaUrl, CancellationToken cancellationToken = default) => SendFullUriAsync(HttpMethod.Get, mediaUrl, null, null, nameof(DownloadAttachmentAsync), null, cancellationToken, ReadAsByteArrayFunc);

        /// <summary>
        /// Downloads the attachment's file contents as a stream by first getting the download url and then getting the file contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<Stream> DownloadAttachmentStreamAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentUrlAsync(attachmentId, cancellationToken).ConfigureAwait(false);

            return await DownloadAttachmentStreamFromMediaUrlAsync(mediaUrlObject.MediaUrl, cancellationToken).ConfigureAwait(false);
        }

        internal Task<Stream> DownloadAttachmentStreamFromMediaUrlAsync(string mediaUrl, CancellationToken cancellationToken = default) => SendFullUriAsync(HttpMethod.Get, mediaUrl, null, null, nameof(DownloadAttachmentStreamAsync), null, cancellationToken, ReadAsStreamFunc, true, false);

        /// <summary>
        /// Retrieves the URL of a thumbnail image for a specified page within an attachment.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<MediaUrlObject> GetDownloadAttachmentPageThumbnailUrlAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostAsync<MediaUrlObject>($"{attachmentId}/pages/{pageId}/thumbnail/url", null, null, nameof(GetDownloadAttachmentPageThumbnailUrlAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        /// <summary>
        /// Retrieves the URL of a thumbnail image for a specified page within an attachment as raw json.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetDownloadAttachmentPageThumbnailUrlRawAsync(string attachmentId, string pageId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostRawAsync($"{attachmentId}/pages/{pageId}/thumbnail/url", queryString, null, nameof(GetDownloadAttachmentPageThumbnailUrlRawAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        /// <summary>
        /// Downloads the attachment page's thumbnail image as a byte array by first getting the download url and then getting the thumbnail's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<byte[]> DownloadAttachmentPageThumbnailAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageThumbnailUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageThumbnailAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsByteArrayFunc).ConfigureAwait(false);
        }

        /// <summary>
        /// Downloads the attachment page's thumbnail image as a stream by first getting the download url and then getting the thumbnail's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<Stream> DownloadAttachmentPageThumbnailStreamAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageThumbnailUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageThumbnailStreamAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsStreamFunc, true, false).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the URL of a page within an attachment. This can be used for attachments with ids that are in GUID format.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<MediaUrlObject> GetDownloadAttachmentPageUrlAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostAsync<MediaUrlObject>($"{attachmentId}/pages/{pageId}/url", null, null, nameof(GetDownloadAttachmentPageUrlAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        /// <summary>
        /// Retrieves the URL of a page within an attachment as raw json. This can be used for attachments with ids that are in GUID format.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetDownloadAttachmentPageUrlRawAsync(string attachmentId, string pageId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(pageId, nameof(pageId));

            return PostRawAsync($"{attachmentId}/pages/{pageId}/url", queryString, null, nameof(GetDownloadAttachmentPageUrlRawAsync), $"{attachmentId}/{pageId}", cancellationToken);
        }

        /// <summary>
        /// Downloads the attachment page's contents as a byte array by first getting the download url and then getting the page's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<byte[]> DownloadAttachmentPageAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsByteArrayFunc).ConfigureAwait(false);
        }

        /// <summary>
        /// Downloads the attachment page's contents as a stream by first getting the download url and then getting the page's contents.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<Stream> DownloadAttachmentPageStreamAsync(string attachmentId, string pageId, CancellationToken cancellationToken = default)
        {
            var mediaUrlObject = await GetDownloadAttachmentPageUrlAsync(attachmentId, pageId, cancellationToken).ConfigureAwait(false);

            return await SendFullUriAsync(HttpMethod.Get, mediaUrlObject.MediaUrl, null, null, nameof(DownloadAttachmentPageStreamAsync), $"{attachmentId}/{pageId}", cancellationToken, ReadAsStreamFunc, true, false).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates properties for a specified file attachment.
        /// </summary>
        /// <param name="attachment">The attachment properties to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateAttachmentAsync(LoanAttachment attachment, CancellationToken cancellationToken = default) => UpdateAttachmentAsync(attachment, false, cancellationToken);

        /// <summary>
        /// Updates properties for a specified file attachment and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="attachment">The attachment properties to update.</param>
        /// <param name="populate">Indicates if the attachment object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(attachment, nameof(attachment));
            Preconditions.NotNullOrEmpty(attachment.AttachmentId, $"{nameof(attachment)}{nameof(attachment.AttachmentId)}");

            attachment.Attachments = this;
            return PatchPopulateDirtyAsync(attachment.AttachmentId, JsonStreamContent.Create(attachment), nameof(UpdateAttachmentAsync), attachment.AttachmentId, attachment, populate, cancellationToken);
        }

        /// <summary>
        /// Updates properties for a specified file attachment from raw json.
        /// </summary>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="attachment">The attachment properties to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return PatchRawAsync(attachmentId, queryString, new JsonStringContent(attachment), nameof(UpdateAttachmentRawAsync), attachmentId, cancellationToken);
        }
    }
}