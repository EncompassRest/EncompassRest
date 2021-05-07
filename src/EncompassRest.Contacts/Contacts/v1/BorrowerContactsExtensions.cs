using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    public static class BorrowerContactsExtensions
    {
        public static IBorrowerContactsV1? V1 { get; set; }

        private static IBorrowerContactsV1 GetV1(IBorrowerContacts borrowerContacts)
        {
            var v1 = V1;
            if (borrowerContacts is BorrowerContacts c)
            {
                v1 = (IBorrowerContactsV1)c.ExtensionData.GetOrAdd("v1", k => new BorrowerContactsV1(c.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(borrowerContacts, nameof(borrowerContacts));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Creates a new contact from raw json and returns the responses body if not empty else its contact id.
        /// </summary>
        /// <param name="contact">The contact to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateContactRawAsync(this IBorrowerContacts borrowerContacts, string contact, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).CreateContactRawAsync(contact, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteContactAsync(this IBorrowerContacts borrowerContacts, string contactId, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).DeleteContactAsync(contactId, cancellationToken);

        /// <summary>
        /// Retrieves contact information for the specified contact ID as raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetContactRawAsync(this IBorrowerContacts borrowerContacts, string contactId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).GetContactRawAsync(contactId, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified contact.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteContactAsync(this IBorrowerContacts borrowerContacts, string contactId, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).TryDeleteContactAsync(contactId, cancellationToken);

        /// <summary>
        /// Updates contact information for the specified contact ID from raw json.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="contact">The contact to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateContactRawAsync(this IBorrowerContacts borrowerContacts, string contactId, string contact, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).UpdateContactRawAsync(contactId, contact, queryString, cancellationToken);

        /// <summary>
        /// Creates a new contact and returns its contact id.
        /// </summary>
        /// <param name="contact">The contact to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateContactAsync(this IBorrowerContacts borrowerContacts, BorrowerContact contact, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).CreateContactAsync(contact, cancellationToken);

        /// <summary>
        /// Retrieves contact information for the specified contact ID.
        /// </summary>
        /// <param name="contactId">The unique identifier that is returned in the response when the contact is created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<BorrowerContact> GetContactAsync(this IBorrowerContacts borrowerContacts, string contactId, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).GetContactAsync(contactId, cancellationToken);

        /// <summary>
        /// Updates contact information for the specified contact ID.
        /// </summary>
        /// <param name="contact">The contact to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateContactAsync(this IBorrowerContacts borrowerContacts, BorrowerContact contact, CancellationToken cancellationToken = default) => GetV1(borrowerContacts).UpdateContactAsync(contact, cancellationToken);
    }
}