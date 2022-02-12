using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// TypeOfProperty
/// </summary>
public enum TypeOfProperty
{
    /// <summary>
    /// This Agreement covers real property principally improved, or to be improved, by one or more structures containing not more than 6 units.
    /// </summary>
    [Description("This Agreement covers real property principally improved, or to be improved, by one or more structures containing not more than 6 units.")]
    NotMoreThanSixUnits = 0,
    /// <summary>
    /// This Agreement covers real property improved, or to be improved (1-2 units).
    /// </summary>
    [Description("This Agreement covers real property improved, or to be improved (1-2 units).")]
    OneToTwoUnits = 1,
    /// <summary>
    /// This Agreement does not cover real property.
    /// </summary>
    [Description("This Agreement does not cover real property.")]
    NoUnits = 2
}