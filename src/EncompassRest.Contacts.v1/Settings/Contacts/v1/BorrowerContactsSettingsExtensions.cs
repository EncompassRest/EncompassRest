using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Contacts.v1
{
    public static class BorrowerContactsSettingsExtensions
    {
        public static IBorrowerContactsSettingsV1? V1 { get; set; }

        private static IBorrowerContactsSettingsV1 GetV1(IBorrowerContactsSettings borrowerContactSettings)
        {
            var v1 = V1;
            if (borrowerContactSettings is BorrowerContactsSettings s)
            {
                v1 = (IBorrowerContactsSettingsV1)s.ExtensionData.GetOrAdd("v1", k => new BorrowerContactsSettingsV1(s.Client));
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(this IBorrowerContactsSettings borrowerContactsSettings, CancellationToken cancellationToken = default) => GetV1(borrowerContactsSettings).GetCanonicalNamesAsync(cancellationToken);

        /// <summary>
        /// Returns a list of canonical field names for contact fields as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCanonicalNamesRawAsync(this IBorrowerContactsSettings borrowerContactsSettings, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerContactsSettings).GetCanonicalNamesRawAsync(queryString, cancellationToken);
    }
}