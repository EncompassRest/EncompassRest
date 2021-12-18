namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// AdjustmentType
    /// </summary>
    public enum AdjustmentType
    {
        /// <summary>
        /// Adjustment
        /// </summary>
        Adjustment = 0,
        /// <summary>
        /// LockExtensionAdjustment
        /// </summary>
        LockExtensionAdjustment = 1,
        /// <summary>
        /// ReLockFeeAdjustment
        /// </summary>
        ReLockFeeAdjustment = 2,
        /// <summary>
        /// CustomPriceAdjustment
        /// </summary>
        CustomPriceAdjustment = 3,
        /// <summary>
        /// Undefined
        /// </summary>
        Undefined = 4
    }
}