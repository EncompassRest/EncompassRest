using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CDLiabilityAfterForeclosure
    /// </summary>
    public enum CDLiabilityAfterForeclosure
    {
        /// <summary>
        /// state law may protect you from liability for the unpaid balance
        /// </summary>
        [Description("state law may protect you from liability for the unpaid balance")]
        [EnumMember(Value = "state law may protect liability for the unpaid balance")]
        StateLawMayProtectLiabilityForTheUnpaidBalance = 0,
        /// <summary>
        /// state law does not protect you from liability for the unpaid balance
        /// </summary>
        [Description("state law does not protect you from liability for the unpaid balance")]
        [EnumMember(Value = "state law does not protect liability for the unpaid balance")]
        StateLawDoesNotProtectLiabilityForTheUnpaidBalance = 1
    }
}