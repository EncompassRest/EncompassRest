using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ServicingFeePaidFrequence
    /// </summary>
    public enum ServicingFeePaidFrequence
    {
        /// <summary>
        /// Monthly
        /// </summary>
        Monthly = 0,
        /// <summary>
        /// Quarterly
        /// </summary>
        Quarterly = 1,
        /// <summary>
        /// Yearly
        /// </summary>
        Yearly = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3
    }
}