namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessToProductPricingRights
    /// </summary>
    public sealed class AccessToProductPricingRights : ParentAccessRights
    {
        private DirtyValue<bool?> _viewLockHistory;

        /// <summary>
        /// AccessToProductPricingRights ViewLockHistory
        /// </summary>
        public bool? ViewLockHistory { get => _viewLockHistory; set => SetField(ref _viewLockHistory, value); }
    }
}