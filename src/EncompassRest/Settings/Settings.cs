using System.Threading;
using EncompassRest.Settings.Contacts;
using EncompassRest.Settings.Loan;

namespace EncompassRest.Settings
{
    /// <summary>
    /// The Settings Apis.
    /// </summary>
    public sealed class Settings : ApiObject
    {
        private Templates.Templates _templates;
        private BorrowerContactsSettings _borrowerContacts;
        private BusinessContactsSettings _businessContacts;
        private LoanSettings _loan;
        private Personas.Personas _personas;

        /// <summary>
        /// The Templates Apis.
        /// </summary>
        public Templates.Templates Templates
        {
            get
            {
                var templates = _templates;
                return templates ?? Interlocked.CompareExchange(ref _templates, (templates = new Templates.Templates(Client)), null) ?? templates;
            }
        }

        /// <summary>
        /// The Borrower Contacts Settings Apis.
        /// </summary>
        public BorrowerContactsSettings BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContactsSettings(Client)), null) ?? borrowerContacts;
            }
        }

        /// <summary>
        /// The Business Contacts Settings Apis.
        /// </summary>
        public BusinessContactsSettings BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContactsSettings(Client)), null) ?? businessContacts;
            }
        }

        /// <summary>
        /// The Loan Settings Apis.
        /// </summary>
        public LoanSettings Loan
        {
            get
            {
                var loan = _loan;
                return loan ?? Interlocked.CompareExchange(ref _loan, (loan = new LoanSettings(Client)), null) ?? loan;
            }
        }

        /// <summary>
        /// The Personas Apis.
        /// </summary>
        public Personas.Personas Personas
        {
            get
            {
                var personas = _personas;
                return personas ?? Interlocked.CompareExchange(ref _personas, (_personas = new Personas.Personas(Client)), null) ?? personas;
            }
        }

        internal Settings(EncompassRestClient client)
            : base(client, "encompass/v1/settings")
        {
        }
    }
}