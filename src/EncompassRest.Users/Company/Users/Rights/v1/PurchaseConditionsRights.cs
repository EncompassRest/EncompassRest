using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PurchaseConditionsRights
    /// </summary>
    public sealed class PurchaseConditionsRights : ParentAccessRights
    {
        /// <summary>
        /// PurchaseConditionsRights AddEditDeleteComments
        /// </summary>
        [JsonProperty("add/Edit/DeleteComments")]
        public bool? AddEditDeleteComments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PurchaseConditionsRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PurchaseConditionsRights AddSupportingDocuments
        /// </summary>
        public bool? AddSupportingDocuments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PurchaseConditionsRights ChangePriorTo
        /// </summary>
        public bool? ChangePriorTo { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PurchaseConditionsRights MarkStatusCompleted
        /// </summary>
        public bool? MarkStatusCompleted { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PurchaseConditionsRights NewEditDeleteConditions
        /// </summary>
        [JsonProperty("new/Edit/DeleteConditions")]
        [AllowNull]
        public NewEditDeleteConditionsRights NewEditDeleteConditions { get => GetEntity<NewEditDeleteConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// PurchaseConditionsRights RemoveSupportingDocuments
        /// </summary>
        public bool? RemoveSupportingDocuments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}