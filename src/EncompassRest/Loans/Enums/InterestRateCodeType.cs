using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InterestRateCodeType
    {
        [EnumMember(Value = "1 - Single Variable")]
        n1SingleVariable = 1,
        [EnumMember(Value = "2 - Single Fixed")]
        n2SingleFixed = 2,
        [EnumMember(Value = "3 - Multi Variable")]
        n3MultiVariable = 3,
        [EnumMember(Value = "4 - Multi Fixed")]
        n4MultiFixed = 4
    }
}