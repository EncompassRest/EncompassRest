using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ValuationAwareness
/// </summary>
public enum ValuationAwareness
{
    /// <summary>
    /// I was aware of this valuation when I signed my contract
    /// </summary>
    [Description("I was aware of this valuation when I signed my contract")]
    AwareOfThisValuation = 0,
    /// <summary>
    /// I was not aware of this valuation when I signed my contract
    /// </summary>
    [Description("I was not aware of this valuation when I signed my contract")]
    NotAwareOfThisValuation = 1
}