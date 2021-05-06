using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Settings.Contacts.v1
{
    /// <summary>
    /// Base Contacts Settings Apis.
    /// </summary>
    public interface IContactsSettingsV1 : IApiObject
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

    internal abstract class ContactsSettingsV1 : ApiObject, IContactsSettingsV1
    {
        internal ContactsSettingsV1(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        public Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(CancellationToken cancellationToken = default) => GetAsync<List<ContactFieldDefinition>>("fieldDefinitions", null, nameof(GetCanonicalNamesAsync), null, cancellationToken);

        public Task<string> GetCanonicalNamesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("fieldDefinitions", queryString, nameof(GetCanonicalNamesRawAsync), null, cancellationToken);
    }
}