using Newtonsoft.Json;

namespace EncompassApi.Services.Credit
{
    /// <summary>
    /// CreditPreferences
    /// </summary>
    public sealed class CreditPreferences : ExtensibleObject
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
        public bool? ExcludeZeroForImportLiabilities { get; set; }

        /// <summary>
        /// When set to true, the service provider’s response is automatically saved to Encompass. When set to false, the lender is prompted to save the service provider’s response to Encompass.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autosave { get; set; }
    }
}