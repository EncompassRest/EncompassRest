using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SalesRepsAERights
    /// </summary>
    public sealed class SalesRepsAERights : ParentAccessRights
    {
        /// <summary>
        /// SalesRepsAERights EditSalesRepsAE
        /// </summary>
        [JsonProperty("editSalesReps/AE")]
        public bool? EditSalesRepsAE { get => GetValue<bool?>(); set => SetValue(value); }
    }
}