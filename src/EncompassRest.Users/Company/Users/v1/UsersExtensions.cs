using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    public static class UsersExtensions
    {
        public static IUsersV1? V1 { get; set; }

        private static IUsersV1 GetV1(IUsers users)
        {
            var v1 = V1;
            if (users is Users u)
            {
                v1 = (IUsersV1)u.ExtensionData.GetOrAdd("v1", k => new UsersV1(u.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(users, nameof(users));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<User> GetCurrentUserAsync(this IUsers users, CancellationToken cancellationToken = default) => GetCurrentUserAsync(users, viewEmailSignature: null, cancellationToken);

        /// <summary>
        /// Gets the current user and optionally includes the email signature in the response object.
        /// </summary>
        /// <param name="viewEmailSignature">Indicates whether the email signature should be returned as part of the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<User> GetCurrentUserAsync(this IUsers users, bool? viewEmailSignature, CancellationToken cancellationToken = default) => GetV1(users).GetCurrentUserAsync(viewEmailSignature, cancellationToken);

        /// <summary>
        /// Gets the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<User> GetUserAsync(this IUsers users, string userId, CancellationToken cancellationToken = default) => GetUserAsync(users, userId, viewEmailSignature: null, cancellationToken);

        /// <summary>
        /// Gets the user with the specified <paramref name="userId"/> and optionally includes the email signature in the response object.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <param name="viewEmailSignature">Indicates whether the email signature should be returned as part of the response.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<User> GetUserAsync(this IUsers users, string userId, bool? viewEmailSignature, CancellationToken cancellationToken = default) => GetV1(users).GetUserAsync(userId, viewEmailSignature, cancellationToken);

        /// <summary>
        /// Gets user as raw json.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetUserRawAsync(this IUsers users, string userId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(users).GetUserRawAsync(userId, queryString, cancellationToken);

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<User>> GetUsersAsync(this IUsers users, CancellationToken cancellationToken = default) => GetUsersAsync(users, options: null, cancellationToken);

        /// <summary>
        /// Gets users using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The users retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<User>> GetUsersAsync(this IUsers users, UsersRetrievalOptions? options, CancellationToken cancellationToken = default) => GetV1(users).GetUsersAsync(options, cancellationToken);

        /// <summary>
        /// Gets users as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetUsersRawAsync(this IUsers users, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(users).GetUsersRawAsync(queryString, cancellationToken);
    }
}