using Newtonsoft.Json;

namespace EncompassRest.Services.v1.Appraisal
{
    /// <summary>
    /// AppraisalContacts
    /// </summary>
    public sealed class AppraisalContacts : ExtensibleObject
    {
        /// <summary>
        /// The primary contacts in the appraisal process - borrower, coborrower, agent, broker, occupant and/or other.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContact? Contact { get; set; }

        /// <summary>
        /// The main point of contact for the Appraisal Management Company from the contacts provided above.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AppointmentContact { get; set; }
    }
}