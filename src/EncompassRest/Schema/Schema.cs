using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Schema
{
    /// <summary>
    /// The Schema Apis.
    /// </summary>
    public interface ISchema : IApiObject
    {
        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GenerateContractAsync(IDictionary<string, object> fieldValues, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GenerateContractAsync(IDictionary<string, object> fieldValues, bool? ignoreInvalidFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates the loan contract as raw json from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GenerateContractRawAsync(string fieldValues, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/>.
        /// </summary>
        /// <param name="fieldIds">The field id's for the paths to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, CancellationToken cancellationToken = default);
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
        Task<string> GeneratePathsRawAsync(string fieldIds, string queryString = null, CancellationToken cancellationToken = default);
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
        Task<string> GetFieldSchemaRawAsync(string fieldId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for all entities.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for all entities and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the loan schema as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLoanSchemaRawAsync(string queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Schema Apis.
    /// </summary>
    public sealed class Schema : ApiObject, ISchema
    {
        internal Schema(EncompassRestClient client)
            : base(client, "encompass/v1/schema/loan")
        {
        }

        /// <summary>
        /// Gets the loan schema for all entities.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetLoanSchemaAsync(CancellationToken cancellationToken = default) => GetLoanSchemaAsync(false, (IEnumerable<string>)null, cancellationToken);

        /// <summary>
        /// Gets the loan schema for all entities and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(includeFieldExtensions, (IEnumerable<string>)null, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(false, entities, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(false, entities, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(includeFieldExtensions, entities?.Select(e => e.Validate(nameof(entities)).GetName()), cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            return GetAsync<LoanSchema>(null, queryParameters.ToString(), nameof(GetLoanSchemaAsync), null, cancellationToken);
        }

        /// <summary>
        /// Gets the loan schema as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetLoanSchemaRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLoanSchemaRawAsync), null, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetAsync<LoanSchema>(fieldId, null, nameof(GetFieldSchemaAsync), fieldId, cancellationToken);
        }

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="fieldId"/> as raw json.
        /// </summary>
        /// <param name="fieldId">The field id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetFieldSchemaRawAsync(string fieldId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, queryString, nameof(GetFieldSchemaRawAsync), fieldId, cancellationToken);
        }

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/>.
        /// </summary>
        /// <param name="fieldIds">The field id's for the paths to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, CancellationToken cancellationToken = default) => GeneratePathsAsync(fieldIds, null, null, cancellationToken);

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/> and optionally ignores invalid fields.
        /// </summary>
        /// <param name="fieldIds">The field id's for the paths to get.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GeneratePathsAsync(fieldIds, null, ignoreInvalidFields, cancellationToken);

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes that match the specified <paramref name="fieldNamePattern"/>.
        /// </summary>
        /// <param name="fieldNamePattern">Specifies the pattern of field name to search.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Dictionary<string, string>> GeneratePathsAsync(string fieldNamePattern, CancellationToken cancellationToken = default) => GeneratePathsAsync(null, fieldNamePattern, null, cancellationToken);

        private Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, string fieldNamePattern, bool? ignoreInvalidFields, CancellationToken cancellationToken)
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

            return PostAsync<Dictionary<string, string>>("pathGenerator", queryParameters.ToString(), JsonStreamContent.Create(fieldIds ?? new string[0]), nameof(GeneratePathsAsync), null, cancellationToken);
        }

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/> or field name pattern as raw json.
        /// </summary>
        /// <param name="fieldIds">The field id's for the paths to get as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GeneratePathsRawAsync(string fieldIds, string queryString = null, CancellationToken cancellationToken = default) => PostRawAsync("pathGenerator", queryString, string.IsNullOrEmpty(fieldIds) ? null : new JsonStringContent(fieldIds), nameof(GeneratePathsRawAsync), null, cancellationToken);

        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Loan> GenerateContractAsync(IDictionary<string, object> fieldValues, CancellationToken cancellationToken = default) => GenerateContractAsync(fieldValues, null, cancellationToken);

        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<Loan> GenerateContractAsync(IDictionary<string, object> fieldValues, bool? ignoreInvalidFields, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldValues, nameof(fieldValues));

            var queryParameters = new QueryParameters();
            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }

            var loan = await PostAsync<Loan>("contractGenerator", queryParameters.ToString(), JsonStreamContent.Create(fieldValues), nameof(GenerateContractAsync), null, cancellationToken).ConfigureAwait(false);
            loan.Client = Client;
            return loan;
        }

        /// <summary>
        /// Generates the loan contract as raw json from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GenerateContractRawAsync(string fieldValues, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldValues, nameof(fieldValues));

            return PostRawAsync("contractGenerator", queryString, new JsonStringContent(fieldValues), nameof(GenerateContractRawAsync), null, cancellationToken);
        }
    }
}