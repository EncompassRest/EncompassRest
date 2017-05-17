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

        public async Task<LoanAttachment> GetAttachment(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachment), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<LoanAttachment>(json);
            }
        }

        public async Task<List<LoanAttachment>> GetAttachments()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/attachments"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachment), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<List<LoanAttachment>>(json);
            }
        }

        public async Task<string> GetAttachmentUrlAsync(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/{LoanId}/attachments/{attachmentId}/url", null))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentUrlAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
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

            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/attachments/{attachment.AttachmentId}", JsonContent.Create(attachment)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateAttachmentAsync), response);
                }
            }
        }
    }
}