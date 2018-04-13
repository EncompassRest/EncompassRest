using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalCredentials : ServiceCredentials
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }
    }
}