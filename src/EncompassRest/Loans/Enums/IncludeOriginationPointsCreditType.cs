using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IncludeOriginationPointsCreditType
    {
        [EnumMember(Value = "Include Origination Points")]
        IncludeOriginationPoints = 0,
        [EnumMember(Value = "Include Origination Credit")]
        IncludeOriginationCredit = 1
    }
}