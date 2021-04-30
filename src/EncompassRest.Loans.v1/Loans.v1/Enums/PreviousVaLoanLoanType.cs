using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PreviousVaLoanLoanType
    /// </summary>
    public enum PreviousVaLoanLoanType
    {
        /// <summary>
        /// VA-Guaranteed Loan
        /// </summary>
        [EnumMember(Value = "VA-Guaranteed Loan")]
        VAGuaranteedLoan = 0,
        /// <summary>
        /// One-Time Only Restoration
        /// </summary>
        [EnumMember(Value = "One-Time Only Restoration")]
        OneTimeOnlyRestoration = 1,
        /// <summary>
        /// Regular Cash-Out Refinance
        /// </summary>
        [EnumMember(Value = "Regular Cash-Out Refinance")]
        RegularCashOutRefinance = 2,
        /// <summary>
        /// Regular None Cash-Out Refinance
        /// </summary>
        [EnumMember(Value = "Regular None Cash-Out Refinance")]
        RegularNoneCashOutRefinance = 3
    }
}