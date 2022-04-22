using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// StartServicingRights
    /// </summary>
    public sealed class StartServicingRights : ParentAccessRights
    {
        /// <summary>
        /// StartServicingRights ReStartServicing
        /// </summary>
        [JsonProperty("re-StartServicing")]
        public bool? ReStartServicing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}