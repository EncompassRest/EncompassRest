using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public class AppraisalContactData
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string WorkPhone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string HomePhone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CellPhone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
    }
}