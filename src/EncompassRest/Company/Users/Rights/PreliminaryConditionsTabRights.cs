namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PreliminaryConditionsTabRights
    /// </summary>
    public sealed class PreliminaryConditionsTabRights : ParentAccessRights
    {
        private DirtyValue<bool?> _addAutomatedConditions;

        /// <summary>
        /// PreliminaryConditionsTabRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => _addAutomatedConditions; set => SetField(ref _addAutomatedConditions, value); }
    }
}