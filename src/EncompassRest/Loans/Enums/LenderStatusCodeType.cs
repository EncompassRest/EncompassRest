using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LenderStatusCodeType
    {
        [EnumMember(Value = "1. Approved")]
        n1Approved = 0,
        [EnumMember(Value = "2. Eligible")]
        n2Eligible = 1,
        [EnumMember(Value = "3. Certified")]
        n3Certified = 2
    }
}