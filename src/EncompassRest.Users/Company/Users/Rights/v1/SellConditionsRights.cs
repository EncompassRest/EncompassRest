using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SellConditionsRights
    /// </summary>
    public sealed class SellConditionsRights : ParentAccessRights
    {
        /// <summary>
        /// SellConditionsRights AddEditDeleteConditions
        /// </summary>
        [JsonProperty("add/Edit/DeleteConditions")]
        public bool? AddEditDeleteConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SellConditionsRights ConditionDeliveryStatus
        /// </summary>
        public bool? ConditionDeliveryStatus { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SellConditionsRights DeliverConditionResponse
        /// </summary>
        public bool? DeliverConditionResponse { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SellConditionsRights ImportAllDeliveryConditons
        /// </summary>
        public bool? ImportAllDeliveryConditons { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SellConditionsRights ImportInvestorConditions
        /// </summary>
        [JsonProperty("importInvestorConditons")]
        public bool? ImportInvestorConditions { get => GetValue<bool?>(); set => SetValue(value); }
    }
}