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
        n05 = 5,
        [EnumMember(Value = "11")]
        n11 = 11,
        [EnumMember(Value = "12")]
        n12 = 12,
        [EnumMember(Value = "13")]
        n13 = 13,
        [EnumMember(Value = "16")]
        n16 = 16,
        [EnumMember(Value = "24")]
        n24 = 24,
        [EnumMember(Value = "33")]
        n33 = 33,
        [EnumMember(Value = "58")]
        n58 = 58,
        [EnumMember(Value = "91")]
        n91 = 91,
        [EnumMember(Value = "92")]
        n92 = 92,
        [EnumMember(Value = "98")]
        n98 = 98,
        [EnumMember(Value = "99")]
        n99 = 99
    }
}