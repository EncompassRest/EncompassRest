using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Contacts
{
    public sealed class BusinessContacts
    {
        private static string s_apiPath = "encompass/v1/BusinessContacts";

        #region Public Properties
        public EncompassRestClient Client { get; private set; }
        #endregion


        internal BusinessContacts(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<BusinessContact> GetBusinessContactAsync(string contactId) => GetBusinessContactAsync(contactId, CancellationToken.None);
        public Task<BusinessContact> GetBusinessContactAsync(string contactId, CancellationToken cancellationToken) =>
            GetBusinessContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsAsync<BusinessContact>());

        public Task<string> GetBusinessContactRawAsync(string contactId) => GetBusinessContactRawAsync(contactId, CancellationToken.None);
        public Task<string> GetBusinessContactRawAsync(string contactId, CancellationToken cancellationToken) =>
            GetBusinessContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetBusinessContactInternalAsync<T>(string contactId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(GetBusinessContactAsync)}/{contactId}", response).ConfigureAwait(false) : await RestException.CreateAsync($"{nameof(GetBusinessContactAsync)}", response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
        public Task<string> CreateBusinessContactAsync(BusinessContact contact) => CreateBusinessContactAsync(contact, true, CancellationToken.None);
        public Task<string> CreateBusinessContactAsync(BusinessContact contact, bool populate) => CreateBusinessContactAsync(contact, populate, CancellationToken.None);
        public Task<string> CreateBusinessContactAsync(BusinessContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));

            return CreateBusinessContactInternalAsync(JsonStreamContent.Create(contact), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                }
                contact.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }

        public Task<string> CreateBusinessContactRawAsync(string contact) => CreateBusinessContactRawAsync(contact, "", CancellationToken.None);
        public Task<string> CreateBusinessContactRawAsync(string contact, CancellationToken cancellationToken) => CreateBusinessContactRawAsync(contact, null, cancellationToken);
        public Task<string> CreateBusinessContactRawAsync(string contact, string queryString) => CreateBusinessContactRawAsync(contact, queryString, CancellationToken.None);
        public Task<string> CreateBusinessContactRawAsync(string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return CreateBusinessContactInternalAsync(new JsonStringContent(contact), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }
        private async Task<string> CreateBusinessContactInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateBusinessContactAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }
        public Task UpdateBusinessContactAsync(BusinessContact contact) => UpdateBusinessContactAsync(contact, false, CancellationToken.None);
        public Task UpdateBusinessContactAsync(BusinessContact contact, CancellationToken cancellationToken) => UpdateBusinessContactAsync(contact, false, cancellationToken);
        public Task UpdateBusinessContactAsync(BusinessContact contact, bool populate) => UpdateBusinessContactAsync(contact, populate, CancellationToken.None);
        public Task UpdateBusinessContactAsync(BusinessContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));

            return UpdateBusinessContactInternalAsync(contact.Id, JsonStreamContent.Create(contact), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                }
                contact.Dirty = false;
                return string.Empty;
            });

        }
        public Task UpdateBusinessContactRawAsync(string contactId, string contact) => UpdateBusinessContactRawAsync(contactId, contact, null, CancellationToken.None);
        public Task UpdateBusinessContactRawAsync(string contactId, string contact, CancellationToken cancellationToken) => UpdateBusinessContactRawAsync(contactId, contact, null, cancellationToken);
        public Task UpdateBusinessContactRawAsync(string contactId, string contact, string queryString) => UpdateBusinessContactRawAsync(contactId, contact, queryString, CancellationToken.None);
        public Task UpdateBusinessContactRawAsync(string contactId, string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return UpdateBusinessContactInternalAsync(contactId, new JsonStringContent(contact), queryString, cancellationToken, response =>
                response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateBusinessContactInternalAsync(string contactId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{contactId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateBusinessContactAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteBusinessContactAsync(string contactId) => DeleteBusinessContactAsync(contactId, CancellationToken.None);
        public async Task<bool> DeleteBusinessContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.DeleteAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }


    }
}
