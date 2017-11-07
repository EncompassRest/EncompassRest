using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HOEPAStatus
    {
        [EnumMember(Value = "HOEPA Loan")]
        HOEPALoan = 0,
        [EnumMember(Value = "Not a HOEPA Loan")]
        NotAHOEPALoan = 1,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 2
    }
}