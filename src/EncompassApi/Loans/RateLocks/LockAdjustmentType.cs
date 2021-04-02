using System.Runtime.Serialization;

namespace EncompassApi.Loans.RateLocks
{
    /// <summary>
    /// LockAdjustmentType
    /// </summary>
    public enum LockAdjustmentType
    {
        /// <summary>
        /// Undefined
        /// </summary>
        [EnumMember(Value = "undefined")]
        Undefined = 0,
        /// <summary>
        /// Adjustment
        /// </summary>
        [EnumMember(Value = "adjustment")]
        Adjustment = 1,
        /// <summary>
        /// LockExtensionAdjustment
        /// </summary>
        [EnumMember(Value = "lockExtensionAdjustment")]
        LockExtensionAdjustment = 2
    }
}