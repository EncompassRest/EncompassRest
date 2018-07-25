using System.Collections.Generic;
using System.Linq;
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

        public Task<ContactCursor> CreateCursorAsync(ContactListParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var queryParameters = new QueryParameters(
                new QueryParameter("limit", "1"),
                new QueryParameter("cursorType", "randomAccess"));

            return PostAsync(null, queryParameters.ToString(), JsonStreamContent.Create(parameters), nameof(CreateCursorAsync), null, cancellationToken, async response =>
            {
                var headers = response.Headers;
                const string countHeaderName = "x-total-count";
                if (!headers.TryGetValues(countHeaderName, out var counts))
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {countHeaderName} header", response).ConfigureAwait(false);
                }
                var countString = counts.First();
                if (!int.TryParse(countString, out var count) || count < 0)
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} invalid {countHeaderName} header value", response).ConfigureAwait(false);
                }
                string cursorId = null;
                if (count > 0)
                {
                    const string cursorIdHeaderName = "x-cursor";
                    if (!headers.TryGetValues(cursorIdHeaderName, out var cursorIds))
                    {
                        throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {cursorIdHeaderName} header", response).ConfigureAwait(false);
                    }
                    cursorId = cursorIds.First();
                }
                return new ContactCursor(this, Client, cursorId, count, parameters.Fields);
            });
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