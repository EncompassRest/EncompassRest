using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SalesRepsAERights
    /// </summary>
    public sealed class SalesRepsAERights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editSalesRepsAE;

        /// <summary>
        /// SalesRepsAERights EditSalesRepsAE
        /// </summary>
        [JsonProperty("editSalesReps/AE")]
        public bool? EditSalesRepsAE { get => _editSalesRepsAE; set => SetField(ref _editSalesRepsAE, value); }
    }
}