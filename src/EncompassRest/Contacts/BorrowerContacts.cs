using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContacts : Contacts
    {
        private static string s_apiPath = "encompass/v1/BorrowerContacts";
        public BorrowerContacts(EncompassRestClient client) : base(client,s_apiPath){ }

        public Task<BorrowerContact> GetBorrowerContactAsync(string contactId) => GetBorrowerContactAsync(contactId, CancellationToken.None);
        public Task<BorrowerContact> GetBorrowerContactAsync(string contactId, CancellationToken cancellationToken) => 
            GetContactInternalAsync(contactId, cancellationToken, response => response.Content.ReadAsAsync<BorrowerContact>());

        public Task<string> GetBorrowerContactRawAsync(string contactId) => GetBorrowerContactRawAsync(contactId, CancellationToken.None);
        public Task<string> GetBorrowerContactRawAsync(string contactId, CancellationToken cancellationToken) =>
            GetContactRawInternalAsync(contactId, cancellationToken);
    }
}
