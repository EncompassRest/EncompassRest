using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    public sealed class AUSOrderCreditDetail
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditReportIdentifier { get; set; }
    }
}