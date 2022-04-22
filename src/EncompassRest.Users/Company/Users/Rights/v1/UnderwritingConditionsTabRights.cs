using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnderwritingConditionsTabRights
    /// </summary>
    public sealed class UnderwritingConditionsTabRights : ParentAccessRights
    {
        /// <summary>
        /// UnderwritingConditionsTabRights AddEditDeleteComments
        /// </summary>
        [JsonProperty("add/Edit/DeleteComments")]
        public bool? AddEditDeleteComments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnderwritingConditionsTabRights AddSupportingDocuments
        /// </summary>
        public bool? AddSupportingDocuments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnderwritingConditionsTabRights ChangePriorTo
        /// </summary>
        public bool? ChangePriorTo { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnderwritingConditionsTabRights MarkStatusCompleted
        /// </summary>
        [AllowNull]
        public MarkStatusCompletedRights MarkStatusCompleted { get => GetEntity<MarkStatusCompletedRights>(); set => SetEntity(value); }

        /// <summary>
        /// UnderwritingConditionsTabRights NewEditDeleteConditions
        /// </summary>
        [JsonProperty("new/Edit/DeleteConditions")]
        [AllowNull]
        public NewEditDeleteConditionsRights NewEditDeleteConditions { get => GetEntity<NewEditDeleteConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UnderwritingConditionsTabRights RemoveSupportingDocuments
        /// </summary>
        public bool? RemoveSupportingDocuments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}