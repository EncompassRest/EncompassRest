using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Loan
{
    /// <summary>
    /// The Loan Custom Fields Apis.
    /// </summary>
    public interface ICustomFieldDefinitions : IApiObject
    {
        /// <summary>
        /// Gets the custom field definition with the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id of the custom field definition to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<CustomFieldDefinition> GetCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the custom field definition with the specified <paramref name="fieldId"/> as raw json.
        /// </summary>
        /// <param name="fieldId">The field id of the custom field definition to get.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetCustomFieldRawAsync(string fieldId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets all custom field definitions.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<CustomFieldDefinition>> GetCustomFieldsAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets all custom field definitions as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetCustomFieldsRawAsync(string queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Custom Fields Apis.
    /// </summary>
    public sealed class CustomFieldDefinitions : ApiObject, ICustomFieldDefinitions
    {
        internal CustomFieldDefinitions(EncompassRestClient client)
            : base(client, "encompass/v1/settings/loan/customFields")
        {
        }

        /// <summary>
        /// Gets all custom field definitions.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<CustomFieldDefinition>> GetCustomFieldsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<CustomFieldDefinition>(null, null, nameof(GetCustomFieldsAsync), null, cancellationToken);

        /// <summary>
        /// Gets all custom field definitions as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetCustomFieldsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetCustomFieldsRawAsync), null, cancellationToken);

        /// <summary>
        /// Gets the custom field definition with the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id of the custom field definition to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<CustomFieldDefinition> GetCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetDirtyAsync<CustomFieldDefinition>(fieldId, null, nameof(GetCustomFieldAsync), fieldId, cancellationToken);
        }

        /// <summary>
        /// Gets the custom field definition with the specified <paramref name="fieldId"/> as raw json.
        /// </summary>
        /// <param name="fieldId">The field id of the custom field definition to get.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetCustomFieldRawAsync(string fieldId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, queryString, nameof(GetCustomFieldRawAsync), fieldId, cancellationToken);
        }

        internal Task CreateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(customField, nameof(customField));
            Preconditions.NotNullOrEmpty(customField.Id, $"{nameof(customField)}.{nameof(customField.Id)}");

            return PutAsync(customField.Id, null, JsonStreamContent.Create(customField), nameof(CreateCustomFieldAsync), customField.Id, cancellationToken);
        }

        internal Task CreateCustomFieldRawAsync(string fieldId, string customField, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(customField, nameof(customField));

            return PutAsync(fieldId, queryString, new JsonStringContent(customField), nameof(CreateCustomFieldRawAsync), fieldId, cancellationToken);
        }

        internal Task UpdateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(customField, nameof(customField));
            Preconditions.NotNullOrEmpty(customField.Id, $"{nameof(customField)}.{nameof(customField.Id)}");

            return PatchAsync(customField.Id, null, JsonStreamContent.Create(customField), nameof(UpdateCustomFieldAsync), customField.Id, cancellationToken);
        }

        internal Task UpdateCustomFieldRawAsync(string fieldId, string customField, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(customField, nameof(customField));

            return PatchAsync(fieldId, queryString, JsonStreamContent.Create(customField), nameof(UpdateCustomFieldRawAsync), fieldId, cancellationToken);
        }

        internal Task<bool> DeleteCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return DeleteAsync(fieldId, null, cancellationToken);
        }
    }
}