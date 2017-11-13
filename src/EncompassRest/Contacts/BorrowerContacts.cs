using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContacts
    {
        private const string s_apiPath = "encompass/v1/borrowerContacts";

        #region Public Properties
        public EncompassRestClient Client { get; }
        #endregion

        internal BorrowerContacts(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<BorrowerContact> GetContactAsync(string contactId) => GetContactAsync(contactId, CancellationToken.None);

        public Task<BorrowerContact> GetContactAsync(string contactId, CancellationToken cancellationToken) =>
                GetContactInternalAsync(contactId, cancellationToken, async response =>
                {
                    var contact = await response.Content.ReadAsAsync<BorrowerContact>().ConfigureAwait(false);
                    contact.Initialize(Client);
                    contact.Dirty = false;
                    return contact;
                });

        public Task<string> GetContactRawAsync(string contactId) => GetContactRawAsync(contactId, CancellationToken.None);

        public Task<string> GetContactRawAsync(string contactId, CancellationToken cancellationToken) =>
            GetContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetContactInternalAsync<T>(string contactId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(GetContactAsync)}/{contactId}", response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateContactAsync(BorrowerContact contact) => CreateContactAsync(contact, false, CancellationToken.None);

        public Task<string> CreateContactAsync(BorrowerContact contact, CancellationToken cancellationToken) => CreateContactAsync(contact, false, cancellationToken);

        private Task<string> CreateContactAsync(BorrowerContact contact, bool populate) => CreateContactAsync(contact, populate, CancellationToken.None);

        private Task<string> CreateContactAsync(BorrowerContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));

            return CreateContactInternalAsync(JsonStreamContent.Create(contact), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                var contactId = Path.GetFileName(response.Headers.Location.OriginalString);
                contact.Id = contactId;
                contact.Initialize(Client);
                if (populate)
                {
                    await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                }
                contact.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }

        public Task<string> CreateContactRawAsync(string contact) => CreateContactRawAsync(contact, null, CancellationToken.None);

        public Task<string> CreateContactRawAsync(string contact, CancellationToken cancellationToken) => CreateContactRawAsync(contact, null, cancellationToken);

        private Task<string> CreateContactRawAsync(string contact, string queryString) => CreateContactRawAsync(contact, queryString, CancellationToken.None);

        private Task<string> CreateContactRawAsync(string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return CreateContactInternalAsync(new JsonStringContent(contact), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });   
        }

        private async Task<string> CreateContactInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(CreateContactAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateContactAsync(BorrowerContact contact) => UpdateContactAsync(contact, false, CancellationToken.None);

        public Task UpdateContactAsync(BorrowerContact contact, CancellationToken cancellationToken) => UpdateContactAsync(contact, false, cancellationToken);

        private Task UpdateContactAsync(BorrowerContact contact, bool populate) => UpdateContactAsync(contact, populate, CancellationToken.None);

        private Task UpdateContactAsync(BorrowerContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));
            Preconditions.NotNull(contact.Id, nameof(contact.Id));

            contact.Initialize(Client);
            return UpdateContactInternalAsync(contact.Id, JsonStreamContent.Create(contact), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
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

            return UpdateContactInternalAsync(contactId, new JsonStringContent(contact), queryString, cancellationToken, response =>
                response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateContactInternalAsync(string contactId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage,Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{contactId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(UpdateContactAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteContactAsync(string contactId) => DeleteContactAsync(contactId, CancellationToken.None);

        public async Task<bool> DeleteContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.DeleteAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}
