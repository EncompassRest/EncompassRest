using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PoolAmortizationType
    /// </summary>
    public enum PoolAmortizationType
    {
        /// <summary>
        /// Adjustable Rate
        /// </summary>
        [Description("Adjustable Rate")]
        AdjustableRate = 0,
        /// <summary>
        /// Fixed
        /// </summary>
        Fixed = 1,
        /// <summary>
        /// Graduated Payment ARM
        /// </summary>
        [Description("Graduated Payment ARM")]
        GraduatedPaymentARM = 2,
        /// <summary>
        /// Graduated Payment Mortgage
        /// </summary>
        [Description("Graduated Payment Mortgage")]
        GraduatedPaymentMortgage = 3,
        /// <summary>
        /// Growing Equity Mortgage
        /// </summary>
        [Description("Growing Equity Mortgage")]
        GrowingEquityMortgage = 4
    }
}