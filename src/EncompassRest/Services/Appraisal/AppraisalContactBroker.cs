using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    /// <summary>
    /// AppraisalContactBroker
    /// </summary>
    public sealed class AppraisalContactBroker : AppraisalContactData
    {
        /// <summary>
        /// The brokers branch identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }
    }
}