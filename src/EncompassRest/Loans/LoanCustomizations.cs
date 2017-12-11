using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public partial class Loan
    {
        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public LoanDocuments Documents { get; private set; }

        [JsonIgnore]
        public LoanAttachments Attachments { get; private set; }

        [JsonIgnore]
        public LoanCustomDataObjects CustomDataObjects { get; private set; }

        [JsonIgnore]
        public LoanObjectBoundApis LoanApis { get; private set; }

        [IdPropertyName(nameof(EncompassId))]
        string IIdentifiable.Id { get => EncompassId ?? Id; set { EncompassId = value; Id = value; } }

        /// <summary>
        /// Loan update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="loanId"></param>
        public Loan(EncompassRestClient client, string loanId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            EncompassId = loanId;
            Initialize(client);
        }

        /// <summary>
        /// Loan creation constructor
        /// </summary>
        [JsonConstructor]
        public Loan()
        {
        }

        internal void Initialize(EncompassRestClient client)
        {
            Client = client;
            Documents = new LoanDocuments(client, EncompassId);
            Attachments = new LoanAttachments(client, EncompassId);
            CustomDataObjects = new LoanCustomDataObjects(client, EncompassId);
            LoanApis = new LoanObjectBoundApis(client, this);
        }
    }
}