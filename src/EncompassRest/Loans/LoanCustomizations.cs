using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public partial class Loan
    {
        [JsonIgnore]
        public EncompassRestClient Client { get; }

        [JsonIgnore]
        public LoanDocuments Documents { get; }

        [JsonIgnore]
        public LoanAttachments Attachments { get; }

        /// <summary>
        /// Loan create constructor
        /// </summary>
        [JsonConstructor]
        public Loan()
        {
            Clean = true;
        }

        /// <summary>
        /// Loan update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="loanId"></param>
        public Loan(EncompassRestClient client, string loanId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            Client = client;
            EncompassId = loanId;
            Documents = new LoanDocuments(client, loanId);
            Attachments = new LoanAttachments(client, loanId);
            Clean = true;
        }
    }
}