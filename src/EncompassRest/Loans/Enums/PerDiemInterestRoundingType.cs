using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PerDiemInterestRoundingType
    {
        [EnumMember(Value = "2 Decimals")]
        n2Decimals = 2,
        [EnumMember(Value = "4 Decimals")]
        n4Decimals = 4,
        [EnumMember(Value = "No Rounding")]
        NoRounding = 100
    }
}