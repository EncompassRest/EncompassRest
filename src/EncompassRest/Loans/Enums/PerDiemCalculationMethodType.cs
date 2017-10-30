using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PerDiemCalculationMethodType
    {
        [EnumMember(Value = "360/360")]
        n360_360 = 0,
        [EnumMember(Value = "365/360")]
        n365_360 = 1,
        [EnumMember(Value = "365/365")]
        n365_365 = 2
    }
}