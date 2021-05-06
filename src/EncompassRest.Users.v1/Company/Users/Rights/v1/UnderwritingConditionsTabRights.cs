using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnderwritingConditionsTabRights
    /// </summary>
    public sealed class UnderwritingConditionsTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addEditDeleteComments;
        private DirtyValue<bool?>? _addSupportingDocuments;
        private DirtyValue<bool?>? _changePriorTo;
        private MarkStatusCompletedRights? _markStatusCompleted;
        private NewEditDeleteConditionsRights? _newEditDeleteConditions;
        private DirtyValue<bool?>? _removeSupportingDocuments;

        /// <summary>
        /// UnderwritingConditionsTabRights AddEditDeleteComments
        /// </summary>
        [JsonProperty("add/Edit/DeleteComments")]
        public bool? AddEditDeleteComments { get => _addEditDeleteComments; set => SetField(ref _addEditDeleteComments, value); }

        /// <summary>
        /// UnderwritingConditionsTabRights AddSupportingDocuments
        /// </summary>
        public bool? AddSupportingDocuments { get => _addSupportingDocuments; set => SetField(ref _addSupportingDocuments, value); }

        /// <summary>
        /// UnderwritingConditionsTabRights ChangePriorTo
        /// </summary>
        public bool? ChangePriorTo { get => _changePriorTo; set => SetField(ref _changePriorTo, value); }

        /// <summary>
        /// UnderwritingConditionsTabRights MarkStatusCompleted
        /// </summary>
        [AllowNull]
        public MarkStatusCompletedRights MarkStatusCompleted { get => GetField(ref _markStatusCompleted); set => SetField(ref _markStatusCompleted, value); }

        /// <summary>
        /// UnderwritingConditionsTabRights NewEditDeleteConditions
        /// </summary>
        [JsonProperty("new/Edit/DeleteConditions")]
        [AllowNull]
        public NewEditDeleteConditionsRights NewEditDeleteConditions { get => GetField(ref _newEditDeleteConditions); set => SetField(ref _newEditDeleteConditions, value); }

        /// <summary>
        /// UnderwritingConditionsTabRights RemoveSupportingDocuments
        /// </summary>
        public bool? RemoveSupportingDocuments { get => _removeSupportingDocuments; set => SetField(ref _removeSupportingDocuments, value); }
    }
}