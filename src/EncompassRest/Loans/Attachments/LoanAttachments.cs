using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachments
    {
        private const string _apiPath = "encompass/v1/loans";

        public EncompassRestClient Client { get; }

        public string LoanId { get; }

        internal LoanAttachments(EncompassRestClient client, string loanId)
        {
            Client = client;
            LoanId = loanId;
        }

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId) => GetAttachmentAsync(attachmentId, CancellationToken.None);

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentInternalAsync(attachmentId, cancellationToken, response => response.Content.ReadAsAsync<LoanAttachment>());
        }

        public Task<string> GetAttachmentRawAsync(string attachmentId) => GetAttachmentRawAsync(attachmentId, CancellationToken.None);

        public Task<string> GetAttachmentRawAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentInternalAsync(attachmentId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetAttachmentInternalAsync<T>(string attachmentId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanAttachment>> GetAttachmentsAsync() => GetAttachmentsAsync(CancellationToken.None);

        public Task<List<LoanAttachment>> GetAttachmentsAsync(CancellationToken cancellationToken) => GetAttachmentsInternalAsync(cancellationToken, response => response.Content.ReadAsAsync<List<LoanAttachment>>());

        public Task<string> GetAttachmentsRawAsync() => GetAttachmentsRawAsync(CancellationToken.None);

        public Task<string> GetAttachmentsRawAsync(CancellationToken cancellationToken) => GetAttachmentsInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetAttachmentsInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> GetAttachmentUrlAsync(string attachmentId) => GetAttachmentUrlAsync(attachmentId, CancellationToken.None);

        //TODO: Add support for view query parameter, does this even make sense?
        public Task<string> GetAttachmentUrlAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentUrlInternalAsync(attachmentId, cancellationToken);
        }

        private async Task<string> GetAttachmentUrlInternalAsync(string attachmentId, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}/url", null, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentUrlAsync), response).ConfigureAwait(false);
                }

                var attachmentUrl = await response.Content.ReadAsAsync<AttachmentUrl>().ConfigureAwait(false);
                return attachmentUrl.MediaUrl;
            }
        }

        private sealed class AttachmentUrl
        {
            public string MediaUrl { get; set; }
        }

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate) => UpdateAttachmentAsync(attachment, populate, CancellationToken.None);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(attachment, nameof(attachment));

            return UpdateAttachmentInternalAsync(attachment.AttachmentId, JsonStreamContent.Create(attachment), populate ? new QueryParameters(new QueryParameter("view", "entity")) : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(attachment).ConfigureAwait(false);
                }
            });
        }

        public Task UpdateAttachmentRawAsync(string attachmentId, string attachment) => UpdateAttachmentRawAsync(attachmentId, attachment, CancellationToken.None);

        public Task UpdateAttachmentRawAsync(string attachmentId, string attachment, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return UpdateAttachmentInternalAsync(attachmentId, new JsonStringContent(attachment), null, cancellationToken);
        }

        private async Task UpdateAttachmentInternalAsync(string attachmentId, HttpContent content, QueryParameters queryParameters, CancellationToken cancellationToken, Func<HttpResponseMessage, Task> func = null)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}{queryParameters}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateAttachmentAsync), response).ConfigureAwait(false);
                }

                if (func != null)
                {
                    await func(response).ConfigureAwait(false);
                }
            }
        }
    }
}