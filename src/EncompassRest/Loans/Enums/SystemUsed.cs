using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SystemUsed
    {
        [EnumMember(Value = "01")]
        n01 = 0,
        [EnumMember(Value = "02")]
        n02 = 1,
        [EnumMember(Value = "03")]
        n03 = 2,
        [EnumMember(Value = "04")]
        n04 = 3,
        [EnumMember(Value = "05")]
        n05 = 4
    }
}