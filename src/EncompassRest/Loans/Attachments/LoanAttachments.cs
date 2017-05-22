using System.Collections.Generic;
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

        public async Task<LoanAttachment> GetAttachmentAsync(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<LoanAttachment>(json);
            }
        }

        public async Task<List<LoanAttachment>> GetAttachmentsAsync()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<List<LoanAttachment>>(json);
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

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var attachmentUrl = JsonHelper.FromJson<AttachmentUrl>(json);
                return attachmentUrl.MediaUrl;
            }
        }

        private sealed class AttachmentUrl
        {
            public string MediaUrl { get; set; }
        }

        public async Task UpdateAttachmentAsync(LoanAttachment attachment)
        {
            Preconditions.NotNull(attachment, nameof(attachment));

            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/attachments/{attachment.AttachmentId}", JsonContent.Create(attachment)).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateAttachmentAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}