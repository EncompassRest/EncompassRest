using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// The Schema Api extension methods.
    /// </summary>
    public static class SchemaExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ISchemaV1? V1 { get; set; }

        private static ISchemaV1 GetV1(ISchema schema)
        {
            var v1 = V1;
            if (schema is Schema s)
            {
                v1 = s.ExtensionData.GetOrAdd(() => new SchemaV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(schema, nameof(schema));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the loan schema for all entities.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, (IEnumerable<string>?)null, cancellationToken);

        /// <summary>
        /// Gets the loan schema for all entities and optionally includes field extensions.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, includeFieldExtensions, (IEnumerable<string>?)null, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, entities, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, entities, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, includeFieldExtensions, entities?.Select(e => e.Validate(nameof(entities)).GetName()!), cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="includeFieldExtensions">Include field extensions.</param>
        /// <param name="entities">Entities to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetV1(schema).GetLoanSchemaAsync(includeFieldExtensions, entities, cancellationToken);

        /// <summary>
        /// Gets the loan schema as raw json.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLoanSchemaRawAsync(this ISchema schema, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GetLoanSchemaRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldId">The field id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanSchema> GetFieldSchemaAsync(this ISchema schema, string fieldId, CancellationToken cancellationToken = default) => GetV1(schema).GetFieldSchemaAsync(fieldId, cancellationToken);

        /// <summary>
        /// Gets the loan schema for the specified <paramref name="fieldId"/> as raw json.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldId">The field id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetFieldSchemaRawAsync(this ISchema schema, string fieldId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GetFieldSchemaRawAsync(fieldId, queryString, cancellationToken);

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldIds">The field id's for the paths to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Dictionary<string, string>> GeneratePathsAsync(this ISchema schema, IEnumerable<string> fieldIds, CancellationToken cancellationToken = default) => GeneratePathsAsync(schema, fieldIds, null, cancellationToken);

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/> and optionally ignores invalid fields.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldIds">The field id's for the paths to get.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Dictionary<string, string>> GeneratePathsAsync(this ISchema schema, IEnumerable<string> fieldIds, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GetV1(schema).GeneratePathsAsync(fieldIds, ignoreInvalidFields, cancellationToken);

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes that match the specified <paramref name="fieldNamePattern"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldNamePattern">Specifies the pattern of field name to search.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Dictionary<string, string>> GeneratePathsAsync(this ISchema schema, string fieldNamePattern, CancellationToken cancellationToken = default) => GetV1(schema).GeneratePathsAsync(fieldNamePattern, cancellationToken);

        /// <summary>
        /// Gets the paths to be used in webhook filter attributes for the specified <paramref name="fieldIds"/> or field name pattern as raw json.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldIds">The field id's for the paths to get as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GeneratePathsRawAsync(this ISchema schema, string fieldIds, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GeneratePathsRawAsync(fieldIds, queryString, cancellationToken);

        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Loan> GenerateContractAsync(this ISchema schema, IDictionary<string, object> fieldValues, CancellationToken cancellationToken = default) => GenerateContractAsync(schema, fieldValues, null, cancellationToken);

        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Loan> GenerateContractAsync(this ISchema schema, IDictionary<string, object> fieldValues, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GetV1(schema).GenerateContractAsync(fieldValues, ignoreInvalidFields, cancellationToken);

        /// <summary>
        /// Generates the loan contract as raw json from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="schema">The Schema Api Object.</param>
        /// <param name="fieldValues">The field values to generate the loan contract as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GenerateContractRawAsync(this ISchema schema, string fieldValues, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GenerateContractRawAsync(fieldValues, queryString, cancellationToken);
    }
}