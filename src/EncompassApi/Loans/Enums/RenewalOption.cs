using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RenewalOption
    /// </summary>
    public enum RenewalOption
    {
        /// <summary>
        /// Constant balance
        /// </summary>
        [Description("Constant balance")]
        C = 0,
        /// <summary>
        /// Declining balance
        /// </summary>
        [Description("Declining balance")]
        D = 1,
        /// <summary>
        /// No renewal
        /// </summary>
        [Description("No renewal")]
        N = 2,
        /// <summary>
        /// Not applicable
        /// </summary>
        [Description("Not applicable")]
        X = 3
    }
}