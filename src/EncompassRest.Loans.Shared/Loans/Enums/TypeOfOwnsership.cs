using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// TypeOfOwnsership
/// </summary>
public enum TypeOfOwnsership
{
    /// <summary>
    /// Sole Ownership
    /// </summary>
    [Description("Sole Ownership")]
    SoleOwnership = 0,
    /// <summary>
    /// Joint - 2 or more vet
    /// </summary>
    [Description("Joint - 2 or more vet")]
    [EnumMember(Value = "Joint - 2 Or More Veterans")]
    Joint2OrMoreVeterans = 1,
    /// <summary>
    /// Joint - vet / non-vet
    /// </summary>
    [Description("Joint - vet / non-vet")]
    [EnumMember(Value = "Joint - Veteran/Non-Veteran")]
    JointVeteranNonVeteran = 2
}