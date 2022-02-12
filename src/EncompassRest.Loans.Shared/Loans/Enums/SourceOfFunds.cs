using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SourceOfFunds
/// </summary>
public enum SourceOfFunds
{
    /// <summary>
    /// Community Nonprofit
    /// </summary>
    [Description("Community Nonprofit")]
    CommunityNonprofit = 0,
    /// <summary>
    /// Employer
    /// </summary>
    Employer = 1,
    /// <summary>
    /// Federal Agency
    /// </summary>
    [Description("Federal Agency")]
    FederalAgency = 2,
    /// <summary>
    /// Institutional - Retired
    /// </summary>
    [Description("Institutional - Retired")]
    Institutional = 3,
    /// <summary>
    /// Lender
    /// </summary>
    Lender = 4,
    /// <summary>
    /// Local Agency
    /// </summary>
    [Description("Local Agency")]
    LocalAgency = 5,
    /// <summary>
    /// Other
    /// </summary>
    Other = 6,
    /// <summary>
    /// Non Parent Relative - Retired
    /// </summary>
    [Description("Non Parent Relative - Retired")]
    NonParentRelative = 7,
    /// <summary>
    /// Parent
    /// </summary>
    Parent = 8,
    /// <summary>
    /// Relative
    /// </summary>
    Relative = 9,
    /// <summary>
    /// Religious Nonprofit
    /// </summary>
    [Description("Religious Nonprofit")]
    ReligiousNonprofit = 10,
    /// <summary>
    /// State Agency
    /// </summary>
    [Description("State Agency")]
    StateAgency = 11,
    /// <summary>
    /// Unrelated Friend
    /// </summary>
    [Description("Unrelated Friend")]
    UnrelatedFriend = 12,
    /// <summary>
    /// Unmarried Partner
    /// </summary>
    [Description("Unmarried Partner")]
    UnmarriedPartner = 13,
    /// <summary>
    /// Non Profit Instrumentality Of Government
    /// </summary>
    [Description("Non Profit Instrumentality Of Government")]
    NonProfitInstrumentalityOfGovernment = 14,
    /// <summary>
    /// Property Seller
    /// </summary>
    [Description("Property Seller")]
    PropertySeller = 15
}