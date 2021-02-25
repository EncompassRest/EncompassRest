namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// NewEditDeleteConditionsRights
    /// </summary>
    public sealed class NewEditDeleteConditionsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _changeSignoffDates;
        private DirtyValue<bool?>? _changeSignoffNames;

        /// <summary>
        /// NewEditDeleteConditionsRights ChangeSignoffDates
        /// </summary>
        public bool? ChangeSignoffDates { get => _changeSignoffDates; set => SetField(ref _changeSignoffDates, value); }

        /// <summary>
        /// NewEditDeleteConditionsRights ChangeSignoffNames
        /// </summary>
        public bool? ChangeSignoffNames { get => _changeSignoffNames; set => SetField(ref _changeSignoffNames, value); }
    }
}