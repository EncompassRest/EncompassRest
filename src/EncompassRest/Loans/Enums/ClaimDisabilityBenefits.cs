using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ClaimDisabilityBenefits
    {
        [EnumMember(Value = "Have Not")]
        HaveNot = 0,
        Have = 1
    }
}