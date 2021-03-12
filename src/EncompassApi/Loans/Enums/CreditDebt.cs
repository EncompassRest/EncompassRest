using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// CreditDebt
    /// </summary>
    public enum CreditDebt
    {
        /// <summary>
        /// C
        /// </summary>
        [Description("C")]
        Credit = 0,
        /// <summary>
        /// D
        /// </summary>
        [Description("D")]
        Debt = 1
    }
}