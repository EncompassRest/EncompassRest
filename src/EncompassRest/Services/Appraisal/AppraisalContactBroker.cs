using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalContactBroker : AppraisalContactData
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }
    }
}