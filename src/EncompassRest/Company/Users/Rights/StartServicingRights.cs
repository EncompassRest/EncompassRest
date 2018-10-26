using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// StartServicingRights
    /// </summary>
    public sealed class StartServicingRights : ParentAccessRights
    {
        private DirtyValue<bool?> _reStartServicing;

        /// <summary>
        /// StartServicingRights ReStartServicing
        /// </summary>
        [JsonProperty("re-StartServicing")]
        public bool? ReStartServicing { get => _reStartServicing; set => SetField(ref _reStartServicing, value); }
    }
}