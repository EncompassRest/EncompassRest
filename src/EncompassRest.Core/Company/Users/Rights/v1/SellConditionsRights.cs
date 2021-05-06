using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SellConditionsRights
    /// </summary>
    public sealed class SellConditionsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addEditDeleteConditions;
        private DirtyValue<bool?>? _conditionDeliveryStatus;
        private DirtyValue<bool?>? _deliverConditionResponse;
        private DirtyValue<bool?>? _importAllDeliveryConditons;
        private DirtyValue<bool?>? _importInvestorConditions;

        /// <summary>
        /// SellConditionsRights AddEditDeleteConditions
        /// </summary>
        [JsonProperty("add/Edit/DeleteConditions")]
        public bool? AddEditDeleteConditions { get => _addEditDeleteConditions; set => SetField(ref _addEditDeleteConditions, value); }

        /// <summary>
        /// SellConditionsRights ConditionDeliveryStatus
        /// </summary>
        public bool? ConditionDeliveryStatus { get => _conditionDeliveryStatus; set => SetField(ref _conditionDeliveryStatus, value); }

        /// <summary>
        /// SellConditionsRights DeliverConditionResponse
        /// </summary>
        public bool? DeliverConditionResponse { get => _deliverConditionResponse; set => SetField(ref _deliverConditionResponse, value); }

        /// <summary>
        /// SellConditionsRights ImportAllDeliveryConditons
        /// </summary>
        public bool? ImportAllDeliveryConditons { get => _importAllDeliveryConditons; set => SetField(ref _importAllDeliveryConditons, value); }

        /// <summary>
        /// SellConditionsRights ImportInvestorConditions
        /// </summary>
        [JsonProperty("importInvestorConditons")]
        public bool? ImportInvestorConditions { get => _importInvestorConditions; set => SetField(ref _importInvestorConditions, value); }
    }
}