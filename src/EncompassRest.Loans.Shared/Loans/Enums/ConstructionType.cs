using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ConstructionType
/// </summary>
public enum ConstructionType
{
    /// <summary>
    /// Existing Construction
    /// </summary>
    [Description("Existing Construction")]
    ExistingConstruction = 0,
    /// <summary>
    /// Proposed Construction
    /// </summary>
    [Description("Proposed Construction")]
    ProposedConstruction = 1,
    /// <summary>
    /// New (less than 1 year)
    /// </summary>
    [Description("New (less than 1 year)")]
    NewConstruction = 2
}