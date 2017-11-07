using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanAmountType
    {
        [EnumMember(Value = "Total Loan")]
        TotalLoan = 0,
        [EnumMember(Value = "Base Loan")]
        BaseLoan = 1
    }
}