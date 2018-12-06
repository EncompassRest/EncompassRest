using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Token
{
    /// <summary>
    /// TokenIntrospectionResponse
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class TokenIntrospectionResponse : ExtensibleObject
    {
        private static readonly DateTime s_unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        [JsonProperty("exp")]
        private int _expiration
        {
            get => (int)((ExpirationUtc - s_unixEpoch).TotalSeconds);
            set => ExpirationUtc = s_unixEpoch.AddSeconds(value);
        }

        /// <summary>
        /// An indicator of whether the access token is valid.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// The OAuth scope.
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// The OAuth client ID.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The fully qualified username in the format: user_name@realm_name.
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// The token type, always "Bearer".
        /// </summary>
        public string TokenType { get; set; }

        /// <summary>
        /// The number of seconds until the token expires (from January 1, 1970 UTC).
        /// </summary>
        [JsonIgnore]
        public DateTime ExpirationUtc { get; set; }

        /// <summary>
        /// The subject associated with the access token. This property contains the same value as username.
        /// </summary>
        [JsonProperty("sub")]
        public string Subject { get; set; }

        /// <summary>
        /// The Encompass instance ID.
        /// </summary>
        public string EncompassInstanceId { get; set; }

        /// <summary>
        /// The username.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserId { get; set; }

        /// <summary>
        /// The fully qualified username in the format: user_name@realm_name.
        /// </summary>
        public string UserKey { get; set; }

        /// <summary>
        /// The Encompass username in the format: Encompass\&lt;encompass_instance_id&gt;\&lt;user_name&gt;
        /// </summary>
        public string EncompassUser { get; set; }

        /// <summary>
        /// The user type, always "Enterprise".
        /// </summary>
        public string IdentityType { get; set; }

        /// <summary>
        /// The Encompass client ID.
        /// </summary>
        public string EncompassClientId { get; set; }

        /// <summary>
        /// The realm name in the format: encompass:&lt;encompass_instance_id&gt;.
        /// </summary>
        public string RealmName { get; set; }
    }
}