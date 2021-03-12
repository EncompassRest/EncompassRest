using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PoolInterestRateRoundingType
    /// </summary>
    public enum PoolInterestRateRoundingType
    {
        /// <summary>
        /// Down
        /// </summary>
        Down = 0,
        /// <summary>
        /// Nearest
        /// </summary>
        Nearest = 1,
        /// <summary>
        /// No Rounding
        /// </summary>
        [Description("No Rounding")]
        NoRounding = 2,
        /// <summary>
        /// Up
        /// </summary>
        Up = 3
    }
}