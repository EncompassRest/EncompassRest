using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Borrower Contact Selector Api extension methods.
    /// </summary>
    public static class BorrowerContactSelectorExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IBorrowerContactSelectorV1? V1 { get; set; }

        private static IBorrowerContactSelectorV1 GetV1(IBorrowerContactSelector borrowerContactSelector)
        {
            var v1 = V1;
            if (borrowerContactSelector is BorrowerContactSelector c)
            {
                v1 = c.ExtensionData.GetOrAdd(() => new BorrowerContactSelectorV1(c.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(borrowerContactSelector, nameof(borrowerContactSelector));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="borrowerContactSelector">The Borrower Contact Selector Api Object.</param>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<IContactCursor> CreateCursorAsync(this IBorrowerContactSelector borrowerContactSelector, ContactListParameters parameters, CancellationToken cancellationToken = default) => GetV1(borrowerContactSelector).CreateCursorAsync(parameters, cancellationToken);

        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified.
        /// </summary>
        /// <param name="borrowerContactSelector">The Borrower Contact Selector Api Object.</param>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of records to return in a page. Response size is limited to 6 MB and is recalculated if the response exceeds 6 MB. The default value is 1000. The maximum value is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactData>> GetContactListAsync(this IBorrowerContactSelector borrowerContactSelector, ContactListParameters parameters, int? start = null, int? limit = null, CancellationToken cancellationToken = default) => GetV1(borrowerContactSelector).GetContactListAsync(parameters, start, limit, cancellationToken);

        /// <summary>
        /// Retrieves the contact IDs and specified fields for the contacts specified as raw json.
        /// </summary>
        /// <param name="borrowerContactSelector">The Borrower Contact Selector Api Object.</param>
        /// <param name="parameters">The contact list parameters used to specify the contacts and fields to include as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetContactListRawAsync(this IBorrowerContactSelector borrowerContactSelector, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerContactSelector).GetContactListRawAsync(parameters, queryString, cancellationToken);
    }
}