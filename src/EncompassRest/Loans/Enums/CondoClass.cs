using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CondoClass
    {
        [EnumMember(Value = "1")]
        n1 = 0,
        [EnumMember(Value = "2")]
        n2 = 1,
        [EnumMember(Value = "3")]
        n3 = 2,
        [EnumMember(Value = "4")]
        n4 = 3
    }
}