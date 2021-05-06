using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Loan.v1
{
    public static class CustomFieldDefinitionsExtensions
    {
        public static ICustomFieldDefinitionsV1? V1 { get; set; }

        private static ICustomFieldDefinitionsV1 GetV1(ICustomFieldDefinitions customFieldDefinitions)
        {
            var v1 = V1;
            if (customFieldDefinitions is CustomFieldDefinitions f)
            {
                v1 = (ICustomFieldDefinitionsV1)f.ExtensionData.GetOrAdd("v1", k => new CustomFieldDefinitionsV1(f.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(customFieldDefinitions, nameof(customFieldDefinitions));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the custom field definition with the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id of the custom field definition to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<CustomFieldDefinition> GetCustomFieldAsync(this ICustomFieldDefinitions customFieldDefinitions, string fieldId, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).GetCustomFieldAsync(fieldId, cancellationToken);

        /// <summary>
        /// Gets the custom field definition with the specified <paramref name="fieldId"/> as raw json.
        /// </summary>
        /// <param name="fieldId">The field id of the custom field definition to get.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCustomFieldRawAsync(this ICustomFieldDefinitions customFieldDefinitions, string fieldId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).GetCustomFieldRawAsync(fieldId, queryString, cancellationToken);

        /// <summary>
        /// Gets all custom field definitions.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<CustomFieldDefinition>> GetCustomFieldsAsync(this ICustomFieldDefinitions customFieldDefinitions, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).GetCustomFieldsAsync(cancellationToken);

        /// <summary>
        /// Gets all custom field definitions as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCustomFieldsRawAsync(this ICustomFieldDefinitions customFieldDefinitions, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).GetCustomFieldsRawAsync(queryString, cancellationToken);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [Obsolete("Undocumented API")]
        public static Task CreateCustomFieldAsync(this ICustomFieldDefinitions customFieldDefinitions, CustomFieldDefinition customField, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).CreateCustomFieldAsync(customField, cancellationToken);

        [Obsolete("Undocumented API")]
        public static Task CreateCustomFieldRawAsync(this ICustomFieldDefinitions customFieldDefinitions, string fieldId, string customField, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).CreateCustomFieldRawAsync(fieldId, customField, queryString, cancellationToken);

        [Obsolete("Undocumented API")]
        public static Task UpdateCustomFieldAsync(this ICustomFieldDefinitions customFieldDefinitions, CustomFieldDefinition customField, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).UpdateCustomFieldAsync(customField, cancellationToken);

        [Obsolete("Undocumented API")]
        public static Task UpdateCustomFieldRawAsync(this ICustomFieldDefinitions customFieldDefinitions, string fieldId, string customField, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).UpdateCustomFieldRawAsync(fieldId, customField, queryString, cancellationToken);

        [Obsolete("Undocumented API")]
        public static Task DeleteCustomFieldAsync(this ICustomFieldDefinitions customFieldDefinitions, string fieldId, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).DeleteCustomFieldAsync(fieldId, cancellationToken);

        [Obsolete("Undocumented API")]
        public static Task<bool> TryDeleteCustomFieldAsync(this ICustomFieldDefinitions customFieldDefinitions, string fieldId, CancellationToken cancellationToken = default) => GetV1(customFieldDefinitions).TryDeleteCustomFieldAsync(fieldId, cancellationToken);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}