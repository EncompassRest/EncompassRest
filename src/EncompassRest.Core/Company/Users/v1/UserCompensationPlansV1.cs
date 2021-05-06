using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Company.v1;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// User Compensation Apis
    /// </summary>
    public interface IUserCompensationPlansV1 : IUserApiObject
    {
        /// <summary>
        /// Gets the user's compensation plans.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<CompensationPlans> GetCompensationPlansAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the user's compensation plans as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetCompensationPlansRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class UserCompensationPlansV1 : UserApiObjectV1, IUserCompensationPlansV1
    {
        internal UserCompensationPlansV1(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, "compensation")
        {
        }

        public Task<CompensationPlans> GetCompensationPlansAsync(CancellationToken cancellationToken = default) => GetDirtyAsync<CompensationPlans>(null, null, nameof(GetCompensationPlansAsync), null, cancellationToken);

        public Task<string> GetCompensationPlansRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetCompensationPlansRawAsync), null, cancellationToken);
    }
}