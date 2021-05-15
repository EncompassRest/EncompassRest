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
    /// The Loans Api extension methods.
    /// </summary>
    public static class LoansExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoansV1? V1 { get; set; }

        private static ILoansV1 GetV1(ILoans loans)
        {
            var v1 = V1;
            if (loans is Loans l)
            {
                v1 = l.ExtensionData.GetOrAdd(() => new LoansV1(l.Client));
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
        /// <param name="loans">The Loans Api Object.</param>
        /// <returns></returns>
        public static ILoanFieldDescriptors GetFieldDescriptors(this ILoans loans) => GetV1(loans).FieldDescriptors;

        internal static ILoanObjectBoundApis GetLoanApis(this ILoans loans, Loan loan) => GetV1(loans).GetLoanApis(loan);

        /// <summary>
        /// Returns the entire loan.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetLoanAsync(loans, loanId, (IEnumerable<string>?)null, cancellationToken);

        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="entities">The list of loan entities to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanAsync(loans, loanId, entities?.Select(e => e.Validate(nameof(entities)).GetValue()!), cancellationToken);

        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="entities">The list of loan entities to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetV1(loans).GetLoanAsync(loanId, entities, cancellationToken);

        /// <summary>
        /// Returns the entire loan or specific entities of a loan as raw json.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLoanRawAsync(this ILoans loans, string loanId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).GetLoanRawAsync(loanId, queryString, cancellationToken);

        /// <summary>
        /// Returns the list of loan entities that can be retrieved from a loan.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(this ILoans loans, CancellationToken cancellationToken = default) => GetV1(loans).GetSupportedEntitiesAsync(cancellationToken);

        /// <summary>
        /// Returns the list of loan entities that can be retrieved from a loan as raw json.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetSupportedEntitiesRawAsync(this ILoans loans, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).GetSupportedEntitiesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, CancellationToken cancellationToken = default) => CreateLoanAsync(loans, loan, null, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass and returns the loan id of the loan created and optionally populates the loan object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to create.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, bool populate, CancellationToken cancellationToken = default) => CreateLoanAsync(loans, loan, new CreateLoanOptions { Populate = populate }, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass with the optionally specified <paramref name="createLoanOptions"/> and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to create.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, CreateLoanOptions? createLoanOptions, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanAsync(loan, createLoanOptions, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using raw json and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanRawAsync(this ILoans loans, string loan, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanRawAsync(loan, queryString, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, CancellationToken cancellationToken = default) => UpdateLoanAsync(loans, loan, null, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed and optionally populates the loan object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to update.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, bool populate, CancellationToken cancellationToken = default) => UpdateLoanAsync(loans, loan, new UpdateLoanOptions { Populate = populate }, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed with the optionally specified <paramref name="updateLoanOptions"/>.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to update.</param>
        /// <param name="updateLoanOptions">The loan update options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, UpdateLoanOptions? updateLoanOptions, CancellationToken cancellationToken = default) => GetV1(loans).UpdateLoanAsync(loan, updateLoanOptions, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed or by applying a loan template using raw json.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The loan id of the loan to update.</param>
        /// <param name="loan">The loan to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateLoanRawAsync(this ILoans loans, string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).UpdateLoanRawAsync(loanId, loan, queryString, cancellationToken);

        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetV1(loans).DeleteLoanAsync(loanId, cancellationToken);

        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetV1(loans).TryDeleteLoanAsync(loanId, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => CreateLoanFromImportFileAsync(loans, importFileType.Validate(nameof(importFileType)).GetValue()!, importFile, createLoanOptions, out loan, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => CreateLoanFromImportFileAsync(loans, importFileType.Validate(nameof(importFileType)).GetValue()!, importFile, createLoanOptions, out loan, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out loan, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(loans, importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileAsync(this ILoans loans, string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out loan, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the response content or else the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileRawAsync(this ILoans loans, string importFileType, string importFile, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileRawAsync(importFileType, importFile, queryString, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the response content or else the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanFromImportFileRawAsync(this ILoans loans, string importFileType, Stream importFile, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loans).CreateLoanFromImportFileRawAsync(importFileType, importFile, queryString, cancellationToken);
    }
}