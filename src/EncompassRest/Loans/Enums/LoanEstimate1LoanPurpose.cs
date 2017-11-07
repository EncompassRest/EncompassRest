using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanEstimate1LoanPurpose
    {
        Purchase = 0,
        Refinance = 1,
        Construction = 2,
        [EnumMember(Value = "Home Equity Loan")]
        HomeEquityLoan = 3
    }
}