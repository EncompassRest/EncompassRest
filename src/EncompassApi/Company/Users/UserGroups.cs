using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassApi.Company.Users
{
    /// <summary>
    /// User Groups Apis
    /// </summary>
    public interface IUserGroups : IUserApiObject
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

    /// <summary>
    /// User Groups Apis
    /// </summary>
    public sealed class UserGroups : UserApiObject, IUserGroups
    {
        internal UserGroups(EncompassApiClient client, string userId)
            : base(client, userId, "groups")
        {
        }

        /// <inheritdoc/>
        public Task<List<EntityReference>> GetGroupsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<EntityReference>(null, null, nameof(GetGroupsAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetGroupsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetGroupsRawAsync), null, cancellationToken);
    }
}