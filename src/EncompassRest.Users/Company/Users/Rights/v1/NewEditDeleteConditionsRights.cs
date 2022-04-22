namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// NewEditDeleteConditionsRights
    /// </summary>
    public sealed class NewEditDeleteConditionsRights : ParentAccessRights
    {
        /// <summary>
        /// NewEditDeleteConditionsRights ChangeSignoffDates
        /// </summary>
        public bool? ChangeSignoffDates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// NewEditDeleteConditionsRights ChangeSignoffNames
        /// </summary>
        public bool? ChangeSignoffNames { get => GetValue<bool?>(); set => SetValue(value); }
    }
}