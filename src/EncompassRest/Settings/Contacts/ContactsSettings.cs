using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Settings.Contacts
{
    public abstract class ContactsSettings : ApiObject
    {
        internal ContactsSettings(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        public Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(CancellationToken cancellationToken = default) => GetAsync<List<ContactFieldDefinition>>("fieldDefinitions", null, nameof(GetCanonicalNamesAsync), null, cancellationToken);

        public Task<string> GetCanonicalNamesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("fieldDefinitions", queryString, nameof(GetCanonicalNamesRawAsync), null, cancellationToken);
    }
}