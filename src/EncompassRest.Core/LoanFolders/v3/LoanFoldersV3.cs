using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders.v3
{
    /// <summary>
    /// The Loan Folders Apis.
    /// </summary>
    public interface ILoanFoldersV3 : IApiObject
    {
        /// <summary>
        /// Retrieves a list of loan folders from Encompass. The response includes the complete list of loan folders, including the Trash folder, for which the user has access rights.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanFolder>> GetLoanFoldersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of loan folders from Encompass as raw json. The response includes the complete list of loan folders, including the Trash folder, for which the user has access rights.
        /// </summary>
        /// <param name="queryString">The query string to include in the request. This should include a path parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLoanFoldersRawAsync(string? queryString = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the specified loan folder from Encompass.
        /// </summary>
        /// <param name="folderName">Name of the loan folder to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanFolder> GetLoanFolderAsync(string folderName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the specified loan folder from Encompass as raw json.
        /// </summary>
        /// <param name="folderName">Name of the loan folder to retrieve.</param>
        /// <param name="queryString">The query string to include in the request. This should include a path parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLoanFolderRawAsync(string folderName, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class LoanFoldersV3 : ApiObject, ILoanFoldersV3
    {
        internal LoanFoldersV3(EncompassRestClient client)
            : base(client, "encompass/v3/loanfolders")
        {
        }

        public Task<List<LoanFolder>> GetLoanFoldersAsync(CancellationToken cancellationToken = default) => GetListAsync<LoanFolder>(null, null, nameof(GetLoanFoldersAsync), null, cancellationToken);

        public Task<string> GetLoanFoldersRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLoanFoldersRawAsync), null, cancellationToken);

        public Task<LoanFolder> GetLoanFolderAsync(string folderName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(folderName, nameof(folderName));

            return GetAsync<LoanFolder>(folderName, null, nameof(GetLoanFolderAsync), folderName, cancellationToken);
        }

        public Task<string> GetLoanFolderRawAsync(string folderName, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(folderName, nameof(folderName));

            return GetRawAsync(folderName, queryString, nameof(GetLoanFolderRawAsync), folderName, cancellationToken);
        }
    }
}