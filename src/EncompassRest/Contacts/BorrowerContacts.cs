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
    public sealed class BorrowerContacts
    {
        private static string s_apiPath = "encompass/v1/BorrowerContacts";

        #region Public Properties
        public EncompassRestClient Client { get; private set; }
        #endregion


        internal BorrowerContacts(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<BorrowerContact> GetBorrowerContactAsync(string contactId) => GetBorrowerContactAsync(contactId, CancellationToken.None);
        public Task<BorrowerContact> GetBorrowerContactAsync(string contactId, CancellationToken cancellationToken) => 
            GetBorrowerContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsAsync<BorrowerContact>());

        public Task<string> GetBorrowerContactRawAsync(string contactId) => GetBorrowerContactRawAsync(contactId, CancellationToken.None);
        public Task<string> GetBorrowerContactRawAsync(string contactId, CancellationToken cancellationToken) =>
            GetBorrowerContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetBorrowerContactInternalAsync<T>(string contactId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(GetBorrowerContactAsync)}/{contactId}", response).ConfigureAwait(false) : await RestException.CreateAsync($"{nameof(GetBorrowerContactAsync)}", response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
        public Task<string> CreateBorrowerContactAsync(BorrowerContact contact) => CreateBorrowerContactAsync(contact, true, CancellationToken.None);
        public Task<string> CreateBorrowerContactAsync(BorrowerContact contact, bool populate) => CreateBorrowerContactAsync(contact, populate, CancellationToken.None);
        public Task<string> CreateBorrowerContactAsync(BorrowerContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));

            return CreateBorrowerContactInternalAsync(JsonStreamContent.Create(contact), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                }
                contact.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }

        public Task<string> CreateBorrowerContactRawAsync(string contact) => CreateBorrowerContactRawAsync(contact, "", CancellationToken.None);
        public Task<string> CreateBorrowerContactRawAsync(string contact, CancellationToken cancellationToken) => CreateBorrowerContactRawAsync(contact, null, cancellationToken);
        public Task<string> CreateBorrowerContactRawAsync(string contact, string queryString) => CreateBorrowerContactRawAsync(contact, queryString, CancellationToken.None);
        public Task<string> CreateBorrowerContactRawAsync(string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return CreateBorrowerContactInternalAsync(new JsonStringContent(contact), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });   
        }
        private async Task<string> CreateBorrowerContactInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateBorrowerContactAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }
        public Task UpdateBorrowerContactAsync(BorrowerContact contact) => UpdateBorrowerContactAsync(contact, false, CancellationToken.None);
        public Task UpdateBorrowerContactAsync(BorrowerContact contact, CancellationToken cancellationToken) => UpdateBorrowerContactAsync(contact, false, cancellationToken);
        public Task UpdateBorrowerContactAsync(BorrowerContact contact, bool populate) => UpdateBorrowerContactAsync(contact, populate, CancellationToken.None);
        public Task UpdateBorrowerContactAsync(BorrowerContact contact, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contact, nameof(contact));

            return UpdateBorrowerContactInternalAsync(contact.Id, JsonStreamContent.Create(contact), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
             {
                 if (populate)
                 {
                     await response.Content.PopulateAsync(contact).ConfigureAwait(false);
                 }
                 contact.Dirty = false;
                 return string.Empty;
             });

        }
        public Task UpdateBorrowerContactRawAsync(string contactId, string contact) => UpdateBorrowerContactRawAsync(contactId, contact, null, CancellationToken.None);
        public Task UpdateBorrowerContactRawAsync(string contactId, string contact, CancellationToken cancellationToken) => UpdateBorrowerContactRawAsync(contactId, contact, null, cancellationToken);
        public Task UpdateBorrowerContactRawAsync(string contactId, string contact, string queryString) => UpdateBorrowerContactRawAsync(contactId, contact, queryString, CancellationToken.None);
        public Task UpdateBorrowerContactRawAsync(string contactId, string contact, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));
            Preconditions.NotNullOrEmpty(contact, nameof(contact));

            return UpdateBorrowerContactInternalAsync(contactId, new JsonStringContent(contact), queryString, cancellationToken, response =>
                response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateBorrowerContactInternalAsync(string contactId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage,Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{contactId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateBorrowerContactAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteBorrowerContactAsync(string contactId) => DeleteBorrowerContactAsync(contactId, CancellationToken.None);
        public async Task<bool> DeleteBorrowerContactAsync(string contactId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.DeleteAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }


    }
}
