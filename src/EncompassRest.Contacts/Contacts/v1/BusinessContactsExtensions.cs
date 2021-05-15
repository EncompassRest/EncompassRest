using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Business Contacts Api extension methods.
    /// </summary>
    public static class BusinessContactsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IBusinessContactsV1? V1 { get; set; }

        private static IBusinessContactsV1 GetV1(IBusinessContacts businessContacts)
        {
            var v1 = V1;
            if (businessContacts is BusinessContacts c)
            {
                v1 = c.ExtensionData.GetOrAdd(() => new BusinessContactsV1(c.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(businessContacts, nameof(businessContacts));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Creates a new contact from raw json and returns the responses body if not empty else its contact id.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contact">The contact to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateContactRawAsync(this IBusinessContacts businessContacts, string contact, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(businessContacts).CreateContactRawAsync(contact, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteContactAsync(this IBusinessContacts businessContacts, string contactId, CancellationToken cancellationToken = default) => GetV1(businessContacts).DeleteContactAsync(contactId, cancellationToken);

        /// <summary>
        /// Retrieves contact information for the specified contact ID as raw json.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetContactRawAsync(this IBusinessContacts businessContacts, string contactId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(businessContacts).GetContactRawAsync(contactId, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteContactAsync(this IBusinessContacts businessContacts, string contactId, CancellationToken cancellationToken = default) => GetV1(businessContacts).TryDeleteContactAsync(contactId, cancellationToken);

        /// <summary>
        /// Updates contact information for the specified contact ID from raw json.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="contact">The contact to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateContactRawAsync(this IBusinessContacts businessContacts, string contactId, string contact, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(businessContacts).UpdateContactRawAsync(contactId, contact, queryString, cancellationToken);

        /// <summary>
        /// Creates a new contact and returns its contact id.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contact">The contact to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateContactAsync(this IBusinessContacts businessContacts, BusinessContact contact, CancellationToken cancellationToken = default) => GetV1(businessContacts).CreateContactAsync(contact, cancellationToken);

        /// <summary>
        /// Retrieves contact information for the specified contact ID.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<BusinessContact> GetContactAsync(this IBusinessContacts businessContacts, string contactId, CancellationToken cancellationToken = default) => GetV1(businessContacts).GetContactAsync(contactId, cancellationToken);

        /// <summary>
        /// Updates contact information for the specified contact ID.
        /// </summary>
        /// <param name="businessContacts">The Business Contacts Api Object.</param>
        /// <param name="contact">The contact to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateContactAsync(this IBusinessContacts businessContacts, BusinessContact contact, CancellationToken cancellationToken = default) => GetV1(businessContacts).UpdateContactAsync(contact, cancellationToken);
    }
}