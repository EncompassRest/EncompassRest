using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieMacArmIndexType
    {
        [EnumMember(Value = "01")]
        n01 = 0,
        [EnumMember(Value = "02")]
        n02 = 1,
        [EnumMember(Value = "03")]
        n03 = 2,
        [EnumMember(Value = "29")]
        n29 = 3,
        [EnumMember(Value = "40")]
        n40 = 4,
        [EnumMember(Value = "44")]
        n44 = 5,
        [EnumMember(Value = "99")]
        n99 = 6
    }
}