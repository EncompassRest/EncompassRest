using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders
{
    /// <summary>
    /// The Loan Folders Apis.
    /// </summary>
    public sealed class LoanFolders : ApiObject
    {
        internal LoanFolders(EncompassRestClient client)
            : base(client, "encompass/v1/loanfolders")
        {
        }

        /// <summary>
        /// Move a loan from one folder to another folder.
        /// </summary>
        /// <param name="loanId">The id of the loan to move.</param>
        /// <param name="loanFolder">The loan folder to move the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task MoveLoanToFolderAsync(string loanId, string loanFolder, CancellationToken cancellationToken = default) => PatchAsync($"{Uri.EscapeDataString(loanFolder)}/loans", "?action=add", new JsonStringContent($@"{{""loanGuid"":""{loanId}""}}"), nameof(MoveLoanToFolderAsync), loanId, cancellationToken);
    }
}