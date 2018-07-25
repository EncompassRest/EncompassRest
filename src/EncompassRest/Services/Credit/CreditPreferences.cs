using Newtonsoft.Json;

namespace EncompassRest.Services.Credit
{
    public sealed class CreditPreferences : SerializableObject
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportLiabilities { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeZeroForImportLiabilities { get; set; }
    }
}