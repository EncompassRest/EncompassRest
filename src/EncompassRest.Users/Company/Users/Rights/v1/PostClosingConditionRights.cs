namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PostClosingConditionRights
    /// </summary>
    public sealed class PostClosingConditionRights : DirtyExtensibleObject
    {
        /// <summary>
        /// PostClosingConditionRights ImportConditions
        /// </summary>
        public bool? ImportConditions { get => GetValue<bool?>(); set => SetValue(value); }
    }
}