using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PriorPropertyUsageType
    /// </summary>
    public enum PriorPropertyUsageType
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
        SecondaryResidence = 1,
        /// <summary>
        /// Investment Property
        /// </summary>
        [Description("Investment Property")]
        Investment = 2,
        /// <summary>
        /// FHA Secondary Residence
        /// </summary>
        [Description("FHA Secondary Residence")]
        FHASecondaryResidence = 3
    }
}