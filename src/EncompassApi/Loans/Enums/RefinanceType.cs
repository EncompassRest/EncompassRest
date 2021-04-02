using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RefinanceType
    /// </summary>
    public enum RefinanceType
    {
        /// <summary>
        /// Cash-Out Refinance
        /// </summary>
        [Description("Cash-Out Refinance")]
        CashOutRefinance = 0,
        /// <summary>
        /// No Cash-Out Refinance
        /// </summary>
        [Description("No Cash-Out Refinance")]
        RegularRefinance = 1,
        /// <summary>
        /// Streamline w/ Appraisal
        /// </summary>
        [Description("Streamline w/ Appraisal")]
        StreamlineWithAppraisal = 2,
        /// <summary>
        /// Streamline w/o Appraisal
        /// </summary>
        [Description("Streamline w/o Appraisal")]
        StreamlineWithoutAppraisal = 3
    }
}