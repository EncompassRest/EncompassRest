namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PreliminaryConditionsRights
    /// </summary>
    public sealed class PreliminaryConditionsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// PreliminaryConditionsRights ImportConditions
        /// </summary>
        public bool? ImportConditions { get => GetValue<bool?>(); set => SetValue(value); }
    }
}