using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// NmlsRefinancePurposeType
    /// </summary>
    public enum NmlsRefinancePurposeType
    {
        /// <summary>
        /// Purchase
        /// </summary>
        Purchase = 0,
        /// <summary>
        /// Refinance Rate-Term
        /// </summary>
        [Description("Refinance Rate-Term")]
        RefiRateTerm = 1,
        /// <summary>
        /// Refinance Cash-Out Refinance
        /// </summary>
        [Description("Refinance Cash-Out Refinance")]
        RefiCashOut = 2,
        /// <summary>
        /// Refinance Restructure
        /// </summary>
        [Description("Refinance Restructure")]
        RefiRestructure = 3,
        /// <summary>
        /// Refinance Other/Unknown
        /// </summary>
        [Description("Refinance Other/Unknown")]
        RefiOther = 4
    }
}