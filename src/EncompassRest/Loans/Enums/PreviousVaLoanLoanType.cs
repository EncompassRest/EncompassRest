using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PreviousVaLoanLoanType
    {
        [EnumMember(Value = "VA-Guaranteed Loan")]
        VAGuaranteedLoan = 0,
        [EnumMember(Value = "One-Time Only Restoration")]
        OneTimeOnlyRestoration = 1,
        [EnumMember(Value = "Regular Cash-Out Refinance")]
        RegularCashOutRefinance = 2,
        [EnumMember(Value = "Regular None Cash-Out Refinance")]
        RegularNoneCashOutRefinance = 3
    }
}