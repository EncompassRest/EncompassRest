using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest
{
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

        public Task<string> FromUserCredentialsAsync(string instanceId, string userId, string password, CancellationToken cancellationToken = default) => _client.AccessToken.GetTokenFromUserCredentialsAsync(instanceId, userId, password, nameof(FromUserCredentialsAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);

        public Task<string> FromAuthorizationCodeAsync(string redirectUri, string authorizationCode, CancellationToken cancellationToken = default) => _client.AccessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(FromAuthorizationCodeAsync), CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, RequestCancellationToken).Token);
    }
}