using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// SourceTypeDescription
    /// </summary>
    public enum SourceTypeDescription
    {
        /// <summary>
        /// Aggregated Remaining Source Types
        /// </summary>
        [Description("Aggregated Remaining Source Types")]
        AggregatedRemainingSourceTypes = 0,
        /// <summary>
        /// FHLB Affordable Housing Program
        /// </summary>
        [Description("FHLB Affordable Housing Program")]
        FHLBAffordableHousingProgram = 1,
        /// <summary>
        /// USDA Rural Housing
        /// </summary>
        [Description("USDA Rural Housing")]
        USDARuralHousing = 2
    }
}