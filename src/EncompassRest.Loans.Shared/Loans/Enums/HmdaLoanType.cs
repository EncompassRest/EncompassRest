using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HmdaLoanType
/// </summary>
public enum HmdaLoanType
{
    /// <summary>
    /// 1. Conventional
    /// </summary>
    [Description("1. Conventional")]
    Conventional = 0,
    /// <summary>
    /// 2. FHA
    /// </summary>
    [Description("2. FHA")]
    FHA = 1,
    /// <summary>
    /// 3. VA
    /// </summary>
    [Description("3. VA")]
    VA = 2,
    /// <summary>
    /// 4. USDA-RHS or FSA
    /// </summary>
    [Description("4. USDA-RHS or FSA")]
    [EnumMember(Value = "USDA-RHS or FSA")]
    USDARHSOrFSA = 3
}