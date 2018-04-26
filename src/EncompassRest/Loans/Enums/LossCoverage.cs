using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LossCoverage
    /// </summary>
    public enum LossCoverage
    {
        /// <summary>
        /// Duff and Phelps
        /// </summary>
        [Description("Duff and Phelps")]
        D = 0,
        /// <summary>
        /// Fitch
        /// </summary>
        [Description("Fitch")]
        F = 1,
        /// <summary>
        /// Moody's
        /// </summary>
        [Description("Moody's")]
        M = 2,
        /// <summary>
        /// None
        /// </summary>
        [Description("None")]
        N = 3,
        /// <summary>
        /// Standard and Poors
        /// </summary>
        [Description("Standard and Poors")]
        S = 4
    }
}