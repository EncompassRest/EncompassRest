using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders
{
    public sealed class LoanFolders : ApiObject
    {
        internal LoanFolders(EncompassRestClient client)
            : base(client, "encompass/v1/loanfolders")
        {
        }

        public Task MoveLoanToFolderAsync(string loanId, string loanFolder, CancellationToken cancellationToken = default) => PatchAsync($"{Uri.EscapeDataString(loanFolder)}/loans", "?action=add", new JsonStringContent($@"{{""loanGuid"":""{loanId}""}}"), nameof(MoveLoanToFolderAsync), loanId, cancellationToken);
    }
}