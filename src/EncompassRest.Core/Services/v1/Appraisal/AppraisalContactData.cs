using Newtonsoft.Json;

namespace EncompassRest.Services.v1.Appraisal
{
    /// <summary>
    /// AppraisalContactData
    /// </summary>
    public class AppraisalContactData : ExtensibleObject
    {
        /// <summary>
        /// The contact's name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        /// <summary>
        /// The contact's work phone number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkPhone { get; set; }

        /// <summary>
        /// The contact's home phone number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? HomePhone { get; set; }

        /// <summary>
        /// The contact's cell phone number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CellPhone { get; set; }

        /// <summary>
        /// The contact's email address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; }
    }
}