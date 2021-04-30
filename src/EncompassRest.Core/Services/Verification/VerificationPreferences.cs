using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    /// <summary>
    /// VerificationPreferences
    /// </summary>
    public sealed class VerificationPreferences : ExtensibleObject
    {
        /// <summary>
        /// When set to true, imports all liabilities. When set to false, no liabilities are imported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportLiabilities { get; set; }

        /// <summary>
        /// Whether to exclude zero liability balances from silent liability import files.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeZeroBalances { get; set; }

        /// <summary>
        /// When set to true, the service provider’s response is automatically saved to Encompass. When set to false, the lender is prompted to save the service provider’s response to Encompass.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autosave { get; set; }
    }
}