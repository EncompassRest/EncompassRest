using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TypeOfHybridARM
    {
        [EnumMember(Value = "3/1")]
        n31 = 0,
        [EnumMember(Value = "5/1")]
        n51 = 1,
        [EnumMember(Value = "7/1")]
        n71 = 2,
        [EnumMember(Value = "10/1")]
        n101 = 3
    }
}