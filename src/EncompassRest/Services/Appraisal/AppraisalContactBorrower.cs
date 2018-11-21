using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalContactBorrower : AppraisalContactData
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<State> State { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }
    }
}