using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Contacts.v1
{
    /// <summary>
    /// The Borrower Contacts Settings Api extension methods.
    /// </summary>
    public static class BorrowerContactsSettingsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IBorrowerContactsSettingsV1? V1 { get; set; }

        private static IBorrowerContactsSettingsV1 GetV1(IBorrowerContactsSettings borrowerContactSettings)
        {
            var v1 = V1;
            if (borrowerContactSettings is BorrowerContactsSettings s)
            {
                v1 = s.ExtensionData.GetOrAdd(() => new BorrowerContactsSettingsV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(borrowerContactSettings, nameof(borrowerContactSettings));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Returns a list of canonical field names for contact fields.
        /// </summary>
        /// <param name="borrowerContactsSettings">The Borrower Contacts Settings Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(this IBorrowerContactsSettings borrowerContactsSettings, CancellationToken cancellationToken = default) => GetV1(borrowerContactsSettings).GetCanonicalNamesAsync(cancellationToken);

        /// <summary>
        /// Returns a list of canonical field names for contact fields as raw json.
        /// </summary>
        /// <param name="borrowerContactsSettings">The Borrower Contacts Settings Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCanonicalNamesRawAsync(this IBorrowerContactsSettings borrowerContactsSettings, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerContactsSettings).GetCanonicalNamesRawAsync(queryString, cancellationToken);
    }
}