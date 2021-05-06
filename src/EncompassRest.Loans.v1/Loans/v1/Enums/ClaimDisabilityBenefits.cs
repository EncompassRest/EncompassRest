using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ClaimDisabilityBenefits
    /// </summary>
    public enum ClaimDisabilityBenefits
    {
        /// <summary>
        /// Have Not
        /// </summary>
        [EnumMember(Value = "Have Not")]
        HaveNot = 0,
        /// <summary>
        /// Have
        /// </summary>
        Have = 1
    }
}