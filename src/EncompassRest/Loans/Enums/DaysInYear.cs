using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DaysInYear
    {
        [EnumMember(Value = "360")]
        n360 = 360,
        [EnumMember(Value = "364")]
        n364 = 364,
        [EnumMember(Value = "365")]
        n365 = 365
    }
}