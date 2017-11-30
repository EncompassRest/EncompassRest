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

        public Task<BusinessContact> GetContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return GetAsync(contactId, null, nameof(GetContactAsync), contactId, cancellationToken, async response =>
            {
                var contact = await response.Content.ReadAsAsync<BusinessContact>().ConfigureAwait(false);
                contact.Initialize(Client);
                contact.Dirty = false;
                return contact;
            });
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

            return PostAsync(JsonStreamContent.Create(contact), null, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(CreateContactAsync), null, cancellationToken, async response =>
            {
                var contactId = Path.GetFileName(response.Headers.Location.OriginalString);
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

            return PostAsync(new JsonStringContent(contact), null, queryString, nameof(CreateContactRawAsync), null, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }

        public Task UpdateContactAsync(BusinessContact contact) => UpdateContactAsync(contact, false, CancellationToken.None);

        public Task UpdateContactAsync(BusinessContact contact, CancellationToken cancellationToken) => UpdateContactAsync(contact, false, cancellationToken);

        private Task UpdateContactAsync(BusinessContact contact, bool populate) => UpdateContactAsync(contact, populate, CancellationToken.None);

        private Task UpdateContactAsync(BusinessContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NotNullOrEmpty(contact.Id, $"{nameof(contact)}.{nameof(contact.Id)}");

            contact.Initialize(Client);
            return PatchAsync(JsonStreamContent.Create(contact), contact.Id, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(UpdateContactAsync), contact.Id, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                }
                contact.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateContactRawAsync(string contactId, string contact) => UpdateContactRawAsync(contactId, contact, null, CancellationToken.None);

        public Task<string> UpdateContactRawAsync(string contactId, string contact, CancellationToken cancellationToken) => UpdateContactRawAsync(contactId, contact, null, cancellationToken);

        private Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString) => UpdateContactRawAsync(contactId, contact, queryString, CancellationToken.None);

        private Task<string> UpdateContactRawAsync(string contactId, string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return PatchRawAsync(new JsonStringContent(contact), contactId, queryString, nameof(UpdateContactRawAsync), contactId, cancellationToken);
        }

        public Task<bool> DeleteContactAsync(string contactId) => DeleteContactAsync(contactId, CancellationToken.None);

        public Task<bool> DeleteContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return DeleteAsync(contactId, cancellationToken);
        }
    }
}
