using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Company.Users.Rights.v1
{
    public static class UsersRightsExtensions
    {
        public static IUsersRightsV1? V1 { get; set; }

        private static IUsersRightsV1 GetV1(IUsersRights usersRights)
        {
            var v1 = V1;
            if (usersRights is UsersRights r)
            {
                v1 = (IUsersRightsV1)r.ExtensionData.GetOrAdd("v1", k => new UsersRightsV1(r.Client, r.UserApis, r.UserId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(usersRights, nameof(usersRights));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<UserRights> GetRightsAsync(this IUsersRights usersRights, UserRightsType type, CancellationToken cancellationToken = default) => GetRightsAsync(usersRights, type, category: null, cancellationToken);

        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/> and optionally filtered to include only the specified <paramref name="category"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="category">User settings category. You can filter the access rights by their tabs in Encompass.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<UserRights> GetRightsAsync(this IUsersRights usersRights, UserRightsType type, string? category, CancellationToken cancellationToken = default) => GetV1(usersRights).GetRightsAsync(type, category, cancellationToken);

        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/> and filtered to include only the specified <paramref name="category"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="category">User settings category. You can filter the access rights by their tabs in Encompass.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<UserRights> GetRightsAsync(this IUsersRights usersRights, UserRightsType type, UserRightsCategory category, CancellationToken cancellationToken = default) => GetRightsAsync(usersRights, type, category.Validate(nameof(category)).GetValue(), cancellationToken);

        /// <summary>
        /// Gets the users rights as raw json for the specified rights <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetRightsRawAsync(this IUsersRights usersRights, UserRightsType type, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(usersRights).GetRightsRawAsync(type, queryString, cancellationToken);
    }
}