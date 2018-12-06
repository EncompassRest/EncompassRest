using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Licenses Apis
    /// </summary>
    public sealed class UserLicenseDetails : UserApiObject
    {
        internal UserLicenseDetails(EncompassRestClient client, string userId)
            : base(client, userId, "licenses")
        {
        }

        /// <summary>
        /// Gets the user's licenses.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(CancellationToken cancellationToken = default) => GetLicenseDetailsAsync(null, cancellationToken);

        /// <summary>
        /// Gets the user's licenses for a particular state.
        /// </summary>
        /// <param name="state">The requested license's state.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(State state, CancellationToken cancellationToken = default) => GetLicenseDetailsAsync(state.Validate(nameof(state)).GetValue(), cancellationToken);

        /// <summary>
        /// Gets the user's licenses and for a particular state if specified.
        /// </summary>
        /// <param name="state">The requested license's state if specified.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(string state, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(state))
            {
                queryParameters.Add("state", state);
            }
            return GetDirtyListAsync<UserLicenseDetail>(null, queryParameters.ToString(), nameof(GetLicenseDetailsAsync), null, cancellationToken);
        }

        /// <summary>
        /// Gets the user's licenses as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetLicenseDetailsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLicenseDetailsRawAsync), null, cancellationToken);
    }
}