using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RiskClassification
    {
        [EnumMember(Value = "1")]
        n1 = 0,
        [EnumMember(Value = "2")]
        n2 = 1
    }
}