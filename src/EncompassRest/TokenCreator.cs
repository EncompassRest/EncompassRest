using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest
{
    public sealed class TokenCreator
    {
        private readonly EncompassRestClient _client;

        internal TokenCreator(EncompassRestClient client)
        {
            _client = client;
        }

        public Task<string> FromUserCredentialsAsync(string userId, string password, CancellationToken cancellationToken = default) => _client.AccessToken.GetTokenFromUserCredentialsAsync(userId, password, nameof(FromUserCredentialsAsync), cancellationToken);

        public Task<string> FromAuthorizationCodeAsync(string redirectUri, string authorizationCode, CancellationToken cancellationToken = default) => _client.AccessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(FromAuthorizationCodeAsync), cancellationToken);
    }
}