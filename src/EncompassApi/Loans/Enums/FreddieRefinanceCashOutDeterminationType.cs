using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FreddieRefinanceCashOutDeterminationType
    /// </summary>
    public enum FreddieRefinanceCashOutDeterminationType
    {
        /// <summary>
        /// Cash Out
        /// </summary>
        [Description("Cash Out")]
        CashOut = 0,
        /// <summary>
        /// No Cash Out
        /// </summary>
        [Description("No Cash Out")]
        NoCashOut = 1
    }
}