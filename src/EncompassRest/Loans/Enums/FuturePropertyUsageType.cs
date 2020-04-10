using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FuturePropertyUsageType
    /// </summary>
    public enum FuturePropertyUsageType
    {
        /// <summary>
        /// Primary Residence
        /// </summary>
        [Description("Primary Residence")]
        PrimaryResidence = 0,
        /// <summary>
        /// Second Home
        /// </summary>
        [Description("Second Home")]
        SecondHome = 1,
        /// <summary>
        /// Investment
        /// </summary>
        Investment = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3
    }
}