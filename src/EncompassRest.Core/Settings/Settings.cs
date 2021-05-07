using System.Threading;
using EncompassRest.Settings.Contacts;
using EncompassRest.Settings.Loan;
using EncompassRest.Settings.Personas;
using EncompassRest.Settings.Templates;

namespace EncompassRest.Settings
{
    /// <summary>
    /// The Settings Apis.
    /// </summary>
    public interface ISettings : IApiObject
    {
        /// <summary>
        /// The Borrower Contacts Settings Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Settings.Contacts.v1 namespace.
        /// </summary>
        IBorrowerContactsSettings BorrowerContacts { get; }
        /// <summary>
        /// The Business Contacts Settings Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Settings.Contacts.v1 namespace.
        /// </summary>
        IBusinessContactsSettings BusinessContacts { get; }
        /// <summary>
        /// The Loan Settings Apis.
        /// </summary>
        ILoanSettings Loan { get; }
        /// <summary>
        /// The Personas Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Settings.Personas.v1 namespace.
        /// </summary>
        IPersonas Personas { get; }
        /// <summary>
        /// The Templates Apis.
        /// </summary>
        ITemplates Templates { get; }
    }

    internal sealed class Settings : ApiObject, ISettings
    {
        private Templates.Templates? _templates;
        private BorrowerContactsSettings? _borrowerContacts;
        private BusinessContactsSettings? _businessContacts;
        private LoanSettings? _loan;
        private Personas.Personas? _personas;

        public ITemplates Templates
        {
            get
            {
                var templates = _templates;
                return templates ?? Interlocked.CompareExchange(ref _templates, (templates = new Templates.Templates(Client)), null) ?? templates;
            }
        }

        public IBorrowerContactsSettings BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContactsSettings(Client)), null) ?? borrowerContacts;
            }
        }

        public IBusinessContactsSettings BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContactsSettings(Client)), null) ?? businessContacts;
            }
        }

        public ILoanSettings Loan
        {
            get
            {
                var loan = _loan;
                return loan ?? Interlocked.CompareExchange(ref _loan, (loan = new LoanSettings(Client)), null) ?? loan;
            }
        }

        public IPersonas Personas
        {
            get
            {
                var personas = _personas;
                return personas ?? Interlocked.CompareExchange(ref _personas, (personas = new Personas.Personas(Client)), null) ?? personas;
            }
        }

        internal Settings(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}