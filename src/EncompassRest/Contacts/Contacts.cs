using EncompassRest.Utilities;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Contacts
{
    public abstract class Contacts
    {

        private string s_apiPath;

        #region Public Properties
        internal EncompassRestClient Client { get; }
        #endregion

        public Contacts(EncompassRestClient client, string apiPath)
        {
            Client = client;
            s_apiPath = apiPath;
        }

        internal Task<string> GetContactRawInternalAsync(string contactId, CancellationToken cancellationToken) =>
            GetContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsStringAsync());

        internal async Task<T> GetContactInternalAsync<T>(string contactId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(T)}/{contactId}", response).ConfigureAwait(false) : await RestException.CreateAsync($"{nameof(T)}", response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
    }
}
