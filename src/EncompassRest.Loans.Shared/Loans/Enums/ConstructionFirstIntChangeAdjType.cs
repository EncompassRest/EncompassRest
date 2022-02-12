using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ConstructionFirstIntChangeAdjType
/// </summary>
public enum ConstructionFirstIntChangeAdjType
{
    /// <summary>
    /// Constr First Pmt Date
    /// </summary>
    [Description("Constr First Pmt Date")]
    C = 0,
    /// <summary>
    /// Prmsry Note Pmt Date
    /// </summary>
    [Description("Prmsry Note Pmt Date")]
    N = 1
}