using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// AmortizationType
    /// </summary>
    public enum AmortizationType
    {
        /// <summary>
        /// Fixed Rate
        /// </summary>
        [Description("Fixed Rate")]
        Fixed = 0,
        /// <summary>
        /// GPM - Rate
        /// </summary>
        [Description("GPM - Rate")]
        GraduatedPaymentMortgage = 1,
        /// <summary>
        /// ARM
        /// </summary>
        [Description("ARM")]
        AdjustableRate = 2,
        /// <summary>
        /// Other
        /// </summary>
        [Description("Other")]
        OtherAmortizationType = 3
    }
}