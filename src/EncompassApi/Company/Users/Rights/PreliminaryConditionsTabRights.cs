namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// PreliminaryConditionsTabRights
    /// </summary>
    public sealed class PreliminaryConditionsTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addAutomatedConditions;
        private DirtyValue<bool?>? _addEditDeleteConditions;

        /// <summary>
        /// PreliminaryConditionsTabRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => _addAutomatedConditions; set => SetField(ref _addAutomatedConditions, value); }

        /// <summary>
        /// PreliminaryConditionsTabRights AddEditDeleteConditions
        /// </summary>
        public bool? AddEditDeleteConditions { get => _addEditDeleteConditions; set => SetField(ref _addEditDeleteConditions, value); }
    }
}