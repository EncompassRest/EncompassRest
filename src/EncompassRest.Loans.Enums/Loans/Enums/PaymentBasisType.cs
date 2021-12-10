using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PaymentBasisType
    /// </summary>
    public enum PaymentBasisType
    {
        /// <summary>
        /// Fraction of Balance
        /// </summary>
        [EnumMember(Value = "Fraction of Balance")]
        FractionOfBalance = 0,
        /// <summary>
        /// Percentage of Balance
        /// </summary>
        [EnumMember(Value = "Percentage of Balance")]
        PercentageOfBalance = 1
    }
}