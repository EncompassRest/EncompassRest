using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// GiftGrantAssetType
/// </summary>
public enum GiftGrantAssetType
{
    /// <summary>
    /// Gift of Cash
    /// </summary>
    [Description("Gift of Cash")]
    GiftOfCash = 0,
    /// <summary>
    /// Gift Of Property Equity
    /// </summary>
    [Description("Gift Of Property Equity")]
    GiftOfPropertyEquity = 1,
    /// <summary>
    /// Grant
    /// </summary>
    Grant = 2
}