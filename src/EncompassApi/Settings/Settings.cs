using System.Threading;
using EncompassApi.Settings.Contacts;
using EncompassApi.Settings.Loan;

namespace EncompassApi.Settings
{
    /// <summary>
    /// The Settings Apis.
    /// </summary>
    public interface ISettings : IApiObject
    {
        /// <summary>
        /// The Borrower Contacts Settings Apis.
        /// </summary>
        IBorrowerContactsSettings BorrowerContacts { get; }
        /// <summary>
        /// The Business Contacts Settings Apis.
        /// </summary>
        IBusinessContactsSettings BusinessContacts { get; }
        /// <summary>
        /// The Loan Settings Apis.
        /// </summary>
        ILoanSettings Loan { get; }
        /// <summary>
        /// The Personas Apis.
        /// </summary>
        Personas.IPersonas Personas { get; }
        /// <summary>
        /// The Templates Apis.
        /// </summary>
        Templates.ITemplates Templates { get; }
    }

    /// <summary>
    /// The Settings Apis.
    /// </summary>
    public sealed class Settings : ApiObject, ISettings
    {
        private Templates.Templates? _templates;
        private BorrowerContactsSettings? _borrowerContacts;
        private BusinessContactsSettings? _businessContacts;
        private LoanSettings? _loan;
        private Personas.Personas? _personas;

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

        Templates.ITemplates ISettings.Templates => Templates;

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

        IBorrowerContactsSettings ISettings.BorrowerContacts => BorrowerContacts;

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

        IBusinessContactsSettings ISettings.BusinessContacts => BusinessContacts;

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

        ILoanSettings ISettings.Loan => Loan;

        /// <summary>
        /// The Personas Apis.
        /// </summary>
        public Personas.Personas Personas
        {
            get
            {
                var personas = _personas;
                return personas ?? Interlocked.CompareExchange(ref _personas, (personas = new Personas.Personas(Client)), null) ?? personas;
            }
        }

        Personas.IPersonas ISettings.Personas => Personas;

        internal Settings(IEncompassApiClient client)
            : base(client, "encompass/v1/settings")
        {
        }
    }
}