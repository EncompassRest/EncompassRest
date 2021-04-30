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
    /// The Schema Apis.
    /// </summary>
    public static class SchemaExtensions
    {
        public static ISchemaV1? V1 { get; set; }

        private static ISchemaV1 GetV1(ISchema schema)
        {
            var v1 = V1;
            if (schema is Schema s)
            {
                v1 = (ISchemaV1)s.ExtensionData.GetOrAdd("v1", k => new SchemaV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(schema, nameof(schema));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <inheritdoc/>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, (IEnumerable<string>?)null, cancellationToken);

        /// <inheritdoc/>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, includeFieldExtensions, (IEnumerable<string>?)null, cancellationToken);

        /// <inheritdoc/>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, entities, cancellationToken);

        /// <inheritdoc/>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, entities, cancellationToken);

        /// <inheritdoc/>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, includeFieldExtensions, entities?.Select(e => e.Validate(nameof(entities)).GetName()!), cancellationToken);

        /// <inheritdoc/>
        public static Task<LoanSchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetV1(schema).GetLoanSchemaAsync(includeFieldExtensions, entities, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GetLoanSchemaRawAsync(this ISchema schema, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GetLoanSchemaRawAsync(queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<LoanSchema> GetFieldSchemaAsync(this ISchema schema, string fieldId, CancellationToken cancellationToken = default) => GetV1(schema).GetFieldSchemaAsync(fieldId, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GetFieldSchemaRawAsync(this ISchema schema, string fieldId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GetFieldSchemaRawAsync(fieldId, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<Dictionary<string, string>> GeneratePathsAsync(this ISchema schema, IEnumerable<string> fieldIds, CancellationToken cancellationToken = default) => GeneratePathsAsync(schema, fieldIds, null, cancellationToken);

        /// <inheritdoc/>
        public static Task<Dictionary<string, string>> GeneratePathsAsync(this ISchema schema, IEnumerable<string> fieldIds, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GetV1(schema).GeneratePathsAsync(fieldIds, ignoreInvalidFields, cancellationToken);

        /// <inheritdoc/>
        public static Task<Dictionary<string, string>> GeneratePathsAsync(this ISchema schema, string fieldNamePattern, CancellationToken cancellationToken = default) => GetV1(schema).GeneratePathsAsync(fieldNamePattern, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GeneratePathsRawAsync(this ISchema schema, string fieldIds, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GeneratePathsRawAsync(fieldIds, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<Loan> GenerateContractAsync(this ISchema schema, IDictionary<string, object> fieldValues, CancellationToken cancellationToken = default) => GenerateContractAsync(schema, fieldValues, null, cancellationToken);

        /// <inheritdoc/>
        public static Task<Loan> GenerateContractAsync(this ISchema schema, IDictionary<string, object> fieldValues, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GetV1(schema).GenerateContractAsync(fieldValues, ignoreInvalidFields, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GenerateContractRawAsync(this ISchema schema, string fieldValues, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(schema).GenerateContractRawAsync(fieldValues, queryString, cancellationToken);
    }
}