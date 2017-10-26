using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RiskGradeEvaluationType
    {
        [EnumMember(Value = "00")]
        n00 = 0,
        [EnumMember(Value = "01")]
        n01 = 1,
        [EnumMember(Value = "05")]
        n05 = 2,
        [EnumMember(Value = "11")]
        n11 = 3,
        [EnumMember(Value = "12")]
        n12 = 4,
        [EnumMember(Value = "13")]
        n13 = 5,
        [EnumMember(Value = "16")]
        n16 = 6,
        [EnumMember(Value = "24")]
        n24 = 7,
        [EnumMember(Value = "33")]
        n33 = 8,
        [EnumMember(Value = "58")]
        n58 = 9,
        [EnumMember(Value = "91")]
        n91 = 10,
        [EnumMember(Value = "92")]
        n92 = 11,
        [EnumMember(Value = "98")]
        n98 = 12,
        [EnumMember(Value = "99")]
        n99 = 13
    }
}