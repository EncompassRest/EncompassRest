using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PurchaseConditionsRights
    /// </summary>
    public sealed class PurchaseConditionsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addEditDeleteComments;
        private DirtyValue<bool?>? _addAutomatedConditions;
        private DirtyValue<bool?>? _addSupportingDocuments;
        private DirtyValue<bool?>? _changePriorTo;
        private DirtyValue<bool?>? _markStatusCompleted;
        private NewEditDeleteConditionsRights? _newEditDeleteConditions;
        private DirtyValue<bool?>? _removeSupportingDocuments;

        /// <summary>
        /// PurchaseConditionsRights AddEditDeleteComments
        /// </summary>
        [JsonProperty("add/Edit/DeleteComments")]
        public bool? AddEditDeleteComments { get => _addEditDeleteComments; set => SetField(ref _addEditDeleteComments, value); }

        /// <summary>
        /// PurchaseConditionsRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => _addAutomatedConditions; set => SetField(ref _addAutomatedConditions, value); }

        /// <summary>
        /// PurchaseConditionsRights AddSupportingDocuments
        /// </summary>
        public bool? AddSupportingDocuments { get => _addSupportingDocuments; set => SetField(ref _addSupportingDocuments, value); }

        /// <summary>
        /// PurchaseConditionsRights ChangePriorTo
        /// </summary>
        public bool? ChangePriorTo { get => _changePriorTo; set => SetField(ref _changePriorTo, value); }

        /// <summary>
        /// PurchaseConditionsRights MarkStatusCompleted
        /// </summary>
        public bool? MarkStatusCompleted { get => _markStatusCompleted; set => SetField(ref _markStatusCompleted, value); }

        /// <summary>
        /// PurchaseConditionsRights NewEditDeleteConditions
        /// </summary>
        [JsonProperty("new/Edit/DeleteConditions")]
        [AllowNull]
        public NewEditDeleteConditionsRights NewEditDeleteConditions { get => GetField(ref _newEditDeleteConditions); set => SetField(ref _newEditDeleteConditions, value); }

        /// <summary>
        /// PurchaseConditionsRights RemoveSupportingDocuments
        /// </summary>
        public bool? RemoveSupportingDocuments { get => _removeSupportingDocuments; set => SetField(ref _removeSupportingDocuments, value); }
    }
}