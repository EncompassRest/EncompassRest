using System.Threading;
using EncompassRest.Settings.Contacts;
using EncompassRest.Settings.Loan;

namespace EncompassRest.Settings
{
    public sealed class Settings : ApiObject
    {
        private Templates.Templates _templates;
        private BorrowerContactsSettings _borrowerContacts;
        private BusinessContactsSettings _businessContacts;
        private LoanSettings _loan;

        public Templates.Templates Templates
        {
            get
            {
                var templates = _templates;
                return templates ?? Interlocked.CompareExchange(ref _templates, (templates = new Templates.Templates(Client)), null) ?? templates;
            }
        }

        public BorrowerContactsSettings BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContactsSettings(Client)), null) ?? borrowerContacts;
            }
        }

        public BusinessContactsSettings BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContactsSettings(Client)), null) ?? businessContacts;
            }
        }

        public LoanSettings Loan
        {
            get
            {
                var loan = _loan;
                return loan ?? Interlocked.CompareExchange(ref _loan, (loan = new LoanSettings(Client)), null) ?? loan;
            }
        }

        internal Settings(EncompassRestClient client)
            : base(client, "encompass/v1/settings")
        {
        }
    }
}