using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PaidBy
/// </summary>
public enum PaidBy
{
    /// <summary>
    /// B
    /// </summary>
    [Description("B")]
    Broker = 0,
    /// <summary>
    /// L
    /// </summary>
    [Description("L")]
    Lender = 1,
    /// <summary>
    /// O
    /// </summary>
    [Description("O")]
    Other = 2,
    /// <summary>
    /// S
    /// </summary>
    [Description("S")]
    Seller = 3
}