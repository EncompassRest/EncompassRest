using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// SellConditionsRights
    /// </summary>
    public sealed class SellConditionsRights : ParentAccessRights
    {
        private DirtyValue<bool?> _addEditDeleteConditions;
        private DirtyValue<bool?> _importInvestorConditions;

        /// <summary>
        /// SellConditionsRights AddEditDeleteConditions
        /// </summary>
        [JsonProperty("add/Edit/DeleteConditions")]
        public bool? AddEditDeleteConditions { get => _addEditDeleteConditions; set => SetField(ref _addEditDeleteConditions, value); }

        /// <summary>
        /// SellConditionsRights ImportInvestorConditions
        /// </summary>
        [JsonProperty("importInvestorConditons")]
        public bool? ImportInvestorConditions { get => _importInvestorConditions; set => SetField(ref _importInvestorConditions, value); }
    }
}