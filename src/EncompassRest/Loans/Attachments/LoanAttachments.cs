using System.Collections.Generic;
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

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId) => GetAttachmentAsync(attachmentId, CancellationToken.None);

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAsync(attachmentId, null, nameof(GetAttachmentAsync), attachmentId, cancellationToken, async response =>
            {
                var attachment = await response.Content.ReadAsAsync<LoanAttachment>().ConfigureAwait(false);
                attachment.Dirty = false;
                return attachment;
            });
        }

        public Task<string> GetAttachmentRawAsync(string attachmentId) => GetAttachmentRawAsync(attachmentId, CancellationToken.None);

        public Task<string> GetAttachmentRawAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetRawAsync(attachmentId, null, nameof(GetAttachmentRawAsync), attachmentId, cancellationToken);
        }

        public Task<List<LoanAttachment>> GetAttachmentsAsync() => GetAttachmentsAsync(CancellationToken.None);

        public Task<List<LoanAttachment>> GetAttachmentsAsync(CancellationToken cancellationToken) => GetAsync(null, null, nameof(GetAttachmentsAsync), null, cancellationToken, async response =>
        {
            var attachments = await response.Content.ReadAsAsync<List<LoanAttachment>>().ConfigureAwait(false);
            foreach (var attachment in attachments)
            {
                attachment.Dirty = false;
            }
            return attachments;
        });

        public Task<string> GetAttachmentsRawAsync() => GetAttachmentsRawAsync(CancellationToken.None);

        public Task<string> GetAttachmentsRawAsync(CancellationToken cancellationToken) => GetRawAsync(null, null, nameof(GetAttachmentsRawAsync), null, cancellationToken);

        public Task<AttachmentUrl> GetAttachmentUrlAsync(string attachmentId) => GetAttachmentUrlAsync(attachmentId, CancellationToken.None);

        public Task<AttachmentUrl> GetAttachmentUrlAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAsync<AttachmentUrl>($"{attachmentId}/url", null, nameof(GetAttachmentUrlAsync), attachmentId, cancellationToken);
        }

        public Task<string> GetAttachmentUrlRawAsync(string attachmentId) => GetAttachmentUrlRawAsync(attachmentId, CancellationToken.None);

        public Task<string> GetAttachmentUrlRawAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetRawAsync($"{attachmentId}/url", null, nameof(GetAttachmentUrlRawAsync), attachmentId, cancellationToken);
        }

        public Task UpdateAttachmentAsync(LoanAttachment attachment) => UpdateAttachmentAsync(attachment, false, CancellationToken.None);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, CancellationToken cancellationToken) => UpdateAttachmentAsync(attachment, false, cancellationToken);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate) => UpdateAttachmentAsync(attachment, populate, CancellationToken.None);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(attachment, nameof(attachment));
            Preconditions.NotNullOrEmpty(attachment.AttachmentId, $"{nameof(attachment)}{nameof(attachment.AttachmentId)}");

            return PatchAsync(JsonStreamContent.Create(attachment), attachment.AttachmentId, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(UpdateAttachmentAsync), attachment.AttachmentId, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(attachment).ConfigureAwait(false);
                }
                attachment.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment) => UpdateAttachmentRawAsync(attachmentId, attachment, null, CancellationToken.None);

        public Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment, CancellationToken cancellationToken) => UpdateAttachmentRawAsync(attachmentId, attachment, null, cancellationToken);

        public Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment, string queryString) => UpdateAttachmentRawAsync(attachmentId, attachment, queryString, CancellationToken.None);

        public Task<string> UpdateAttachmentRawAsync(string attachmentId, string attachment, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return PatchRawAsync(new JsonStringContent(attachment), attachmentId, queryString, nameof(UpdateAttachmentRawAsync), attachmentId, cancellationToken);
        }
    }
}