using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
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