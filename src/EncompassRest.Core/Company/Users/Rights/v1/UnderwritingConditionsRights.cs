namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnderwritingConditionsRights
    /// </summary>
    public sealed class UnderwritingConditionsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _importConditions;

        /// <summary>
        /// UnderwritingConditionsRights ImportConditions
        /// </summary>
        public bool? ImportConditions { get => _importConditions; set => SetField(ref _importConditions, value); }
    }
}