using System.Threading;
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

        public LoanDocuments Documents
        {
            get
            {
                var documents = _documents;
                return documents ?? Interlocked.CompareExchange(ref _documents, (documents = new LoanDocuments(Client, LoanId)), null) ?? documents;
            }
        }

        public LoanAttachments Attachments
        {
            get
            {
                var attachments = _attachments;
                return attachments ?? Interlocked.CompareExchange(ref _attachments, (attachments = new LoanAttachments(Client, LoanId)), null) ?? attachments;
            }
        }

        public LoanCustomDataObjects CustomDataObjects
        {
            get
            {
                var customDataObjects = _customDataObjects;
                return customDataObjects ?? Interlocked.CompareExchange(ref _customDataObjects, (customDataObjects = new LoanCustomDataObjects(Client, LoanId)), null) ?? customDataObjects;
            }
        }

        internal LoanApis(EncompassRestClient client, string loanId)
        {
            Client = client;
            LoanId = loanId;
        }
    }
}