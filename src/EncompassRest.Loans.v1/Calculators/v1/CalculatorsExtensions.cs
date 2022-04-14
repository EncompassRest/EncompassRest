using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Calculators.v1
{
    /// <summary>
    /// The Calculators Api extension methods.
    /// </summary>
    public static class CalculatorsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ICalculatorsV1? V1 { get; set; }

        private static ICalculatorsV1 GetV1(ICalculators calculators)
        {
            var v1 = V1;
            if (calculators is Calculators c)
            {
                v1 = c.ExtensionData.GetOrAdd(() => new CalculatorsV1(c.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(calculators, nameof(calculators));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, (IEnumerable<string>?)null, null, cancellationToken);

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, entities, null, cancellationToken);

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, entities, null, cancellationToken);

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="calcAllOnly">Indicates whether calculations will be executed for all fields. The default is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, bool? calcAllOnly, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, (IEnumerable<string>?)null, calcAllOnly, cancellationToken);

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="calcAllOnly">Indicates whether calculations will be executed for all fields. The default is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<LoanEntity>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, entities?.Select(e => e.Validate(nameof(entities)).GetValue()), calcAllOnly, cancellationToken);

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="calcAllOnly">Indicates whether calculations will be executed for all fields. The default is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<string>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default) => GetV1(calculators).CalculateLoanAsync(loan, entities, calcAllOnly, cancellationToken);

        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="calculators">The Calculators Api Object.</param>
        /// <param name="body">The request body as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns>The loan with calculations performed as raw json.</returns>
        public static Task<string> CalculateLoanRawAsync(this ICalculators calculators, string body, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(calculators).CalculateLoanRawAsync(body, queryString, cancellationToken);
    }
}