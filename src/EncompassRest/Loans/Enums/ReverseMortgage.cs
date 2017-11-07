using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ReverseMortgage
    {
        [EnumMember(Value = "Reverse mortgage")]
        ReverseMortgage = 0,
        [EnumMember(Value = "Not a reverse mortgage")]
        NotAReverseMortgage = 1
    }
}