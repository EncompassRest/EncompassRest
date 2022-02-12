using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// GovernmentRefinanceType
/// </summary>
public enum GovernmentRefinanceType
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
    /// Other
    /// </summary>
    Other = 2,
    /// <summary>
    /// Streamline With Appraisal
    /// </summary>
    [Description("Streamline With Appraisal")]
    StreamlineWithAppraisal = 3,
    /// <summary>
    /// Streamline Without Appraisal
    /// </summary>
    [Description("Streamline Without Appraisal")]
    StreamlineWithoutAppraisal = 4
}