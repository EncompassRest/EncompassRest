using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    /// <summary>
    /// AppraisalContact
    /// </summary>
    public sealed class AppraisalContact : ExtensibleObject
    {
        /// <summary>
        /// The borrower contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactBorrower Borrower { get; set; }

        /// <summary>
        /// The co-borrower contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactBorrower CoBorrower { get; set; }

        /// <summary>
        /// The agent contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Agent { get; set; }

        /// <summary>
        /// The occupant contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Occupant { get; set; }

        /// <summary>
        /// The owner contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Owner { get; set; }

        /// <summary>
        /// The broker contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactBroker Broker { get; set; }

        /// <summary>
        /// Any other contact you would like to add and send to the Appraisal Management Company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AppraisalContactData Other { get; set; }
    }
}