using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Base Contact Selector Apis.
    /// </summary>
    public interface IContactSelector : IApiObject
    {
        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<IContactCursor> CreateCursorAsync(ContactListParameters parameters, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of records to return in a page. Response size is limited to 6 MB and is recalculated if the response exceeds 6 MB. The default value is 1000. The maximum value is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ContactData>> GetContactListAsync(ContactListParameters parameters, int? start = null, int? limit = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified as raw json.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetContactListRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Base Contact Selector Apis.
    /// </summary>
    public abstract class ContactSelector : ApiObject, IContactSelector
    {
        internal ContactSelector(IEncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
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
                string? cursorId = null;
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

        async Task<IContactCursor> IContactSelector.CreateCursorAsync(ContactListParameters parameters, CancellationToken cancellationToken) => await CreateCursorAsync(parameters, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of records to return in a page. Response size is limited to 6 MB and is recalculated if the response exceeds 6 MB. The default value is 1000. The maximum value is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified as raw json.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetContactListRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostRawAsync(null, queryString, new JsonStringContent(parameters), nameof(GetContactListRawAsync), null, cancellationToken);
        }
    }
}