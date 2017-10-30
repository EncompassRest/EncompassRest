using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TypeOfHybridARM
    {
        [EnumMember(Value = "3/1")]
        n31 = 31,
        [EnumMember(Value = "5/1")]
        n51 = 51,
        [EnumMember(Value = "7/1")]
        n71 = 71,
        [EnumMember(Value = "10/1")]
        n101 = 101
    }
}