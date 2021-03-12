using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PropertyUsageType
    /// </summary>
    public enum PropertyUsageType
    {
        /// <summary>
        /// Primary
        /// </summary>
        [Description("Primary")]
        PrimaryResidence = 0,
        /// <summary>
        /// Secondary
        /// </summary>
        [Description("Secondary")]
        SecondHome = 1,
        /// <summary>
        /// Investment
        /// </summary>
        [Description("Investment")]
        Investor = 2
    }
}