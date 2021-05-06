using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    public static class BusinessContactSelectorExtensions
    {
        public static IBusinessContactSelectorV1? V1 { get; set; }

        private static IBusinessContactSelectorV1 GetV1(IBusinessContactSelector businessContactSelector)
        {
            var v1 = V1;
            if (businessContactSelector is BusinessContactSelector c)
            {
                v1 = (IBusinessContactSelectorV1)c.ExtensionData.GetOrAdd("v1", k => new BusinessContactSelectorV1(c.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(businessContactSelector, nameof(businessContactSelector));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<IContactCursor> CreateCursorAsync(this IBusinessContactSelector businessContactSelector, ContactListParameters parameters, CancellationToken cancellationToken = default) => GetV1(businessContactSelector).CreateCursorAsync(parameters, cancellationToken);

        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of records to return in a page. Response size is limited to 6 MB and is recalculated if the response exceeds 6 MB. The default value is 1000. The maximum value is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactData>> GetContactListAsync(this IBusinessContactSelector businessContactSelector, ContactListParameters parameters, int? start = null, int? limit = null, CancellationToken cancellationToken = default) => GetV1(businessContactSelector).GetContactListAsync(parameters, start, limit, cancellationToken);

        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified as raw json.
        /// </summary>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetContactListRawAsync(this IBusinessContactSelector businessContactSelector, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(businessContactSelector).GetContactListRawAsync(parameters, queryString, cancellationToken);
    }
}