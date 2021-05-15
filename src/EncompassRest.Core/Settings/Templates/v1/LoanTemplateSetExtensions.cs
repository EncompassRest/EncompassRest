using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Templates.v1
{
    /// <summary>
    /// The Loan Template Set Api extension methods.
    /// </summary>
    public static class LoanTemplateSetExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanTemplateSetV1? V1 { get; set; }

        private static ILoanTemplateSetV1 GetV1(ILoanTemplateSet loanTemplateSet)
        {
            var v1 = V1;
            if (loanTemplateSet is LoanTemplateSet t)
            {
                v1 = t.ExtensionData.GetOrAdd(() => new LoanTemplateSetV1(t.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanTemplateSet, nameof(loanTemplateSet));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves a list of template files from the specified template path.
        /// </summary>
        /// <param name="loanTemplateSet">The Loan Template Set Api Object.</param>
        /// <param name="path">Path to where the template files are located.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<EntityReference>> GetTemplateFilesAsync(this ILoanTemplateSet loanTemplateSet, string path, CancellationToken cancellationToken = default) => GetV1(loanTemplateSet).GetTemplateFilesAsync(path, cancellationToken);

        /// <summary>
        /// Retrieves a list of template files from the specified template path as raw json.
        /// </summary>
        /// <param name="loanTemplateSet">The Loan Template Set Api Object.</param>
        /// <param name="queryString">The query string to include in the request. This should include a path parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetTemplateFilesRawAsync(this ILoanTemplateSet loanTemplateSet, string queryString, CancellationToken cancellationToken = default) => GetV1(loanTemplateSet).GetTemplateFilesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Retrieves a list of template folders from the specified location.
        /// </summary>
        /// <param name="loanTemplateSet">The Loan Template Set Api Object.</param>
        /// <param name="path">Location of the loan template folder. The default parent path starts with public or personal.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<EntityReference>> GetTemplateFoldersAsync(this ILoanTemplateSet loanTemplateSet, string path, CancellationToken cancellationToken = default) => GetV1(loanTemplateSet).GetTemplateFoldersAsync(path, cancellationToken);

        /// <summary>
        /// Retrieves a list of template folders from the specified location as raw json.
        /// </summary>
        /// <param name="loanTemplateSet">The Loan Template Set Api Object.</param>
        /// <param name="path">Location of the loan template folder. The default parent path starts with public or personal.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetTemplateFoldersRawAsync(this ILoanTemplateSet loanTemplateSet, string path, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanTemplateSet).GetTemplateFoldersRawAsync(path, queryString);
    }
}