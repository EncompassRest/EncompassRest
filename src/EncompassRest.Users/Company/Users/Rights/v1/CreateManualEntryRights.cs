using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CreateManualEntryRights
    /// </summary>
    public sealed class CreateManualEntryRights : ParentAccessRights
    {
        /// <summary>
        /// CreateManualEntryRights CD
        /// </summary>
        public bool? CD { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CreateManualEntryRights LESSPLSafeHarbor
        /// </summary>
        [JsonProperty("lE/SSPL/SafeHarbor")]
        public bool? LESSPLSafeHarbor { get => GetValue<bool?>(); set => SetValue(value); }
    }
}