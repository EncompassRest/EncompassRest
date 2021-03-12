using Newtonsoft.Json;

namespace EncompassApi.Services.Appraisal
{
    /// <summary>
    /// AppraisalContactBorrower
    /// </summary>
    public sealed class AppraisalContactBorrower : AppraisalContactData
    {
        /// <summary>
        /// The borrower's physical address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; }

        /// <summary>
        /// The borrower's city.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? City { get; set; }

        /// <summary>
        /// The borrower's state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<State> State { get; set; }

        /// <summary>
        /// The borrower's zip code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Zip { get; set; }
    }
}