using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Class to retrieve an access token.
    /// </summary>
    public sealed class TokenCreator
    {
        private readonly EncompassRestClient _client;

        /// <summary>
        /// The request <see cref="CancellationToken"/> is automatically applied to uses of this class.
        /// </summary>
        public CancellationToken RequestCancellationToken { get; }

        internal TokenCreator(EncompassRestClient client, CancellationToken requestCancellationToken)
        {
            _client = client;
            RequestCancellationToken = requestCancellationToken;
        }

        /// <summary>
        /// Retrieves an access token from user credentials.
        /// </summary>
        /// <param name="instanceId">The encompass instance id.</param>
        /// <param name="userId">The encompass user id.</param>
        /// <param name="password">The encompass user password.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> FromUserCredentialsAsync(string instanceId, string userId, string password, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            return _client._accessToken.GetTokenFromUserCredentialsAsync(instanceId, userId, password, nameof(FromUserCredentialsAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);
        }

        /// <summary>
        /// Retrieves an access token from an authorization code.
        /// </summary>
        /// <param name="redirectUri">The redirect uri associated with the authorization code.</param>
        /// <param name="authorizationCode">The authorization code to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> FromAuthorizationCodeAsync(string redirectUri, string authorizationCode, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            return _client._accessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(FromAuthorizationCodeAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);
        }

        /// <summary>
        /// This method is for partner API integration only. You probably want <see cref="FromUserCredentialsAsync(string, string, string, CancellationToken)"/> instead.
        /// </summary>
        /// <param name="instanceId">The encompass instance id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        [Obsolete("This method is for partner API integration only. You probably want FromUserCredentialsAsync instead.")]
        public Task<string> FromClientCredentialsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));

            return _client._accessToken.GetTokenFromClientCredentialsAsync(instanceId, nameof(FromClientCredentialsAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);
        }
    }
}