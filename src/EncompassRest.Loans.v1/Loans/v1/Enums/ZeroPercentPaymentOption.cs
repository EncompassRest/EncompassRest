using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ZeroPercentPaymentOption
    /// </summary>
    public enum ZeroPercentPaymentOption
    {
        /// <summary>
        /// Amortizing Payment
        /// </summary>
        [Description("Amortizing Payment")]
        AmortizingPayment = 0,
        /// <summary>
        /// No Payment with Balloon
        /// </summary>
        [Description("No Payment with Balloon")]
        NoPaymentwithBalloon = 1,
        /// <summary>
        /// No Payment - Fully Forgiven
        /// </summary>
        [Description("No Payment - Fully Forgiven")]
        NoPayment = 2
    }
}