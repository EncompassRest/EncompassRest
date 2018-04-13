using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    public sealed class AUSCredentials : ServiceCredentials
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditProviderUserName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditProviderPassword { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InstitutionId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string LPPassword { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SellerServicerNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TPOAccountIdentifier { get; set; }
    }
}