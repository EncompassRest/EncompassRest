using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Token
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), ItemRequired = Required.Always)]
    public sealed class TokenIntrospectionResponse
    {
        private static readonly DateTime s_unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        [JsonProperty("exp")]
        private int _expiration
        {
            get => (int)((Expiration - s_unixEpoch).TotalSeconds);
            set => Expiration = s_unixEpoch.AddSeconds(value);
        }

        public bool Active { get; set; }

        public string Scope { get; set; }

        public string ClientId { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        public string TokenType { get; set; }

        [JsonIgnore, JsonProperty(Required = Required.Default)]
        public DateTime Expiration { get; set; }

        [JsonProperty("sub")]
        public string Subject { get; set; }

        public string EncompassInstanceId { get; set; }

        [JsonProperty("user_name")]
        public string UserId { get; set; }

        public string UserKey { get; set; }

        public string EncompassUser { get; set; }

        public string IdentityType { get; set; }

        public string EncompassClientId { get; set; }

        public string RealmName { get; set; }
    }
}
