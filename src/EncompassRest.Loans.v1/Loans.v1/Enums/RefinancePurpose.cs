using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RefinancePurpose
    /// </summary>
    public enum RefinancePurpose
    {
        /// <summary>
        /// Cash-Out Debt Consolidation
        /// </summary>
        [Description("Cash-Out Debt Consolidation")]
        CashOutDebtConsolidation = 0,
        /// <summary>
        /// Cash-Out Home Improvement
        /// </summary>
        [Description("Cash-Out Home Improvement")]
        CashOutHomeImprovement = 1,
        /// <summary>
        /// Cash-Out Limited
        /// </summary>
        [Description("Cash-Out Limited")]
        CashOutLimited = 2,
        /// <summary>
        /// Cash-Out Other
        /// </summary>
        [Description("Cash-Out Other")]
        CashOutOther = 3,
        /// <summary>
        /// Cash-Out With Original Lender
        /// </summary>
        [Description("Cash-Out With Original Lender")]
        CashOutOriginalLender = 4,
        /// <summary>
        /// No Cash-Out Rate/Term
        /// </summary>
        [Description("No Cash-Out Rate/Term")]
        ChangeInRateTerm = 5,
        /// <summary>
        /// No Cash-Out Other
        /// </summary>
        [Description("No Cash-Out Other")]
        NoCashOutOther = 6,
        /// <summary>
        /// No Cash-Out FHA Streamlined
        /// </summary>
        [Description("No Cash-Out FHA Streamlined")]
        NoCashOutFHAStreamlinedRefinance = 7,
        /// <summary>
        /// No Cash-Out Freddie Owned
        /// </summary>
        [Description("No Cash-Out Freddie Owned")]
        NoCashOutFREOwnedRefinance = 8,
        /// <summary>
        /// No Cash-Out Streamlined
        /// </summary>
        [Description("No Cash-Out Streamlined")]
        NoCashOutStreamlinedRefinance = 9,
        /// <summary>
        /// No Cash-Out With Original Lender
        /// </summary>
        [Description("No Cash-Out With Original Lender")]
        NoCashOutOriginalLender = 10
    }
}