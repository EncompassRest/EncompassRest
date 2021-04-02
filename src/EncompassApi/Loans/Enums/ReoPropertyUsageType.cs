using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ReoPropertyUsageType
    /// </summary>
    public enum ReoPropertyUsageType
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
        /// Investment Property
        /// </summary>
        [Description("Investment Property")]
        Investor = 2,
        /// <summary>
        /// FHA Secondary Residence
        /// </summary>
        [Description("FHA Secondary Residence")]
        FHASecondaryResidence = 3
    }
}