namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToProductPricingRights
    /// </summary>
    public sealed class AccessToProductPricingRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToProductPricingRights ViewLockHistory
        /// </summary>
        public bool? ViewLockHistory { get => GetValue<bool?>(); set => SetValue(value); }
    }
}