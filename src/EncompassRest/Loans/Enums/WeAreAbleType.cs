using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum WeAreAbleType
    {
        [EnumMember(Value = "will")]
        Will = 0,
        [EnumMember(Value = "will not")]
        WillNot = 1,
        [EnumMember(Value = "haven't decided to")]
        HaventDecidedTo = 2
    }
}