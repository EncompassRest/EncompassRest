using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RoundingMethod
    {
        [EnumMember(Value = "To Nearest Cent")]
        ToNearestCent = 0,
        [EnumMember(Value = "To Nearest Dollar")]
        ToNearestDollar = 1
    }
}