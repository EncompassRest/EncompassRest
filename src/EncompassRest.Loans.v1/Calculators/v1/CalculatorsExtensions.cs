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
    /// The Calculators Apis.
    /// </summary>
    public static class CalculatorsExtensions
    {
        public static ICalculatorsV1? V1 { get; set; }

        private static ICalculatorsV1 GetV1(ICalculators calculators)
        {
            var v1 = V1;
            if (calculators is Calculators c)
            {
                v1 = (ICalculatorsV1)c.ExtensionData.GetOrAdd("v1", k => new CalculatorsV1(c.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(calculators, nameof(calculators));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <inheritdoc/>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, (IEnumerable<string>?)null, null, cancellationToken);

        /// <inheritdoc/>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, entities, null, cancellationToken);

        /// <inheritdoc/>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, entities, null, cancellationToken);

        /// <inheritdoc/>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, bool? calcAllOnly, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, (IEnumerable<string>?)null, calcAllOnly, cancellationToken);

        /// <inheritdoc/>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<LoanEntity>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default) => CalculateLoanAsync(calculators, loan, entities?.Select(e => e.Validate(nameof(entities)).GetValue()!), calcAllOnly, cancellationToken);

        /// <inheritdoc/>
        public static Task CalculateLoanAsync(this ICalculators calculators, Loan loan, IEnumerable<string>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default) => GetV1(calculators).CalculateLoanAsync(loan, entities, calcAllOnly, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CalculateLoanRawAsync(this ICalculators calculators, string body, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(calculators).CalculateLoanRawAsync(body, queryString, cancellationToken);
    }
}