using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
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


        public BorrowerContacts(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<BorrowerContact> GetBorrowerContactAsync(string contactId) => GetBorrowerContactAsync(contactId, CancellationToken.None);
        public Task<BorrowerContact> GetBorrowerContactAsync(string contactId, CancellationToken cancellationToken) => 
            GetBorrowerContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsAsync<BorrowerContact>());

        public Task<string> GetBorrowerContactRawAsync(string contactId) => GetBorrowerContactRawAsync(contactId, CancellationToken.None);
        public Task<string> GetBorrowerContactRawAsync(string contactId, CancellationToken cancellationToken) =>
            GetBorrowerContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsStringAsync());

        internal async Task<T> GetBorrowerContactInternalAsync<T>(string contactId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
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
    }
}
