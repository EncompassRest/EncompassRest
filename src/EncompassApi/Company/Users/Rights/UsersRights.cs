using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// User Rights Apis
    /// </summary>
    public interface IUsersRights : IUserApiObject
    {
        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<UserRights> GetRightsAsync(UserRightsType type, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/> and optionally filtered to include only the specified <paramref name="category"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="category">User settings category. You can filter the access rights by their tabs in Encompass.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<UserRights> GetRightsAsync(UserRightsType type, string? category, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/> and filtered to include only the specified <paramref name="category"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="category">User settings category. You can filter the access rights by their tabs in Encompass.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<UserRights> GetRightsAsync(UserRightsType type, UserRightsCategory category, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the users rights as raw json for the specified rights <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRightsRawAsync(UserRightsType type, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// User Rights Apis
    /// </summary>
    public sealed class UsersRights : UserApiObject, IUsersRights
    {
        internal UsersRights(EncompassApiClient client, string userId)
            : base(client, userId, null)
        {
        }

        /// <inheritdoc/>
        public Task<UserRights> GetRightsAsync(UserRightsType type, CancellationToken cancellationToken = default) => GetRightsAsync(type, null, cancellationToken);

        /// <inheritdoc/>
        public Task<UserRights> GetRightsAsync(UserRightsType type, UserRightsCategory category, CancellationToken cancellationToken = default) => GetRightsAsync(type, category.Validate(nameof(category)).GetValue(), cancellationToken);

        /// <inheritdoc/>
        public Task<UserRights> GetRightsAsync(UserRightsType type, string? category, CancellationToken cancellationToken = default)
        {
            type.Validate(nameof(type));

            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(category))
            {
                queryParameters.Add("category", category);
            }
            var path = type.GetValue();
            return GetDirtyAsync<UserRights>(path, queryParameters.ToString(), nameof(GetRightsAsync), path, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetRightsRawAsync(UserRightsType type, string? queryString = null, CancellationToken cancellationToken = default)
        {
            type.Validate(nameof(type));

            var path = type.GetValue();
            return GetRawAsync(path, queryString, nameof(GetRightsRawAsync), path, cancellationToken);
        }
    }
}