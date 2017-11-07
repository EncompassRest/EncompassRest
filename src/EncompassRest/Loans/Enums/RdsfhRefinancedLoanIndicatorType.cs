using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RdsfhRefinancedLoanIndicatorType
    {
        [EnumMember(Value = "Guaranteed Loan")]
        GuaranteedLoan = 0,
        [EnumMember(Value = "Direct Loan")]
        DirectLoan = 1
    }
}