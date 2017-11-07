using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SystemUsed
    {
        [EnumMember(Value = "01")]
        n01 = 1,
        [EnumMember(Value = "02")]
        n02 = 2,
        [EnumMember(Value = "03")]
        n03 = 3,
        [EnumMember(Value = "04")]
        n04 = 4,
        [EnumMember(Value = "05")]
        n05 = 5
    }
}