using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// The Schema Apis.
    /// </summary>
    public interface ISchemaCoreV1 : IApiObject
    {
        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/> and optionally ignores invalid fields.
        /// </summary>
        /// <param name="fieldIds">The field id's for the paths to get.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, bool? ignoreInvalidFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the paths to be used in webhook filter attributes that match the specified <paramref name="fieldNamePattern"/>.
        /// </summary>
        /// <param name="fieldNamePattern">Specifies the pattern of field name to search.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Dictionary<string, string>> GeneratePathsAsync(string fieldNamePattern, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/> or field name pattern as raw json.
        /// </summary>
        /// <param name="fieldIds">The field id's for the paths to get as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GeneratePathsRawAsync(string fieldIds, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetFieldSchemaAsync(string fieldId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="fieldId"/> as raw json.
        /// </summary>
        /// <param name="fieldId">The field id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetFieldSchemaRawAsync(string fieldId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLoanSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class SchemaCoreV1 : ApiObject, ISchemaCoreV1
    {
        internal SchemaCoreV1(EncompassRestClient client)
            : base(client, "encompass/v1/schema/loan")
        {
        }

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            return GetAsync<LoanSchema>(null, queryParameters.ToString(), nameof(GetLoanSchemaAsync), null, cancellationToken);
        }

        public Task<string> GetLoanSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLoanSchemaRawAsync), null, cancellationToken);

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetAsync<LoanSchema>(fieldId, null, nameof(GetFieldSchemaAsync), fieldId, cancellationToken);
        }

        public Task<string> GetFieldSchemaRawAsync(string fieldId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, queryString, nameof(GetFieldSchemaRawAsync), fieldId, cancellationToken);
        }

        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GeneratePathsAsync(fieldIds, null, ignoreInvalidFields, cancellationToken);

        public Task<Dictionary<string, string>> GeneratePathsAsync(string fieldNamePattern, CancellationToken cancellationToken = default) => GeneratePathsAsync(null, fieldNamePattern, null, cancellationToken);

        private Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string>? fieldIds, string? fieldNamePattern, bool? ignoreInvalidFields, CancellationToken cancellationToken)
        {
            var queryParameters = new QueryParameters();
            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }
            if (!string.IsNullOrEmpty(fieldNamePattern))
            {
                queryParameters.Add("fieldNamePattern", fieldNamePattern);
            }

            return PostAsync<Dictionary<string, string>>("pathGenerator", queryParameters.ToString(), JsonStreamContent.Create(fieldIds ?? Array<string>.Empty), nameof(GeneratePathsAsync), null, cancellationToken);
        }

        public Task<string> GeneratePathsRawAsync(string fieldIds, string? queryString = null, CancellationToken cancellationToken = default) => PostRawAsync("encompass/v1/schema/loan/pathGenerator", queryString, string.IsNullOrEmpty(fieldIds) ? null : new JsonStringContent(fieldIds), nameof(GeneratePathsRawAsync), null, cancellationToken);
    }
}