using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PerDiemCalculationMethodType
    {
        [EnumMember(Value = "360/360")]
        n360360 = 0,
        [EnumMember(Value = "365/360")]
        n365360 = 1,
        [EnumMember(Value = "365/365")]
        n365365 = 2
    }
}