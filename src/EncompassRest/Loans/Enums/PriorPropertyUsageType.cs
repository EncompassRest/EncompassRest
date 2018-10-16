using System.ComponentModel;

namespace EncompassRest.Loans.Enums
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
        /// Secondary Residence
        /// </summary>
        [Description("Secondary Residence")]
        SecondaryResidence = 1,
        /// <summary>
        /// Investment Property
        /// </summary>
        [Description("Investment Property")]
        Investment = 2
    }
}