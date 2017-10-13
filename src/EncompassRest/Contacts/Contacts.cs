using EncompassRest.Utilities;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Contacts
{
    public enum ContactType
    {
        Borrower,
        Businesss
    }

    public sealed class Contacts
    {
        private const string s_apiPath = "encompass/v1/{ContactType}Contacts";

        #region Public Properties
        public EncompassRestClient Client { get; }
        #endregion

        internal Contacts(EncompassRestClient client)
        {
            Client = client;
        }

        virtual async Task<T> GetContactAsync<T>(string contactId, ContactType contactType, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            return GetContactInternalAsync(contactId, contactType, cancellationToken, resposne =>
            {
                var contact = new T(Client, contact);

            });
        }

        private async Task<T> GetContactInternalAsync<T>(string contactId, ContactType contactType, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath.Replace("{ContactType}", contactType.ToString())}/{contactId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? await NotFoundException.CreateAsync($"{nameof(GetContactAsync)}/{contactId}", response).ConfigureAwait(false) : await RestException.CreateAsync(nameof(GetContactAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
    }
}
