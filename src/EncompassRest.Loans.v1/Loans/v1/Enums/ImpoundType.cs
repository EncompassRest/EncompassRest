using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ImpoundType
    /// </summary>
    public enum ImpoundType
    {
        /// <summary>
        /// Taxes and Insurance (T &amp; I)
        /// </summary>
        [Description("Taxes and Insurance (T & I)")]
        [EnumMember(Value = "Taxes and Insurance")]
        TaxesAndInsurance = 0,
        /// <summary>
        /// Taxes only (T)
        /// </summary>
        [Description("Taxes only (T)")]
        [EnumMember(Value = "Taxes only")]
        TaxesOnly = 1,
        /// <summary>
        /// Insurance only (I)
        /// </summary>
        [Description("Insurance only (I)")]
        [EnumMember(Value = "Insurance only")]
        InsuranceOnly = 2,
        /// <summary>
        /// No Impounds
        /// </summary>
        [EnumMember(Value = "No Impounds")]
        NoImpounds = 3
    }
}