using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieMacArmIndexType
    {
        [EnumMember(Value = "01")]
        n01 = 1,
        [EnumMember(Value = "02")]
        n02 = 2,
        [EnumMember(Value = "03")]
        n03 = 3,
        [EnumMember(Value = "29")]
        n29 = 29,
        [EnumMember(Value = "40")]
        n40 = 40,
        [EnumMember(Value = "44")]
        n44 = 44,
        [EnumMember(Value = "99")]
        n99 = 99
    }
}