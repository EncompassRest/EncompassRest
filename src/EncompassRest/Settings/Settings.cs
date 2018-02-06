using System.Threading;
using EncompassRest.Settings.Contacts;

namespace EncompassRest.Settings
{
    public sealed class Settings : ApiObject
    {
        private Templates.Templates _templates;
        private BorrowerContactsSettings _borrowerContacts;
        private BusinessContactsSettings _businessContacts;

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

        internal Settings(EncompassRestClient client)
            : base(client, "encompass/v1/settings")
        {
        }
    }
}