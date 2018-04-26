using Newtonsoft.Json;

namespace EncompassRest.Services.Flood
{
    public sealed class FloodCredentials : ServiceCredentials
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }
    }
}