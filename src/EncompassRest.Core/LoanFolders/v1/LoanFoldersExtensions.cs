using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders.v1
{
    public static class LoanFoldersExtensions
    {
        public static ILoanFoldersV1? V1 { get; set; }

        private static ILoanFoldersV1 GetV1(ILoanFolders eFolder)
        {
            var v1 = V1;
            if (eFolder is LoanFolders f)
            {
                v1 = (ILoanFoldersV1)f.ExtensionData.GetOrAdd("v1", k => new LoanFoldersV1(f.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(eFolder, nameof(eFolder));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Move a loan from one folder to another folder.
        /// </summary>
        /// <param name="loanId">The id of the loan to move.</param>
        /// <param name="loanFolder">The name of the target folder in which to move the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task MoveLoanToFolderAsync(this ILoanFolders loanFolders, string loanId, string loanFolder, CancellationToken cancellationToken = default) => GetV1(loanFolders).MoveLoanToFolderAsync(loanId, loanFolder, cancellationToken);
    }
}