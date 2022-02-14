using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PurchaseCreditSource
/// </summary>
public enum PurchaseCreditSource
{
    /// <summary>
    /// Borrower Paid Outside Closing (FNMA/FRE)
    /// </summary>
    [Description("Borrower Paid Outside Closing (FNMA/FRE)")]
    BorrowerPaidOutsideClosing = 0,
    /// <summary>
    /// Builder Developer (FNMA/FRE)
    /// </summary>
    [Description("Builder Developer (FNMA/FRE)")]
    BuilderDeveloper = 1,
    /// <summary>
    /// Employer (FRE)
    /// </summary>
    [Description("Employer (FRE)")]
    Employer = 2,
    /// <summary>
    /// Federal Agency (FRE)
    /// </summary>
    [Description("Federal Agency (FRE)")]
    FederalAgency = 3,
    /// <summary>
    /// Lender (FRE)
    /// </summary>
    [Description("Lender (FRE)")]
    Lender = 4,
    /// <summary>
    /// Local Agency (FRE)
    /// </summary>
    [Description("Local Agency (FRE)")]
    LocalAgency = 5,
    /// <summary>
    /// Non-Parent Relative (FRE)
    /// </summary>
    [Description("Non-Parent Relative (FRE)")]
    NonParentRelative = 6,
    /// <summary>
    /// Parent (FRE)
    /// </summary>
    [Description("Parent (FRE)")]
    Parent = 7,
    /// <summary>
    /// Property Seller (FRE Retired)
    /// </summary>
    [Description("Property Seller (FRE Retired)")]
    PropertySeller = 8,
    /// <summary>
    /// Real Estate Agent (FNMA/FRE)
    /// </summary>
    [Description("Real Estate Agent (FNMA/FRE)")]
    RealEstateAgent = 9,
    /// <summary>
    /// State Agency (FRE)
    /// </summary>
    [Description("State Agency (FRE)")]
    StateAgency = 10,
    /// <summary>
    /// Unrelated Friend (FRE)
    /// </summary>
    [Description("Unrelated Friend (FRE)")]
    UnrelatedFriend = 11,
    /// <summary>
    /// Employer Affiliate (FNMA/FRE)
    /// </summary>
    [Description("Employer Affiliate (FNMA/FRE)")]
    EmployerAffiliate = 12,
    /// <summary>
    /// Lender Affiliate (FNMA/FRE)
    /// </summary>
    [Description("Lender Affiliate (FNMA/FRE)")]
    LenderAffiliate = 13,
    /// <summary>
    /// Other Interested Party (FNMA)
    /// </summary>
    [Description("Other Interested Party (FNMA)")]
    OtherInterestedParty = 14
}