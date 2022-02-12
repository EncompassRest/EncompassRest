using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PropertyValuationOther
/// </summary>
public enum PropertyValuationOther
{
    /// <summary>
    /// Desk Review
    /// </summary>
    [EnumMember(Value = "Desk Review")]
    DeskReview = 0,
    /// <summary>
    /// Field Review
    /// </summary>
    [EnumMember(Value = "Field Review")]
    FieldReview = 1
}