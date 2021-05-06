using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Base Contacts Apis.
    /// </summary>
    /// <typeparam name="TContact">The contact type.</typeparam>
    public interface IContactsV1<TContact>
        where TContact : Contact
    {
        /// <summary>
        /// Creates a new contact from raw json and returns the responses body if not empty else its contact id.
        /// </summary>
        /// <param name="contact">The contact to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateContactRawAsync(string contact, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteContactAsync(string contactId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves contact information for the specified contact ID as raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetContactRawAsync(string contactId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteContactAsync(string contactId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates contact information for the specified contact ID from raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="contact">The contact to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateContactRawAsync(string contactId, string contact, string? queryString = null, CancellationToken cancellationToken = default);
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

    internal abstract class ContactsV1<TContact> : ApiObject, IContactsV1<TContact>
        where TContact : Contact
    {
        private readonly string _apiPath;

        internal ContactsV1(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
            _apiPath = baseApiPath;
        }

        public async Task<TContact> GetContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            var contact = await GetDirtyAsync<TContact>(contactId, null, nameof(GetContactAsync), contactId, cancellationToken).ConfigureAwait(false);
            contact.Initialize(Client, contact.Id!);
            return contact;
        }

        public Task<string> GetContactRawAsync(string contactId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return GetRawAsync(contactId, queryString, nameof(GetContactRawAsync), contactId, cancellationToken);
        }

        public Task<string> CreateContactAsync(TContact contact, CancellationToken cancellationToken = default) => CreateContactAsync(contact, false, cancellationToken);

        private async Task<string> CreateContactAsync(TContact contact, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            var contactId = await PostPopulateDirtyAsync(null, nameof(CreateContactAsync), contact, populate, cancellationToken).ConfigureAwait(false);
            contact.Initialize(Client, contactId);
            return contactId;
        }

        public Task<string> CreateContactRawAsync(string contact, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PostAsync(null, queryString, new JsonStringContent(contact), nameof(CreateContactRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateContactAsync(TContact contact, CancellationToken cancellationToken = default) => UpdateContactAsync(contact, false, cancellationToken);

        private Task UpdateContactAsync(TContact contact, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NotNullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            contact.Initialize(Client, contact.Id);
            contact.Dirty = true; // To be removed if Ellie Mae updates API to only update provided properties.
            return PatchPopulateDirtyAsync(contact.Id, JsonStreamContent.Create(contact), nameof(UpdateContactAsync), contact.Id, contact, populate, cancellationToken);
        }

        public Task<string> UpdateContactRawAsync(string contactId, string contact, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PatchRawAsync(contactId, queryString, new JsonStringContent(contact), nameof(UpdateContactRawAsync), contactId, cancellationToken);
        }

        public Task<bool> TryDeleteContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return TryDeleteAsync(contactId, null, cancellationToken);
        }

        public Task DeleteContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return DeleteAsync(contactId, null, cancellationToken);
        }
    }
}