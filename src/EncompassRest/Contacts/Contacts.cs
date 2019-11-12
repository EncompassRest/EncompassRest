using System.Threading;
using System.Threading.Tasks;
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
        /// The Borrower Contacts Apis.
        /// </summary>
        IBorrowerContacts BorrowerContacts { get; }
        /// <summary>
        /// The Borrower Contact Selector Apis.
        /// </summary>
        IBorrowerContactSelector BorrowerContactSelector { get; }
        /// <summary>
        /// The Business Contacts Apis.
        /// </summary>
        IBusinessContacts BusinessContacts { get; }
        /// <summary>
        /// The Business Contact Selector Apis.
        /// </summary>
        IBusinessContactSelector BusinessContactSelector { get; }
        /// <summary>
        /// The Contact Groups Apis.
        /// </summary>
        IContactGroups Groups { get; }
        /// <summary>
        /// Gets the Contact Notes Apis associated with the given contact.
        /// </summary>
        /// <param name="type">The contact type.</param>
        /// <param name="contactId">The contact id.</param>
        /// <returns></returns>
        IContactNotes GetContactNotes(ContactType type, string contactId);
    }

    /// <summary>
    /// The Contacts Apis.
    /// </summary>
    public sealed class Contacts : ApiObject, IContacts
    {
        private BorrowerContacts _borrowerContacts;
        private BusinessContacts _businessContacts;
        private BorrowerContactSelector _borrowerContactSelector;
        private BusinessContactSelector _businessContactSelector;
        private ContactGroups _groups;

        /// <summary>
        /// The Borrower Contacts Apis.
        /// </summary>
        public BorrowerContacts BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContacts(Client)), null) ?? borrowerContacts;
            }
        }

        IBorrowerContacts IContacts.BorrowerContacts => BorrowerContacts;

        /// <summary>
        /// The Business Contacts Apis.
        /// </summary>
        public BusinessContacts BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContacts(Client)), null) ?? businessContacts;
            }
        }

        IBusinessContacts IContacts.BusinessContacts => BusinessContacts;

        /// <summary>
        /// The Borrower Contact Selector Apis.
        /// </summary>
        public BorrowerContactSelector BorrowerContactSelector
        {
            get
            {
                var borrowerContactSelector = _borrowerContactSelector;
                return borrowerContactSelector ?? Interlocked.CompareExchange(ref _borrowerContactSelector, (borrowerContactSelector = new BorrowerContactSelector(Client)), null) ?? borrowerContactSelector;
            }
        }

        IBorrowerContactSelector IContacts.BorrowerContactSelector => BorrowerContactSelector;

        /// <summary>
        /// The Business Contact Selector Apis.
        /// </summary>
        public BusinessContactSelector BusinessContactSelector
        {
            get
            {
                var businessContactSelector = _businessContactSelector;
                return businessContactSelector ?? Interlocked.CompareExchange(ref _businessContactSelector, (businessContactSelector = new BusinessContactSelector(Client)), null) ?? businessContactSelector;
            }
        }

        IBusinessContactSelector IContacts.BusinessContactSelector => BusinessContactSelector;

        /// <summary>
        /// The Contact Groups Apis.
        /// </summary>
        public ContactGroups Groups
        {
            get
            {
                var groups = _groups;
                return groups ?? Interlocked.CompareExchange(ref _groups, (groups = new ContactGroups(Client)), null) ?? groups;
            }
        }

        IContactGroups IContacts.Groups => Groups;

        internal Contacts(EncompassRestClient client)
            : base(client, null)
        {
        }

        /// <summary>
        /// Gets the Contact Notes Apis associated with the given contact.
        /// </summary>
        /// <param name="type">The contact type.</param>
        /// <param name="contactId">The contact id.</param>
        /// <returns></returns>
        public IContactNotes GetContactNotes(ContactType type, string contactId)
        {
            type.Validate(nameof(type));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return new ContactNotes(Client, contactId, type == ContactType.Borrower ? "encompass/v1/borrowerContacts" : "encompass/v1/businessContacts");
        }
    }

    /// <summary>
    /// The Base Contacts Apis.
    /// </summary>
    /// <typeparam name="TContact">The contact type.</typeparam>
    public interface IContacts<TContact>
        where TContact : Contact
    {
        /// <summary>
        /// Creates a new contact from raw json and returns the responses body if not empty else its contact id.
        /// </summary>
        /// <param name="contact">The contact to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateContactRawAsync(string contact, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> DeleteContactAsync(string contactId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the Contact Notes Apis for the contact with the specified <paramref name="contactId"/>.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <returns></returns>
        IContactNotes GetContactNotes(string contactId);
        /// <summary>
        /// Retrieves contact information for the specified contact ID as raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetContactRawAsync(string contactId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates contact information for the specified contact ID from raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="contact">The contact to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new contact and returns its contact id.
        /// </summary>
        /// <param name="contact">The contact to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateContactAsync(TContact contact, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves contact information for the specified contact ID.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TContact> GetContactAsync(string contactId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates contact information for the specified contact ID.
        /// </summary>
        /// <param name="contact">The contact to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateContactAsync(TContact contact, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Base Contacts Apis.
    /// </summary>
    /// <typeparam name="TContact">The contact type.</typeparam>
    public abstract class Contacts<TContact> : ApiObject, IContacts<TContact>
        where TContact : Contact
    {
        private readonly string _apiPath;

        internal Contacts(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
            _apiPath = baseApiPath;
        }

        /// <summary>
        /// Gets the Contact Notes Apis for the contact with the specified <paramref name="contactId"/>.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <returns></returns>
        public ContactNotes GetContactNotes(string contactId)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return new ContactNotes(Client, contactId, _apiPath);
        }

        IContactNotes IContacts<TContact>.GetContactNotes(string contactId) => GetContactNotes(contactId);

        /// <summary>
        /// Retrieves contact information for the specified contact ID.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<TContact> GetContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            var contact = await GetDirtyAsync<TContact>(contactId, null, nameof(GetContactAsync), contactId, cancellationToken).ConfigureAwait(false);
            contact.Initialize(Client, contact.Id);
            return contact;
        }

        /// <summary>
        /// Retrieves contact information for the specified contact ID as raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetContactRawAsync(string contactId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return GetRawAsync(contactId, queryString, nameof(GetContactRawAsync), contactId, cancellationToken);
        }

        /// <summary>
        /// Creates a new contact and returns its contact id.
        /// </summary>
        /// <param name="contact">The contact to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateContactAsync(TContact contact, CancellationToken cancellationToken = default) => CreateContactAsync(contact, false, cancellationToken);

        private async Task<string> CreateContactAsync(TContact contact, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            var contactId = await PostPopulateDirtyAsync(null, nameof(CreateContactAsync), contact, populate, cancellationToken).ConfigureAwait(false);
            contact.Initialize(Client, contactId);
            return contactId;
        }

        /// <summary>
        /// Creates a new contact from raw json and returns the responses body if not empty else its contact id.
        /// </summary>
        /// <param name="contact">The contact to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateContactRawAsync(string contact, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PostAsync(null, queryString, new JsonStringContent(contact), nameof(CreateContactRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <summary>
        /// Updates contact information for the specified contact ID.
        /// </summary>
        /// <param name="contact">The contact to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateContactAsync(TContact contact, CancellationToken cancellationToken = default) => UpdateContactAsync(contact, false, cancellationToken);

        private Task UpdateContactAsync(TContact contact, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NotNullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            contact.Initialize(Client, contact.Id);
            contact.Dirty = true; // To be removed if Ellie Mae updates API to only update provided properties.
            return PatchPopulateDirtyAsync(contact.Id, JsonStreamContent.Create(contact), nameof(UpdateContactAsync), contact.Id, contact, populate, cancellationToken);
        }

        /// <summary>
        /// Updates contact information for the specified contact ID from raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="contact">The contact to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PatchRawAsync(contactId, queryString, new JsonStringContent(contact), nameof(UpdateContactRawAsync), contactId, cancellationToken);
        }

        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return TryDeleteAsync(contactId, null, cancellationToken);
        }
    }
}