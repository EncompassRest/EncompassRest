using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum YearsOfCoverage
    {
        [EnumMember(Value = "1")]
        n1 = 1,
        [EnumMember(Value = "3")]
        n3 = 3,
        [EnumMember(Value = "5")]
        n5 = 5,
        [EnumMember(Value = "6")]
        n6 = 6,
        [EnumMember(Value = "7")]
        n7 = 7,
        [EnumMember(Value = "10")]
        n10 = 10,
        [EnumMember(Value = "12")]
        n12 = 12,
        [EnumMember(Value = "15")]
        n15 = 15,
        [EnumMember(Value = "99")]
        n99 = 99
    }
}