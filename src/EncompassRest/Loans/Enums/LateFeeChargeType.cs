using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LateFeeChargeType
    {
        [EnumMember(Value = "Total Loan Amount")]
        TotalLoanAmount = 0,
        [EnumMember(Value = "Base Loan Amount")]
        BaseLoanAmount = 1
    }
}