using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// OtherDescription
    /// </summary>
    public enum OtherDescription
    {
        /// <summary>
        /// Other Liquid Asset
        /// </summary>
        [Description("Other Liquid Asset")]
        OtherLiquidAsset = 0,
        /// <summary>
        /// Other Non-LiquidAsset
        /// </summary>
        [Description("Other Non-LiquidAsset")]
        OtherNonLiquidAsset = 1
    }
}