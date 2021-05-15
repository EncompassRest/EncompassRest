using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.EFolder.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Attachments.v1
{
    /// <summary>
    /// The Loan Attachments Api extension methods.
    /// </summary>
    public static class LoanAttachmentsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanAttachmentsV1? V1 { get; set; }

        private static ILoanAttachmentsV1 GetV1(ILoanAttachments loanAttachments)
        {
            var v1 = V1;
            if (loanAttachments is LoanAttachments a)
            {
                v1 = a.ExtensionData.GetOrAdd(() => new LoanAttachmentsV1(a.Client, a.LoanApis, a.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanAttachments, nameof(loanAttachments));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Downloads the attachment's file contents as a byte array by first getting the download url and then getting the file contents.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> DownloadAttachmentAsync(this ILoanAttachments loanAttachments, string attachmentId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentAsync(attachmentId, cancellationToken);

        /// <summary>
        /// Downloads the attachment page's contents as a byte array by first getting the download url and then getting the page's contents.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> DownloadAttachmentPageAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentPageAsync(attachmentId, pageId, cancellationToken);

        /// <summary>
        /// Downloads the attachment page's contents as a stream by first getting the download url and then getting the page's contents.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> DownloadAttachmentPageStreamAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentPageStreamAsync(attachmentId, pageId, cancellationToken);

        /// <summary>
        /// Downloads the attachment page's thumbnail image as a byte array by first getting the download url and then getting the thumbnail's contents.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> DownloadAttachmentPageThumbnailAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentPageThumbnailAsync(attachmentId, pageId, cancellationToken);

        /// <summary>
        /// Downloads the attachment page's thumbnail image as a stream by first getting the download url and then getting the thumbnail's contents.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> DownloadAttachmentPageThumbnailStreamAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentPageThumbnailStreamAsync(attachmentId, pageId, cancellationToken);

        /// <summary>
        /// Downloads the attachment's file contents as a stream by first getting the download url and then getting the file contents.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> DownloadAttachmentStreamAsync(this ILoanAttachments loanAttachments, string attachmentId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentStreamAsync(attachmentId, cancellationToken);

        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/>.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanAttachment> GetAttachmentAsync(this ILoanAttachments loanAttachments, string attachmentId, CancellationToken cancellationToken = default) => GetAttachmentAsync(loanAttachments, attachmentId, generateUrl: null, cancellationToken);

        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/> and optionally generates the <see cref="LoanAttachment.MediaUrl"/> for use in downloading the attachment.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="generateUrl">When set to <c>true</c>, returns the mediaURL of the attachment in the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanAttachment> GetAttachmentAsync(this ILoanAttachments loanAttachments, string attachmentId, bool? generateUrl, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetAttachmentAsync(attachmentId, generateUrl, cancellationToken);

        /// <summary>
        /// Retrieves properties for the file attachment with the specified <paramref name="attachmentId"/> as raw json.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetAttachmentRawAsync(this ILoanAttachments loanAttachments, string attachmentId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetAttachmentRawAsync(attachmentId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves a list of files attached to the loan. The response includes all properties for all assigned and unassigned file attachments.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanAttachment>> GetAttachmentsAsync(this ILoanAttachments loanAttachments, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetAttachmentsAsync(cancellationToken);

        /// <summary>
        /// Retrieves a list of files attached to the loan as raw json.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetAttachmentsRawAsync(this ILoanAttachments loanAttachments, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetAttachmentsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Retrieves the URL of a thumbnail image for a specified page within an attachment.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<MediaUrlObject> GetDownloadAttachmentPageThumbnailUrlAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetDownloadAttachmentPageThumbnailUrlAsync(attachmentId, pageId, cancellationToken);

        /// <summary>
        /// Retrieves the URL of a thumbnail image for a specified page within an attachment as raw json.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDownloadAttachmentPageThumbnailUrlRawAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetDownloadAttachmentPageThumbnailUrlRawAsync(attachmentId, pageId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves the URL of a page within an attachment. This can be used for attachments with ids that are in GUID format.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<MediaUrlObject> GetDownloadAttachmentPageUrlAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetDownloadAttachmentPageUrlAsync(attachmentId, pageId, cancellationToken);

        /// <summary>
        /// Retrieves the URL of a page within an attachment as raw json. This can be used for attachments with ids that are in GUID format.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment post Conversion. Accepted attachmentId is in the form of "99505941-3024-4b6f-972b-dad936fddbd0". Native attachmentID will not be accepted for this API.</param>
        /// <param name="pageId">Unique identifier assigned to the page within the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDownloadAttachmentPageUrlRawAsync(this ILoanAttachments loanAttachments, string attachmentId, string pageId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetDownloadAttachmentPageUrlRawAsync(attachmentId, pageId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves the URL for native attachment for a file in the eFolder. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder. This API supports attachment ids that are in the native format. E.g. Attachment-97f0f34d-7194-4e45-941f-e680dcea91c1.txt.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<MediaUrlObject> GetDownloadAttachmentUrlAsync(this ILoanAttachments loanAttachments, string attachmentId, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetDownloadAttachmentUrlAsync(attachmentId, cancellationToken);

        /// <summary>
        /// Retrieves the URL for native attachment for a file in the eFolder as raw json. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder. This API supports attachment ids that are in the native format. E.g. Attachment-97f0f34d-7194-4e45-941f-e680dcea91c1.txt.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDownloadAttachmentUrlRawAsync(this ILoanAttachments loanAttachments, string attachmentId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetDownloadAttachmentUrlRawAsync(attachmentId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves the URL for uploading an attachment. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<MediaUrlObject> GetUploadAttachmentUrlAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetUploadAttachmentUrlAsync(attachment, cancellationToken);

        /// <summary>
        /// Retrieves the URL for uploading an attachment as raw json. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload as json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetUploadAttachmentUrlRawAsync(this ILoanAttachments loanAttachments, string attachment, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).GetUploadAttachmentUrlRawAsync(attachment, queryString, cancellationToken);

        /// <summary>
        /// Updates properties for a specified file attachment.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateAttachmentAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, CancellationToken cancellationToken = default) => UpdateAttachmentAsync(loanAttachments, attachment, populate: false, cancellationToken);

        /// <summary>
        /// Updates properties for a specified file attachment and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to update.</param>
        /// <param name="populate">Indicates if the attachment object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateAttachmentAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, bool populate, CancellationToken cancellationToken = default) => GetV1(loanAttachments).UpdateAttachmentAsync(attachment, populate, cancellationToken);

        /// <summary>
        /// Updates properties for a specified file attachment from raw json.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachmentId">Unique identifier assigned to the attachment.</param>
        /// <param name="attachment">The attachment properties to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateAttachmentRawAsync(this ILoanAttachments loanAttachments, string attachmentId, string attachment, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).UpdateAttachmentRawAsync(attachmentId, attachment, queryString, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UploadAttachmentAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, byte[] attachmentData, CancellationToken cancellationToken = default) => UploadAttachmentAsync(loanAttachments, attachment, attachmentData, populate: false, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UploadAttachmentAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, byte[] attachmentData, bool populate, CancellationToken cancellationToken = default) => GetV1(loanAttachments).UploadAttachmentAsync(attachment, attachmentData, populate, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        public static Task<string> UploadAttachmentAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, Stream attachmentData, CancellationToken cancellationToken = default) => UploadAttachmentAsync(loanAttachments, attachment, attachmentData, populate: false, cancellationToken);
        /// <summary>
        /// Uploads the attachment and it's data to the loan and returns the uploaded attachment's id and optionally populates the attachment object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UploadAttachmentAsync(this ILoanAttachments loanAttachments, LoanAttachment attachment, Stream attachmentData, bool populate, CancellationToken cancellationToken = default) => GetV1(loanAttachments).UploadAttachmentAsync(attachment, attachmentData, populate, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan from raw json and returns the response body if not empty else the uploaded attachment's id.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload as raw json.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UploadAttachmentRawAsync(this ILoanAttachments loanAttachments, string attachment, byte[] attachmentData, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).UploadAttachmentRawAsync(attachment, attachmentData, queryString, cancellationToken);

        /// <summary>
        /// Uploads the attachment and it's data to the loan from raw json and returns the response body if not empty else the uploaded attachment's id.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="attachment">The attachment properties to upload as raw json.</param>
        /// <param name="attachmentData">The attachment data to upload.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UploadAttachmentRawAsync(this ILoanAttachments loanAttachments, string attachment, Stream attachmentData, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).UploadAttachmentRawAsync(attachment, attachmentData, queryString, cancellationToken);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Task<byte[]> DownloadAttachmentFromMediaUrlAsync(this ILoanAttachments loanAttachments, string mediaUrl, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentFromMediaUrlAsync(mediaUrl, cancellationToken);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Task<Stream> DownloadAttachmentStreamFromMediaUrlAsync(this ILoanAttachments loanAttachments, string mediaUrl, CancellationToken cancellationToken = default) => GetV1(loanAttachments).DownloadAttachmentStreamFromMediaUrlAsync(mediaUrl, cancellationToken);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// This API starts the export job. When attachments are exported, they are merged for download. Files of native and cloud types are supported with this API.
        /// </summary>
        /// <param name="loanAttachments">The Loan Attachments Api Object.</param>
        /// <param name="entities">The attachment entities to export.</param>
        /// <param name="annotationSettings">The export annotation settings.</param>
        /// <param name="options">The export attachments options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ExportAttachmentsJob> ExportAttachmentsAsync(this ILoanAttachments loanAttachments, IEnumerable<EntityReference> entities, AnnotationSettings? annotationSettings = null, ExportAttachmentsOptions? options = null, CancellationToken cancellationToken = default) => GetV1(loanAttachments).ExportAttachmentsAsync(entities, annotationSettings, options, cancellationToken);
    }
}