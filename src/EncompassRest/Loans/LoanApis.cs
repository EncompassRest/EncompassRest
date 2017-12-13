using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Apis;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;

namespace EncompassRest.Loans
{
    public class LoanApis : LoanApiObject
    {
        private LoanDocuments _documents;
        private LoanAttachments _attachments;
        private LoanCustomDataObjects _customDataObjects;
        private BorrowerPairs _borrowerPairs;
        private LoanMetadata _metadata;

        public LoanDocuments Documents => _documents ?? (_documents = new LoanDocuments(Client, LoanId));

        public LoanAttachments Attachments => _attachments ?? (_attachments = new LoanAttachments(Client, LoanId));

        public LoanCustomDataObjects CustomDataObjects => _customDataObjects ?? (_customDataObjects = new LoanCustomDataObjects(Client, LoanId));

        public BorrowerPairs BorrowerPairs => _borrowerPairs ?? (_borrowerPairs = CreateBorrowerPairs());

        internal virtual BorrowerPairs CreateBorrowerPairs() => new BorrowerPairs(Client, LoanId);

        internal LoanApis(EncompassRestClient client, string loanId)
            : base(client, loanId, null)
        {
        }

        public Task<LoanMetadata> GetMetadataAsync(CancellationToken cancellationToken = default) => GetAsync<LoanMetadata>("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<string> GetMetadataRawAsync(CancellationToken cancellationToken = default) => GetRawAsync("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);
    }
}