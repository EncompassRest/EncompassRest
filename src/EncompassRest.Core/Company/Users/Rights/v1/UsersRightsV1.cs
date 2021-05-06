using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Company.Users.v1;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// User Rights Apis
    /// </summary>
    public interface IUsersRightsV1 : IUserApiObject
    {
        /// <summary>
        /// Gets the users rights for the specified rights <paramref name="type"/> and optionally filtered to include only the specified <paramref name="category"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="category">User settings category. You can filter the access rights by their tabs in Encompass.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<UserRights> GetRightsAsync(UserRightsType type, string? category, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the users rights as raw json for the specified rights <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The user rights type.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRightsRawAsync(UserRightsType type, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class UsersRightsV1 : UserApiObjectV1, IUsersRightsV1
    {
        internal UsersRightsV1(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, null)
        {
        }

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

        public Task<string> GetRightsRawAsync(UserRightsType type, string? queryString = null, CancellationToken cancellationToken = default)
        {
            type.Validate(nameof(type));

            var path = type.GetValue();
            return GetRawAsync(path, queryString, nameof(GetRightsRawAsync), path, cancellationToken);
        }
    }
}