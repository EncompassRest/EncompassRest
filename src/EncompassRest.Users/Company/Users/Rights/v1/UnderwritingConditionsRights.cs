namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnderwritingConditionsRights
    /// </summary>
    public sealed class UnderwritingConditionsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// UnderwritingConditionsRights ImportConditions
        /// </summary>
        public bool? ImportConditions { get => GetValue<bool?>(); set => SetValue(value); }
    }
}