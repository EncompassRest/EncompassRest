using Newtonsoft.Json;

namespace EncompassApi.Services.Appraisal
{
    /// <summary>
    /// AppraisalCredentials
    /// </summary>
    public sealed class AppraisalCredentials : ServiceCredentials
    {
        /// <summary>
        /// The identifier that Mercury Network assigns to identify your organization on their platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountId { get; set; }
    }
}