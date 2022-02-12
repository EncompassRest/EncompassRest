using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// LoanProcedure
/// </summary>
public enum LoanProcedure
{
    /// <summary>
    /// Automatic
    /// </summary>
    Automatic = 0,
    /// <summary>
    /// Auto-IRRRL
    /// </summary>
    [EnumMember(Value = "Auto-IRRRL")]
    AutoIRRRL = 1,
    /// <summary>
    /// VA Prior Approval
    /// </summary>
    [Description("VA Prior Approval")]
    VAPriorApproval = 2
}