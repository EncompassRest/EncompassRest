using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
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