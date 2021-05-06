using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// User Groups Apis
    /// </summary>
    public interface IUserGroupsV1 : IUserApiObject
    {
        /// <summary>
        /// Gets the user's groups.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<EntityReference>> GetGroupsAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the user's groups as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetGroupsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class UserGroupsV1 : UserApiObjectV1, IUserGroupsV1
    {
        internal UserGroupsV1(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, "groups")
        {
        }

        public Task<List<EntityReference>> GetGroupsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<EntityReference>(null, null, nameof(GetGroupsAsync), null, cancellationToken);

        public Task<string> GetGroupsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetGroupsRawAsync), null, cancellationToken);
    }
}