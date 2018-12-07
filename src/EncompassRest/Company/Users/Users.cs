using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// Users Apis
    /// </summary>
    public sealed class Users : ApiObject
    {
        private UserApis _currentUserApis;

        /// <summary>
        /// Gets the Current User's Apis. Custom Data Objects are not currently supported through this property.
        /// </summary>
        public UserApis CurrentUserApis
        {
            get
            {
                var currentUserApis = _currentUserApis;
                return currentUserApis ?? Interlocked.CompareExchange(ref _currentUserApis, (currentUserApis = new UserApis(Client, "me")), null) ?? currentUserApis;
            }
        }

        internal Users(EncompassRestClient client)
            : base(client, "encompass/v1/company/users")
        {
        }

        /// <summary>
        /// Gets the User Apis for the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <returns></returns>
        public UserApis GetUserApis(string userId)
        {
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            return new UserApis(Client, userId);
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<User>> GetUsersAsync(CancellationToken cancellationToken = default) => GetUsersAsync(null, cancellationToken);

        /// <summary>
        /// Gets users using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The users retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<List<User>> GetUsersAsync(UsersRetrievalOptions options, CancellationToken cancellationToken = default)
        {
            var users = await GetDirtyListAsync<User>(null, options?.ToQueryParameters().ToString(), nameof(GetUsersAsync), null, cancellationToken).ConfigureAwait(false);
            foreach (var user in users)
            {
                user.Initialize(Client, user.Id);
            }
            return users;
        }

        /// <summary>
        /// Gets users as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetUsersRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetUsersRawAsync), null, cancellationToken);

        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default) => GetUserAsync("me", null, cancellationToken);

        /// <summary>
        /// Gets the current user and optionally includes the email signature in the response object.
        /// </summary>
        /// <param name="viewEmailSignature">Indicates whether the email signature should be returned as part of the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<User> GetCurrentUserAsync(bool? viewEmailSignature, CancellationToken cancellationToken = default) => GetUserAsync("me", viewEmailSignature, cancellationToken);

        /// <summary>
        /// Gets the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<User> GetUserAsync(string userId, CancellationToken cancellationToken = default) => GetUserAsync(userId, null, cancellationToken);

        /// <summary>
        /// Gets the user with the specified <paramref name="userId"/> and optionally includes the email signature in the response object.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <param name="viewEmailSignature">Indicates whether the email signature should be returned as part of the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<User> GetUserAsync(string userId, bool? viewEmailSignature, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            var queryParameters = new QueryParameters();
            if (viewEmailSignature.HasValue)
            {
                queryParameters.Add("viewEmailSignature", viewEmailSignature.ToString().ToLower());
            }
            var user = await GetDirtyAsync<User>(userId, queryParameters.ToString(), nameof(GetUserAsync), userId, cancellationToken).ConfigureAwait(false);
            user.Initialize(Client, user.Id);
            return user;
        }

        /// <summary>
        /// Gets user as raw json.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetUserRawAsync(string userId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            return GetRawAsync(userId, queryString, nameof(GetUserRawAsync), userId, cancellationToken);
        }
    }
}