using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PerDiemInterestRoundingType
    {
        [EnumMember(Value = "2 Decimals")]
        n2Decimals = 0,
        [EnumMember(Value = "4 Decimals")]
        n4Decimals = 1,
        [EnumMember(Value = "No Rounding")]
        NoRounding = 2
    }
}