namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LockComparisonToolRights
    /// </summary>
    public sealed class LockComparisonToolRights : DirtyExtensibleObject
    {
        /// <summary>
        /// LockComparisonToolRights ValidatePricing
        /// </summary>
        public bool? ValidatePricing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}