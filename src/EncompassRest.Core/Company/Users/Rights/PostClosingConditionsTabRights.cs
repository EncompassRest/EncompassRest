using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PostClosingConditionsTabRights
    /// </summary>
    public sealed class PostClosingConditionsTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addEditDeleteConditions;
        private DirtyValue<bool?>? _addAutomatedConditions;

        /// <summary>
        /// PostClosingConditionsTabRights AddEditDeleteConditions
        /// </summary>
        [JsonProperty("add/Edit/DeleteConditions")]
        public bool? AddEditDeleteConditions { get => _addEditDeleteConditions; set => SetField(ref _addEditDeleteConditions, value); }

        /// <summary>
        /// PostClosingConditionsTabRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => _addAutomatedConditions; set => SetField(ref _addAutomatedConditions, value); }
    }
}