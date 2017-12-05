using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;

namespace EncompassRest.Loans
{
    public class LoanApis
    {
        private LoanDocuments _documents;
        private LoanAttachments _attachments;
        private LoanCustomDataObjects _customDataObjects;

        public EncompassRestClient Client { get; }

        public string LoanId { get; }

        public LoanDocuments Documents => _documents ?? (_documents = new LoanDocuments(Client, LoanId));

        public LoanAttachments Attachments => _attachments ?? (_attachments = new LoanAttachments(Client, LoanId));

        public LoanCustomDataObjects CustomDataObjects => _customDataObjects ?? (_customDataObjects = new LoanCustomDataObjects(Client, LoanId));

        internal LoanApis(EncompassRestClient client, string loanId)
        {
            Client = client;
            LoanId = loanId;
        }
    }
}