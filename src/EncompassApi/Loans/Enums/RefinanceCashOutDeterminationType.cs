using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RefinanceCashOutDeterminationType
    /// </summary>
    public enum RefinanceCashOutDeterminationType
    {
        /// <summary>
        /// Cash Out
        /// </summary>
        [Description("Cash Out")]
        CashOut = 0,
        /// <summary>
        /// Limited Cash Out
        /// </summary>
        [Description("Limited Cash Out")]
        LimitedCashOut = 1,
        /// <summary>
        /// No Cash Out
        /// </summary>
        [Description("No Cash Out")]
        NoCashOut = 2
    }
}