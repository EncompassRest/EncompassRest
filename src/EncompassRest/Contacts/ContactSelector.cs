using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public abstract class ContactSelector : ApiObject
    {
        internal ContactSelector(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        public Task<List<ContactData>> GetContactListAsync(ContactListParameters parameters, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var queryParameters = new QueryParameters();
            if (start.HasValue)
            {
                queryParameters.Add("start", start.ToString());
            }
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.ToString());
            }

            return PostAsync<List<ContactData>>(null, queryParameters.ToString(), JsonStreamContent.Create(parameters), nameof(GetContactListAsync), null, cancellationToken);
        }

        public Task<string> GetContactListRawAsync(string parameters, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostRawAsync(null, queryString, new JsonStringContent(parameters), nameof(GetContactListRawAsync), null, cancellationToken);
        }
    }
}