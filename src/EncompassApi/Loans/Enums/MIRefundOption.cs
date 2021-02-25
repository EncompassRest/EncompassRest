using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// MIRefundOption
    /// </summary>
    public enum MIRefundOption
    {
        /// <summary>
        /// Refundable
        /// </summary>
        [Description("Refundable")]
        Y = 0,
        /// <summary>
        /// Not Refundable
        /// </summary>
        [Description("Not Refundable")]
        N = 1,
        /// <summary>
        /// Refundable With Limits
        /// </summary>
        [Description("Refundable With Limits")]
        L = 2
    }
}