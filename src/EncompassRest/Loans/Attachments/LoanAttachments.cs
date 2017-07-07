﻿using System;
using System.Collections.Generic;
using System.Net.Http;
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

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentInternalAsync(attachmentId, response => response.Content.ReadAsAsync<LoanAttachment>());
        }

        public Task<string> GetAttachmentRawAsync(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentInternalAsync(attachmentId, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetAttachmentInternalAsync<T>(string attachmentId, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanAttachment>> GetAttachmentsAsync() => GetAttachmentsInternalAsync(response => response.Content.ReadAsAsync<List<LoanAttachment>>());

        public Task<string> GetAttachmentsRawAsync() => GetAttachmentsInternalAsync(response => response.Content.ReadAsStringAsync());

        private async Task<T> GetAttachmentsInternalAsync<T>(Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public async Task<string> GetAttachmentUrlAsync(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}/url", null).ConfigureAwait(false))
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

        public Task UpdateAttachmentAsync(LoanAttachment attachment)
        {
            Preconditions.NotNull(attachment, nameof(attachment));

            return UpdateAttachmentInternalAsync(attachment.AttachmentId, JsonStreamContent.Create(attachment));
        }

        public Task UpdateAttachmentRawAsync(string attachmentId, string attachment)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return UpdateAttachmentInternalAsync(attachmentId, new JsonContent(attachment));
        }

        private async Task UpdateAttachmentInternalAsync(string attachmentId, HttpContent content)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateAttachmentAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}