using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// LoanPurposeOfRefinanceType
    /// </summary>
    public enum LoanPurposeOfRefinanceType
    {
        /// <summary>
        /// Full Documentation
        /// </summary>
        [Description("Full Documentation")]
        FullDocumentation = 0,
        /// <summary>
        /// Interest Rate Reduction Refinance Loan
        /// </summary>
        [Description("Interest Rate Reduction Refinance Loan")]
        InterestRateReductionRefinanceLoan = 1,
        /// <summary>
        /// Streamline With Appraisal
        /// </summary>
        [Description("Streamline With Appraisal")]
        StreamlineWithAppraisal = 2,
        /// <summary>
        /// Streamline Without Appraisal
        /// </summary>
        [Description("Streamline Without Appraisal")]
        StreamlineWithoutAppraisal = 3,
        /// <summary>
        /// HOPE For Homeowners
        /// </summary>
        [Description("HOPE For Homeowners")]
        HOPEForHomeowners = 4,
        /// <summary>
        /// Prior FHA
        /// </summary>
        [Description("Prior FHA")]
        PriorFHA = 5
    }
}