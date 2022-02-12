using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HudLoanDataResidencyType
/// </summary>
public enum HudLoanDataResidencyType
{
    /// <summary>
    /// Owner-Occupant
    /// </summary>
    [Description("Owner-Occupant")]
    OwnedOccupant = 0,
    /// <summary>
    /// Government Agency
    /// </summary>
    [Description("Government Agency")]
    GovernmentAgency = 1,
    /// <summary>
    /// Nonprofit
    /// </summary>
    Nonprofit = 2
}