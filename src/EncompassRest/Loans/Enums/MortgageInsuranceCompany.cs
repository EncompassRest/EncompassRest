using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum MortgageInsuranceCompany
    {
        [EnumMember(Value = "01")]
        n01 = 1,
        [EnumMember(Value = "06")]
        n06 = 6,
        [EnumMember(Value = "11")]
        n11 = 11,
        [EnumMember(Value = "12")]
        n12 = 12,
        [EnumMember(Value = "13")]
        n13 = 13,
        [EnumMember(Value = "24")]
        n24 = 24,
        [EnumMember(Value = "33")]
        n33 = 33,
        [EnumMember(Value = "38")]
        n38 = 38
    }
}