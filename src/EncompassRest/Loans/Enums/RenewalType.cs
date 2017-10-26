using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RenewalType
    {
        Guaranteed = 0,
        Variable = 1,
        [EnumMember(Value = "Not Applicable")]
        NotApplicable = 2
    }
}