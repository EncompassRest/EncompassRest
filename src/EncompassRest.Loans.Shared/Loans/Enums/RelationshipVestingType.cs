using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// RelationshipVestingType
/// </summary>
public enum RelationshipVestingType
{
    /// <summary>
    /// Individual
    /// </summary>
    Individual = 0,
    /// <summary>
    /// Joint Tenants With Right Of Survivorship
    /// </summary>
    [Description("Joint Tenants With Right Of Survivorship")]
    JointTenantsWithRightOfSurvivorship = 1,
    /// <summary>
    /// Life Estate
    /// </summary>
    [Description("Life Estate")]
    LifeEstate = 2,
    /// <summary>
    /// Tenants By The Entirety
    /// </summary>
    [Description("Tenants By The Entirety")]
    TenantsByTheEntirety = 3,
    /// <summary>
    /// Tenants In Common
    /// </summary>
    [Description("Tenants In Common")]
    TenantsInCommon = 4,
    /// <summary>
    /// Other
    /// </summary>
    Other = 5
}