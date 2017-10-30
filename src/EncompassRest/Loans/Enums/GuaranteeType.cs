using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GuaranteeType
    {
        [EnumMember(Value = "1. Line of Credit")]
        n1LineOfCredit = 1,
        [EnumMember(Value = "2. Loan Note Guarantee")]
        n2LoanNoteGuarantee = 2
    }
}