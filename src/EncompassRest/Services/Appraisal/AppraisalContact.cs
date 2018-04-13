using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalContact
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactBorrower Borrower { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactBorrower CoBorrower { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Agent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Occupant { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Owner { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactBroker Broker { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Other { get; set; }
    }
}