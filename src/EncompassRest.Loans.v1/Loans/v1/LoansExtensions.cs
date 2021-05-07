using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Loans Apis.
    /// </summary>
    public static class LoansExtensions
    {
        public static ILoansV1? V1 { get; set; }

        private static ILoansV1 GetV1(ILoans loans)
        {
            var v1 = V1;
            if (loans is Loans l)
            {
                v1 = (ILoansV1)l.ExtensionData.GetOrAdd("v1", k => new LoansV1(l.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loans, nameof(loans));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the loan field descriptors.
        /// </summary>
        /// <param name="loans"></param>
        /// <returns></returns>
        public static ILoanFieldDescriptors GetFieldDescriptors(this ILoans loans) => GetV1(loans).FieldDescriptors;

        internal static ILoanObjectBoundApis GetLoanApis(this ILoans loans, Loan loan) => GetV1(loans).GetLoanApis(loan);

        /// <inheritdoc/>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetLoanAsync(loans, loanId, (IEnumerable<string>?)null, cancellationToken);

        /// <inheritdoc/>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanAsync(loans, loanId, entities?.Select(e => e.Validate(nameof(entities)).GetValue()!), cancellationToken);

        /// <inheritdoc/>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetV1(loans).GetLoanAsync(loanId, entities, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GetLoanRawAsync(this ILoans loans, string loanId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).GetLoanRawAsync(loanId, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(this ILoans loans, CancellationToken cancellationToken = default) => GetV1(loans).GetSupportedEntitiesAsync(cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GetSupportedEntitiesRawAsync(this ILoans loans, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).GetSupportedEntitiesRawAsync(queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, CancellationToken cancellationToken = default) => CreateLoanAsync(loans, loan, null, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, bool populate, CancellationToken cancellationToken = default) => CreateLoanAsync(loans, loan, new CreateLoanOptions { Populate = populate }, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, CreateLoanOptions? createLoanOptions, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanAsync(loan, createLoanOptions, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanRawAsync(this ILoans loans, string loan, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanRawAsync(loan, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, CancellationToken cancellationToken = default) => UpdateLoanAsync(loans, loan, null, cancellationToken);

        /// <inheritdoc/>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, bool populate, CancellationToken cancellationToken = default) => UpdateLoanAsync(loans, loan, new UpdateLoanOptions { Populate = populate }, cancellationToken);

        /// <inheritdoc/>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, UpdateLoanOptions? updateLoanOptions, CancellationToken cancellationToken = default) => GetV1(loans).UpdateLoanAsync(loan, updateLoanOptions, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> UpdateLoanRawAsync(this ILoans loans, string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).UpdateLoanRawAsync(loanId, loan, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task DeleteLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetV1(loans).DeleteLoanAsync(loanId, cancellationToken);

        /// <inheritdoc/>
        public static Task<bool> TryDeleteLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetV1(loans).TryDeleteLoanAsync(loanId, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => CreateLoanFromImportFileAsync(loans, importFileType.Validate(nameof(importFileType)).GetValue()!, importFile, createLoanOptions, out loan, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => CreateLoanFromImportFileAsync(loans, importFileType.Validate(nameof(importFileType)).GetValue()!, importFile, createLoanOptions, out loan, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out loan, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out loan, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileRawAsync(this ILoans loans, string importFileType, string importFile, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileRawAsync(importFileType, importFile, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> CreateLoanFromImportFileRawAsync(this ILoans loans, string importFileType, Stream importFile, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileRawAsync(importFileType, importFile, queryString, cancellationToken);
    }
}