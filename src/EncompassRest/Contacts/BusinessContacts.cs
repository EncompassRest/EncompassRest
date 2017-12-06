using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public sealed class BusinessContacts : ApiObject
    {
        internal BusinessContacts(EncompassRestClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }

        public Task<BusinessContact> GetContactAsync(string contactId) => GetContactAsync(contactId, CancellationToken.None);

        public async Task<BusinessContact> GetContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            var contact = await GetDirtyAsync<BusinessContact>(contactId, null, nameof(GetContactAsync), contactId, cancellationToken).ConfigureAwait(false);
            contact.Initialize(Client);
            return contact;
        }

        public Task<string> GetContactRawAsync(string contactId) => GetContactRawAsync(contactId, CancellationToken.None);

        public Task<string> GetContactRawAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return GetRawAsync(contactId, null, nameof(GetContactRawAsync), contactId, cancellationToken);
        }

        public Task<string> CreateContactAsync(BusinessContact contact) => CreateContactAsync(contact, false, CancellationToken.None);

        public Task<string> CreateContactAsync(BusinessContact contact, CancellationToken cancellationToken) => CreateContactAsync(contact, false, cancellationToken);

        private Task<string> CreateContactAsync(BusinessContact contact, bool populate) => CreateContactAsync(contact, populate, CancellationToken.None);

        private Task<string> CreateContactAsync(BusinessContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            return PostAsync(null, populate ? ViewEntityQueryString : null, JsonStreamContent.Create(contact), nameof(CreateContactAsync), null, cancellationToken, async response =>
            {
                var contactId = GetLocation(response);
                contact.Id = contactId;
                contact.Initialize(Client);
                if (populate)
                {
                    await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                }
                contact.Dirty = false;
                return contactId;
            });
        }

        public Task<string> CreateContactRawAsync(string contact) => CreateContactRawAsync(contact, null, CancellationToken.None);

        public Task<string> CreateContactRawAsync(string contact, CancellationToken cancellationToken) => CreateContactRawAsync(contact, null, cancellationToken);

        private Task<string> CreateContactRawAsync(string contact, string queryString) => CreateContactRawAsync(contact, queryString, CancellationToken.None);

        private Task<string> CreateContactRawAsync(string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PostAsync(null, queryString, new JsonStringContent(contact), nameof(CreateContactRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateContactAsync(BusinessContact contact) => UpdateContactAsync(contact, false, CancellationToken.None);

        public Task UpdateContactAsync(BusinessContact contact, CancellationToken cancellationToken) => UpdateContactAsync(contact, false, cancellationToken);

        private Task UpdateContactAsync(BusinessContact contact, bool populate) => UpdateContactAsync(contact, populate, CancellationToken.None);

        private Task UpdateContactAsync(BusinessContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NotNullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            contact.Initialize(Client);
            return PatchPopulateDirtyAsync(contact.Id, JsonStreamContent.Create(contact), nameof(UpdateContactAsync), contact.Id, cancellationToken, contact, populate);
        }

        public Task<string> UpdateContactRawAsync(string contactId, string contact) => UpdateContactRawAsync(contactId, contact, null, CancellationToken.None);

        public Task<string> UpdateContactRawAsync(string contactId, string contact, CancellationToken cancellationToken) => UpdateContactRawAsync(contactId, contact, null, cancellationToken);

        private Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString) => UpdateContactRawAsync(contactId, contact, queryString, CancellationToken.None);

        private Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PatchRawAsync(contactId, queryString, new JsonStringContent(contact), nameof(UpdateContactRawAsync), contactId, cancellationToken);
        }

        public Task<bool> DeleteContactAsync(string contactId) => DeleteContactAsync(contactId, CancellationToken.None);

        public Task<bool> DeleteContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return DeleteAsync(contactId, cancellationToken);
        }
    }
}
