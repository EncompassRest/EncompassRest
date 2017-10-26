using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanOption
    {
        [EnumMember(Value = "Loan Option 1")]
        LoanOption1 = 0,
        [EnumMember(Value = "Loan Option 2")]
        LoanOption2 = 1,
        [EnumMember(Value = "Loan Option 3")]
        LoanOption3 = 2,
        [EnumMember(Value = "Loan Option 4")]
        LoanOption4 = 3,
        [EnumMember(Value = "Other Option")]
        OtherOption = 4
    }
}