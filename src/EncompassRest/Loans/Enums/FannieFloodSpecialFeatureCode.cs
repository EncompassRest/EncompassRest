using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieFloodSpecialFeatureCode
    {
        [EnumMember(Value = "170")]
        n170 = 0,
        [EnumMember(Value = "175")]
        n175 = 1,
        [EnumMember(Value = "180")]
        n180 = 2
    }
}