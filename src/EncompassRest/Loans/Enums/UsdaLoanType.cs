using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum UsdaLoanType
    {
        [EnumMember(Value = "Section 502")]
        Section502 = 0,
        [EnumMember(Value = "Section 504 Loan")]
        Section504Loan = 1,
        Grant = 2
    }
}