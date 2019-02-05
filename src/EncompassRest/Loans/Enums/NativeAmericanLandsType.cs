using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// NativeAmericanLandsType
    /// </summary>
    public enum NativeAmericanLandsType
    {
        /// <summary>
        /// Fee Simple
        /// </summary>
        [Description("Fee Simple")]
        FeeSimple = 0,
        /// <summary>
        /// Individual Trust Land
        /// </summary>
        [Description("Individual Trust Land")]
        IndividualTrustLand = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}