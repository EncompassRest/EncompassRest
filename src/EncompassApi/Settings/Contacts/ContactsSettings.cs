using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassApi.Settings.Contacts
{
    /// <summary>
    /// Base Contacts Settings Apis.
    /// </summary>
    public interface IContactsSettings : IApiObject
    {
        /// <summary>
        /// Returns a list of canonical field names for contact fields.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of canonical field names for contact fields as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetCanonicalNamesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Base Contacts Settings Apis.
    /// </summary>
    public abstract class ContactsSettings : ApiObject, IContactsSettings
    {
        internal ContactsSettings(IEncompassApiClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        /// <inheritdoc/>
        public Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(CancellationToken cancellationToken = default) => GetAsync<List<ContactFieldDefinition>>("fieldDefinitions", null, nameof(GetCanonicalNamesAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetCanonicalNamesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("fieldDefinitions", queryString, nameof(GetCanonicalNamesRawAsync), null, cancellationToken);
    }
}