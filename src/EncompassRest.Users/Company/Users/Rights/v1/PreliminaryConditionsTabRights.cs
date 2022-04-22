namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PreliminaryConditionsTabRights
    /// </summary>
    public sealed class PreliminaryConditionsTabRights : ParentAccessRights
    {
        /// <summary>
        /// PreliminaryConditionsTabRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PreliminaryConditionsTabRights AddEditDeleteConditions
        /// </summary>
        public bool? AddEditDeleteConditions { get => GetValue<bool?>(); set => SetValue(value); }
    }
}