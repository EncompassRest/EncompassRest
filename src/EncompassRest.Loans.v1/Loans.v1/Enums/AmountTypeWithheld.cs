using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// AmountTypeWithheld
    /// </summary>
    public enum AmountTypeWithheld
    {
        /// <summary>
        /// Escrow
        /// </summary>
        Escrow = 0,
        /// <summary>
        /// Earmarked Account
        /// </summary>
        [EnumMember(Value = "Earmarked Account")]
        EarmarkedAccount = 1
    }
}