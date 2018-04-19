using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// AdjustmentType
    /// </summary>
    public enum AdjustmentType
    {
        /// <summary>
        /// Gift
        /// </summary>
        Gift = 0,
        /// <summary>
        /// Grant
        /// </summary>
        Grant = 1,
        /// <summary>
        /// Rebate Credit
        /// </summary>
        [Description("Rebate Credit")]
        RebateCredit = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3
    }
}