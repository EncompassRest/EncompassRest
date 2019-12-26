using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// CreateManualEntryRights
    /// </summary>
    public sealed class CreateManualEntryRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _cD;
        private DirtyValue<bool?>? _lESSPLSafeHarbor;

        /// <summary>
        /// CreateManualEntryRights CD
        /// </summary>
        public bool? CD { get => _cD; set => SetField(ref _cD, value); }

        /// <summary>
        /// CreateManualEntryRights LESSPLSafeHarbor
        /// </summary>
        [JsonProperty("lE/SSPL/SafeHarbor")]
        public bool? LESSPLSafeHarbor { get => _lESSPLSafeHarbor; set => SetField(ref _lESSPLSafeHarbor, value); }
    }
}