using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SourceOfFunds
/// </summary>
public enum SourceOfFunds
{
    /// <summary>
    /// Community Nonprofit (FNMA)
    /// </summary>
    [Description("Community Nonprofit (FNMA)")]
    CommunityNonprofit = 0,
    /// <summary>
    /// Employer (FNMA)
    /// </summary>
    [Description("Employer (FNMA)")]
    Employer = 1,
    /// <summary>
    /// Federal Agency (FNMA)
    /// </summary>
    [Description("Federal Agency (FNMA)")]
    FederalAgency = 2,
    /// <summary>
    /// Institutional (FNMA Retired)
    /// </summary>
    [Description("Institutional (FNMA Retired)")]
    Institutional = 3,
    /// <summary>
    /// Lender (FNMA)
    /// </summary>
    [Description("Lender (FNMA)")]
    Lender = 4,
    /// <summary>
    /// Local Agency (FNMA)
    /// </summary>
    [Description("Local Agency (FNMA)")]
    LocalAgency = 5,
    /// <summary>
    /// Other (FNMA)
    /// </summary>
    [Description("Other (FNMA)")]
    Other = 6,
    /// <summary>
    /// Non Parent Relative (FNMA Retired)
    /// </summary>
    [Description("Non Parent Relative (FNMA Retired)")]
    NonParentRelative = 7,
    /// <summary>
    /// Parent (FNMA)
    /// </summary>
    [Description("Parent (FNMA)")]
    Parent = 8,
    /// <summary>
    /// Relative (FNMA)
    /// </summary>
    [Description("Relative (FNMA)")]
    Relative = 9,
    /// <summary>
    /// Religious Nonprofit (FNMA)
    /// </summary>
    [Description("Religious Nonprofit (FNMA)")]
    ReligiousNonprofit = 10,
    /// <summary>
    /// State Agency (FNMA)
    /// </summary>
    [Description("State Agency (FNMA)")]
    StateAgency = 11,
    /// <summary>
    /// Unrelated Friend (FNMA)
    /// </summary>
    [Description("Unrelated Friend (FNMA)")]
    UnrelatedFriend = 12,
    /// <summary>
    /// Unmarried Partner (FNMA)
    /// </summary>
    [Description("Unmarried Partner (FNMA)")]
    UnmarriedPartner = 13,
    /// <summary>
    /// Non Profit Instrumentality Of Government (FRE)
    /// </summary>
    [Description("Non Profit Instrumentality Of Government (FRE)")]
    NonProfitInstrumentalityOfGovernment = 14,
    /// <summary>
    /// Property Seller (FNMA)
    /// </summary>
    [Description("Property Seller (FNMA)")]
    PropertySeller = 15
}