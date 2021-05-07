using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// User Licenses Apis
    /// </summary>
    public interface IUserLicenseDetailsV1 : IUserApiObject
    {
        /// <summary>
        /// Gets the user's licenses and for a particular state if specified.
        /// </summary>
        /// <param name="state">The state code for which to return license information.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(string? state, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the user's licenses as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLicenseDetailsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class UserLicenseDetailsV1 : UserApiObjectV1, IUserLicenseDetailsV1
    {
        internal UserLicenseDetailsV1(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, "licenses")
        {
        }

        public Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(string? state, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(state))
            {
                queryParameters.Add("state", state);
            }
            return GetDirtyListAsync<UserLicenseDetail>(null, queryParameters.ToString(), nameof(GetLicenseDetailsAsync), null, cancellationToken);
        }

        public Task<string> GetLicenseDetailsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLicenseDetailsRawAsync), null, cancellationToken);
    }
}