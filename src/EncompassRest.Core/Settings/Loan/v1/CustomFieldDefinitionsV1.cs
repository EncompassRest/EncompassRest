﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Loan.v1
{
    /// <summary>
    /// The Loan Custom Fields Apis.
    /// </summary>
    public interface ICustomFieldDefinitionsV1 : IApiObject
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
        Task<string> GetCustomFieldRawAsync(string fieldId, string? queryString = null, CancellationToken cancellationToken = default);
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
        Task<string> GetCustomFieldsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [Obsolete("Undocumented API")]
        Task CreateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default);
        [Obsolete("Undocumented API")]
        Task CreateCustomFieldRawAsync(string fieldId, string customField, string? queryString = null, CancellationToken cancellationToken = default);
        [Obsolete("Undocumented API")]
        Task UpdateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default);
        [Obsolete("Undocumented API")]
        Task UpdateCustomFieldRawAsync(string fieldId, string customField, string? queryString = null, CancellationToken cancellationToken = default);
        [Obsolete("Undocumented API")]
        Task DeleteCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default);
        [Obsolete("Undocumented API")]
        Task<bool> TryDeleteCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }

    internal sealed class CustomFieldDefinitionsV1 : ApiObject, ICustomFieldDefinitionsV1
    {
        internal CustomFieldDefinitionsV1(EncompassRestClient client)
            : base(client, "encompass/v1/settings/loan/customFields")
        {
        }

        public Task<List<CustomFieldDefinition>> GetCustomFieldsAsync(CancellationToken cancellationToken = default) => GetListAsync<CustomFieldDefinition>(null, null, nameof(GetCustomFieldsAsync), null, cancellationToken);

        public Task<string> GetCustomFieldsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetCustomFieldsRawAsync), null, cancellationToken);

        public Task<CustomFieldDefinition> GetCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetAsync<CustomFieldDefinition>(fieldId, null, nameof(GetCustomFieldAsync), fieldId, cancellationToken);
        }

        public Task<string> GetCustomFieldRawAsync(string fieldId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, queryString, nameof(GetCustomFieldRawAsync), fieldId, cancellationToken);
        }

        public Task CreateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(customField, nameof(customField));
            Preconditions.NotNullOrEmpty(customField.Id, $"{nameof(customField)}.{nameof(customField.Id)}");

            return PutAsync(customField.Id, null, JsonStreamContent.Create(customField), nameof(CreateCustomFieldAsync), customField.Id, cancellationToken);
        }

        public Task CreateCustomFieldRawAsync(string fieldId, string customField, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(customField, nameof(customField));

            return PutAsync(fieldId, queryString, new JsonStringContent(customField), nameof(CreateCustomFieldRawAsync), fieldId, cancellationToken);
        }

        public Task UpdateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(customField, nameof(customField));
            Preconditions.NotNullOrEmpty(customField.Id, $"{nameof(customField)}.{nameof(customField.Id)}");

            return PatchAsync(customField.Id, null, JsonStreamContent.Create(customField), nameof(UpdateCustomFieldAsync), customField.Id, cancellationToken);
        }

        public Task UpdateCustomFieldRawAsync(string fieldId, string customField, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(customField, nameof(customField));

            return PatchAsync(fieldId, queryString, JsonStreamContent.Create(customField), nameof(UpdateCustomFieldRawAsync), fieldId, cancellationToken);
        }

        public Task<bool> TryDeleteCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return TryDeleteAsync(fieldId, null, cancellationToken);
        }

        public Task DeleteCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return DeleteAsync(fieldId, null, cancellationToken);
        }
    }
}