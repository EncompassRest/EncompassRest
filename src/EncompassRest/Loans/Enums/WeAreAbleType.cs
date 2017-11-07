using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum WeAreAbleType
    {
        [EnumMember(Value = "will not")]
        WillNot = 0,
        [EnumMember(Value = "will")]
        Will = 1,
        [EnumMember(Value = "haven't decided to")]
        HaventDecidedTo = 2
    }
}