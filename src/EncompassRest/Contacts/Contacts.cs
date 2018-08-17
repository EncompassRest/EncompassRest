using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public abstract class Contacts<TContact> : ApiObject
        where TContact : Contact
    {
        internal Contacts(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        public async Task<TContact> GetContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            var contact = await GetDirtyAsync<TContact>(contactId, null, nameof(GetContactAsync), contactId, cancellationToken).ConfigureAwait(false);
            contact.Initialize(Client, contact.Id);
            return contact;
        }

        public Task<string> GetContactRawAsync(string contactId, string queryString = null, CancellationToken cancellationToken = default)
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

        public Task<string> CreateContactRawAsync(string contact, string queryString = null, CancellationToken cancellationToken = default)
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
            return PatchPopulateDirtyAsync(contact.Id, JsonStreamContent.Create(contact), nameof(UpdateContactAsync), contact.Id, contact, populate, cancellationToken);
        }

        public Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PatchRawAsync(contactId, queryString, new JsonStringContent(contact), nameof(UpdateContactRawAsync), contactId, cancellationToken);
        }

        public Task<bool> DeleteContactAsync(string contactId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return DeleteAsync(contactId, null, cancellationToken);
        }
    }
}