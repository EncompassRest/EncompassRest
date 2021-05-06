using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LoanCode
    /// </summary>
    public enum LoanCode
    {
        /// <summary>
        /// Purchase
        /// </summary>
        Purchase = 0,
        /// <summary>
        /// IRRRL (streamline Refi)
        /// </summary>
        [Description("IRRRL (streamline Refi)")]
        IRRRL = 1,
        /// <summary>
        /// Cash out Refi (max 100% LTV)
        /// </summary>
        [Description("Cash out Refi (max 100% LTV)")]
        CashOutRefi = 2,
        /// <summary>
        /// Manufactured Home Refi
        /// </summary>
        [Description("Manufactured Home Refi")]
        ManufacturedHome = 3,
        /// <summary>
        /// Refinancing over 90% of RV
        /// </summary>
        [Description("Refinancing over 90% of RV")]
        RefinancingOver = 4
    }
}