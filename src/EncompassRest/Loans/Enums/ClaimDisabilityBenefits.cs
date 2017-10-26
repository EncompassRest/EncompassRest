using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ClaimDisabilityBenefits
    {
        Have = 0,
        [EnumMember(Value = "Have Not")]
        HaveNot = 1
    }
}