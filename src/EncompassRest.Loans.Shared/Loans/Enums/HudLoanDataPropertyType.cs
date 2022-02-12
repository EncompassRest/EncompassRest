using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HudLoanDataPropertyType
/// </summary>
public enum HudLoanDataPropertyType
{
    /// <summary>
    /// 1 unit
    /// </summary>
    [Description("1 unit")]
    [EnumMember(Value = "1 Unit")]
    n1Unit = 0,
    /// <summary>
    /// 2 units
    /// </summary>
    [Description("2 units")]
    [EnumMember(Value = "2 Units")]
    n2Units = 1,
    /// <summary>
    /// 3-4 units
    /// </summary>
    [Description("3-4 units")]
    [EnumMember(Value = "3-4 Units")]
    n34Units = 2,
    /// <summary>
    /// Condominium
    /// </summary>
    Condominium = 3,
    /// <summary>
    /// Co-Operative
    /// </summary>
    [Description("Co-Operative")]
    Cooperative = 4,
    /// <summary>
    /// Manufactured Housing
    /// </summary>
    [Description("Manufactured Housing")]
    ManufacturedHousing = 5
}