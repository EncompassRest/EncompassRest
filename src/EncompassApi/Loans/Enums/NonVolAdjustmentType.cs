using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// NonVolAdjustmentType
    /// </summary>
    public enum NonVolAdjustmentType
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