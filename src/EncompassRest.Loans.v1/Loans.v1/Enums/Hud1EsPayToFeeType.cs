using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// Hud1EsPayToFeeType
    /// </summary>
    public enum Hud1EsPayToFeeType
    {
        /// <summary>
        /// For Tax
        /// </summary>
        [Description("For Tax")]
        ForTax = 0,
        /// <summary>
        /// For Insurance
        /// </summary>
        [Description("For Insurance")]
        ForInsurance = 1
    }
}