using System.Threading;
using System.Threading.Tasks;

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
        public Task<string> FromUserCredentialsAsync(string instanceId, string userId, string password, CancellationToken cancellationToken = default) => _client.AccessToken.GetTokenFromUserCredentialsAsync(instanceId, userId, password, nameof(FromUserCredentialsAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);

        /// <summary>
        /// Retrieves an access token from an authorization code.
        /// </summary>
        /// <param name="redirectUri">The redirect uri associated with the authorization code.</param>
        /// <param name="authorizationCode">The authorization code to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> FromAuthorizationCodeAsync(string redirectUri, string authorizationCode, CancellationToken cancellationToken = default) => _client.AccessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(FromAuthorizationCodeAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);
    }
}