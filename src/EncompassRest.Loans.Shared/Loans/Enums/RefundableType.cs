using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// RefundableType
/// </summary>
public enum RefundableType
{
    /// <summary>
    /// Non-Refundable
    /// </summary>
    [Description("Non-Refundable")]
    NonRefundable = 0,
    /// <summary>
    /// Refundable
    /// </summary>
    Refundable = 1,
    /// <summary>
    /// N/A (No funds collected at or prior to funding)
    /// </summary>
    [Description("N/A (No funds collected at or prior to funding)")]
    NA = 2
}