using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders.v3
{
    /// <summary>
    /// The Loan Folders Api extension methods.
    /// </summary>
    public static class LoanFoldersExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanFoldersV3? V1 { get; set; }

        private static ILoanFoldersV3 GetV1(ILoanFolders loanFolders)
        {
            var v1 = V1;
            if (loanFolders is LoanFolders f)
            {
                v1 = f.ExtensionData.GetOrAdd(() => new LoanFoldersV3(f.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanFolders, nameof(loanFolders));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves a list of loan folders from Encompass. The response includes the complete list of loan folders, including the Trash folder, for which the user has access rights.
        /// </summary>
        /// <param name="loanFolders">The Loan Folders Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanFolder>> GetLoanFoldersAsync(this ILoanFolders loanFolders, CancellationToken cancellationToken = default) => GetV1(loanFolders).GetLoanFoldersAsync(cancellationToken);

        /// <summary>
        /// Retrieves a list of loan folders from Encompass as raw json. The response includes the complete list of loan folders, including the Trash folder, for which the user has access rights.
        /// </summary>
        /// <param name="loanFolders">The Loan Folders Api Object.</param>
        /// <param name="queryString">The query string to include in the request. This should include a path parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLoanFoldersRawAsync(this ILoanFolders loanFolders, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanFolders).GetLoanFoldersRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Retrieves the specified loan folder from Encompass.
        /// </summary>
        /// <param name="loanFolders">The Loan Folders Api Object.</param>
        /// <param name="folderName">Name of the loan folder to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanFolder> GetLoanFolderAsync(this ILoanFolders loanFolders, string folderName, CancellationToken cancellationToken = default) => GetV1(loanFolders).GetLoanFolderAsync(folderName, cancellationToken);

        /// <summary>
        /// Retrieves the specified loan folder from Encompass as raw json.
        /// </summary>
        /// <param name="loanFolders">The Loan Folders Api Object.</param>
        /// <param name="folderName">Name of the loan folder to retrieve.</param>
        /// <param name="queryString">The query string to include in the request. This should include a path parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLoanFolderRawAsync(this ILoanFolders loanFolders, string folderName, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanFolders).GetLoanFolderRawAsync(folderName, queryString, cancellationToken);
    }
}