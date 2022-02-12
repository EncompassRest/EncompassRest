using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// VaLoanDataPurposeOfLoan
/// </summary>
public enum VaLoanDataPurposeOfLoan
{
    /// <summary>
    /// Home
    /// </summary>
    Home = 0,
    /// <summary>
    /// Manufactured Home
    /// </summary>
    [Description("Manufactured Home")]
    ManufacturedHome = 1,
    /// <summary>
    /// Condominium
    /// </summary>
    Condominium = 2,
    /// <summary>
    /// Alterations / Improvements
    /// </summary>
    [Description("Alterations / Improvements")]
    [EnumMember(Value = "Alterations/Improvements")]
    AlterationsImprovements = 3,
    /// <summary>
    /// Refinance
    /// </summary>
    Refinance = 4
}