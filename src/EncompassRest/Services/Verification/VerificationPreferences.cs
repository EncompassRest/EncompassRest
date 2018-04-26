using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    public sealed class VerificationPreferences
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportLiabilities { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeZeroBalances { get; set; }
    }
}