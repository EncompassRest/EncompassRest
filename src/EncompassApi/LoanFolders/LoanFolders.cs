using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Utilities;

namespace EncompassApi.LoanFolders
{
    /// <summary>
    /// The Loan Folders Apis.
    /// </summary>
    public interface ILoanFolders : IApiObject
    {
        /// <summary>
        /// Move a loan from one folder to another folder.
        /// </summary>
        /// <param name="loanId">The id of the loan to move.</param>
        /// <param name="loanFolder">The name of the target folder in which to move the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task MoveLoanToFolderAsync(string loanId, string loanFolder, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Folders Apis.
    /// </summary>
    public sealed class LoanFolders : ApiObject, ILoanFolders
    {
        internal LoanFolders(IEncompassApiClient client)
            : base(client, "encompass/v1/loanfolders")
        {
        }

        /// <inheritdoc/>
        public Task MoveLoanToFolderAsync(string loanId, string loanFolder, CancellationToken cancellationToken = default) => PatchAsync($"{Uri.EscapeDataString(loanFolder)}/loans", "?action=add", new JsonStringContent($@"{{""loanGuid"":""{loanId}""}}"), nameof(MoveLoanToFolderAsync), loanId, cancellationToken);
    }
}