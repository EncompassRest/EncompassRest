using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    // Placeholders to be replaced later with actual implementations
    public class EntityReference { }
    public class FileAttachmentReference { }

    public partial class Loan
    {
        [JsonIgnore]
        public LoanDocuments Documents { get; }

        [JsonIgnore]
        public LoanAttachments Attachments { get; }

        [JsonIgnore]
        public EncompassRestClient Client { get; }

        public Loan()
        {
        }

        public Loan(EncompassRestClient client, string loanId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            Client = client;
            EncompassId = loanId;
            Documents = new LoanDocuments(client, loanId);
            Attachments = new LoanAttachments(client, loanId);
        }
    }
}