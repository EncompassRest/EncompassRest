using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// HelocPaymentBasis
    /// </summary>
    public enum HelocPaymentBasis
    {
        /// <summary>
        /// Rate
        /// </summary>
        Rate = 0,
        /// <summary>
        /// Fraction of Balance
        /// </summary>
        [EnumMember(Value = "Fraction of Balance")]
        FractionOfBalance = 1,
        /// <summary>
        /// Percentage of Balance
        /// </summary>
        [EnumMember(Value = "Percentage of Balance")]
        PercentageOfBalance = 2
    }
}