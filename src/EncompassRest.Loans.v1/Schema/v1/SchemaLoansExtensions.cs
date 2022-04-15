using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// The Schema Api extension methods.
    /// </summary>
    public static class SchemaLoansExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ISchemaLoansV1? V1 { get; set; }

        private static ISchemaLoansV1 GetV1(ISchema schema)
        {
            var v1 = V1;
            if (schema is Schema s)
            {
                v1 = s.ExtensionData.GetOrAdd(() => new SchemaLoansV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(schema, nameof(schema));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

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