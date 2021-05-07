using System.Threading;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Base Contacts Apis.
    /// </summary>
    public interface IContacts : IApiObject
    {
        /// <summary>
        /// The Borrower Contacts Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Contacts.v1 namespace.
        /// </summary>
        IBorrowerContacts BorrowerContacts { get; }
        /// <summary>
        /// The Borrower Contact Selector Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Contacts.v1 namespace.
        /// </summary>
        IBorrowerContactSelector BorrowerContactSelector { get; }
        /// <summary>
        /// The Business Contacts Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Contacts.v1 namespace.
        /// </summary>
        IBusinessContacts BusinessContacts { get; }
        /// <summary>
        /// The Business Contact Selector Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Contacts.v1 namespace.
        /// </summary>
        IBusinessContactSelector BusinessContactSelector { get; }
        /// <summary>
        /// The Contact Groups Apis exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Contacts.v1 namespace.
        /// </summary>
        IContactGroups Groups { get; }
        /// <summary>
        /// Gets the Contact Notes Apis associated with the given contact. The Contact Notes Apis are exposed as extension methods from the EncompassRest.Contacts package
        /// within the EncompassRest.Contacts.v1 namespace.
        /// </summary>
        /// <param name="type">The contact type.</param>
        /// <param name="contactId">The contact id.</param>
        /// <returns></returns>
        IContactNotes GetContactNotes(ContactType type, string contactId);
    }

    internal sealed class Contacts : ApiObject, IContacts
    {
        private BorrowerContacts? _borrowerContacts;
        private BusinessContacts? _businessContacts;
        private BorrowerContactSelector? _borrowerContactSelector;
        private BusinessContactSelector? _businessContactSelector;
        private ContactGroups? _groups;

        public IBorrowerContacts BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContacts(Client)), null) ?? borrowerContacts;
            }
        }

        public IBusinessContacts BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContacts(Client)), null) ?? businessContacts;
            }
        }

        public IBorrowerContactSelector BorrowerContactSelector
        {
            get
            {
                var borrowerContactSelector = _borrowerContactSelector;
                return borrowerContactSelector ?? Interlocked.CompareExchange(ref _borrowerContactSelector, (borrowerContactSelector = new BorrowerContactSelector(Client)), null) ?? borrowerContactSelector;
            }
        }

        public IBusinessContactSelector BusinessContactSelector
        {
            get
            {
                var businessContactSelector = _businessContactSelector;
                return businessContactSelector ?? Interlocked.CompareExchange(ref _businessContactSelector, (businessContactSelector = new BusinessContactSelector(Client)), null) ?? businessContactSelector;
            }
        }

        public IContactGroups Groups
        {
            get
            {
                var groups = _groups;
                return groups ?? Interlocked.CompareExchange(ref _groups, (groups = new ContactGroups(Client)), null) ?? groups;
            }
        }

        internal Contacts(EncompassRestClient client)
            : base(client, null)
        {
        }

        public IContactNotes GetContactNotes(ContactType type, string contactId)
        {
            type.Validate(nameof(type));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return new ContactNotes(Client, type, contactId);
        }
    }
}