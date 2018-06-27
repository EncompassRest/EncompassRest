using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalContacts : SerializableObject
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContact Contact { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AppointmentContact { get; set; }
    }
}