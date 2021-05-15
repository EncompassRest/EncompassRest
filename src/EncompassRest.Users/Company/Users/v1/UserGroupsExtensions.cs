using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    ///The User Groups Api extension methods.
    /// </summary>
    public static class UserGroupsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IUserGroupsV1? V1 { get; set; }

        private static IUserGroupsV1 GetV1(IUserGroups userGroups)
        {
            var v1 = V1;
            if (userGroups is UserGroups g)
            {
                v1 = g.ExtensionData.GetOrAdd(() => new UserGroupsV1(g.Client, g.UserApis, g.UserId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(userGroups, nameof(userGroups));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the user's groups.
        /// </summary>
        /// <param name="userGroups">The User Groups Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<EntityReference>> GetGroupsAsync(this IUserGroups userGroups, CancellationToken cancellationToken = default) => GetV1(userGroups).GetGroupsAsync(cancellationToken);

        /// <summary>
        /// Gets the user's groups as raw json.
        /// </summary>
        /// <param name="userGroups">The User Groups Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetGroupsRawAsync(this IUserGroups userGroups, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(userGroups).GetGroupsRawAsync(queryString, cancellationToken);
    }
}