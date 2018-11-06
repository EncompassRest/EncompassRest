using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Compensation Apis
    /// </summary>
    public sealed class UserCompensationPlans : UserApiObject
    {
        internal UserCompensationPlans(EncompassRestClient client, string userId)
            : base(client, userId, "compensation")
        {
        }

        /// <summary>
        /// Gets the user's compensation plans.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<UserCompensation> GetCompensationPlansAsync(CancellationToken cancellationToken = default) => GetDirtyAsync<UserCompensation>(null, null, nameof(GetCompensationPlansAsync), null, cancellationToken);

        /// <summary>
        /// Gets the user's compensation plans as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetCompensationPlansRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetCompensationPlansRawAsync), null, cancellationToken);
    }
}