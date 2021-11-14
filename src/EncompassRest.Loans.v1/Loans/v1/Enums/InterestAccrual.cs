using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// InterestAccrual
    /// </summary>
    public enum InterestAccrual
    {
        /// <summary>
        /// Actuarial
        /// </summary>
        Actuarial = 0,
        /// <summary>
        /// US Rule
        /// </summary>
        [Description("US Rule")]
        USRule = 1
    }
}