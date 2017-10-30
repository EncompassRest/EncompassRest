using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GiftFundsSource
    {
        [EnumMember(Value = "00")]
        n00 = 0,
        [EnumMember(Value = "01")]
        n01 = 1,
        [EnumMember(Value = "02")]
        n02 = 2,
        [EnumMember(Value = "03")]
        n03 = 3,
        [EnumMember(Value = "06")]
        n06 = 6,
        [EnumMember(Value = "15")]
        n15 = 15
    }
}