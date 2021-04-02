using Newtonsoft.Json;

namespace EncompassApi.Services.Flood
{
    /// <summary>
    /// FloodCredentials
    /// </summary>
    public sealed class FloodCredentials : ServiceCredentials
    {
        /// <summary>
        /// This is the account identifier assigned by ServiceLink to authenticate your organization and track service requests.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountId { get; set; }
    }
}