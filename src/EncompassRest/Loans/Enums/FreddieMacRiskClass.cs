using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieMacRiskClass
    {
        [EnumMember(Value = "0")]
        n0 = 0,
        [EnumMember(Value = "1")]
        n1 = 1,
        [EnumMember(Value = "2")]
        n2 = 2,
        [EnumMember(Value = "3")]
        n3 = 3
    }
}