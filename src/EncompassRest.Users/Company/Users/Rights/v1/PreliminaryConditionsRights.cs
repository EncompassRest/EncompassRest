namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PreliminaryConditionsRights
    /// </summary>
    public sealed class PreliminaryConditionsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _importConditions;

        /// <summary>
        /// PreliminaryConditionsRights ImportConditions
        /// </summary>
        public bool? ImportConditions { get => _importConditions; set => SetField(ref _importConditions, value); }
    }
}