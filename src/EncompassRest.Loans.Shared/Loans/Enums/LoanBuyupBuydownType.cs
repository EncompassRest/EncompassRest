using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// LoanBuyupBuydownType
/// </summary>
public enum LoanBuyupBuydownType
{
    /// <summary>
    /// Buydown
    /// </summary>
    Buydown = 0,
    /// <summary>
    /// Buyup
    /// </summary>
    Buyup = 1,
    /// <summary>
    /// Buyup Buydown does not Apply
    /// </summary>
    [Description("Buyup Buydown does not Apply")]
    BuyupBuydownDoesNotApply = 2
}