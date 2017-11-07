using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SignedByTyp
    {
        [EnumMember(Value = "Loan Originator")]
        LoanOriginator = 0,
        [EnumMember(Value = "Loan Closer")]
        LoanCloser = 1,
        [EnumMember(Value = "Lender Contact")]
        LenderContact = 2
    }
}