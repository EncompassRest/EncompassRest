using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GiftGrantSource
    /// </summary>
    public enum GiftGrantSource
    {
        /// <summary>
        /// Community Nonprofit (FNMA/FRE)
        /// </summary>
        [Description("Community Nonprofit (FNMA/FRE)")]
        CommunityNonprofit = 0,
        /// <summary>
        /// Employer (FNMA/FRE)
        /// </summary>
        [Description("Employer (FNMA/FRE)")]
        Employer = 1,
        /// <summary>
        /// Grant
        /// </summary>
        Grant = 2,
        /// <summary>
        /// Federal Agency (FNMA/FRE)
        /// </summary>
        [Description("Federal Agency (FNMA/FRE)")]
        FederalAgency = 3,
        /// <summary>
        /// Local Agency (FNMA/FRE)
        /// </summary>
        [Description("Local Agency (FNMA/FRE)")]
        LocalAgency = 4,
        /// <summary>
        /// Other (FNMA/FRE)
        /// </summary>
        [Description("Other (FNMA/FRE)")]
        Other = 5,
        /// <summary>
        /// Relative (FNMA/FRE)
        /// </summary>
        [Description("Relative (FNMA/FRE)")]
        Relative = 6,
        /// <summary>
        /// Religious Nonprofit (FNMA/FRE)
        /// </summary>
        [Description("Religious Nonprofit (FNMA/FRE)")]
        ReligiousNonprofit = 7,
        /// <summary>
        /// State Agency (FNMA/FRE)
        /// </summary>
        [Description("State Agency (FNMA/FRE)")]
        StateAgency = 8,
        /// <summary>
        /// Unmarried Partner (FNMA/FRE)
        /// </summary>
        [Description("Unmarried Partner (FNMA/FRE)")]
        UnmarriedPartner = 9,
        /// <summary>
        /// Institutional (FNMA Retired)
        /// </summary>
        [Description("Institutional (FNMA Retired)")]
        Institutional = 10,
        /// <summary>
        /// Lender (FNMA/FRE)
        /// </summary>
        [Description("Lender (FNMA/FRE)")]
        Lender = 11,
        /// <summary>
        /// Non Parent Relative (FNMA Retired)
        /// </summary>
        [Description("Non Parent Relative (FNMA Retired)")]
        NonParentRelative = 12,
        /// <summary>
        /// Parent (FNMA/FRE)
        /// </summary>
        [Description("Parent (FNMA/FRE)")]
        Parent = 13,
        /// <summary>
        /// Unrelated Friend (FNMA/FRE)
        /// </summary>
        [Description("Unrelated Friend (FNMA/FRE)")]
        UnrelatedFriend = 14,
        /// <summary>
        /// Borrower (FRE)
        /// </summary>
        [Description("Borrower (FRE)")]
        Borrower = 15,
        /// <summary>
        /// Property Seller (FNMA/FRE)
        /// </summary>
        [Description("Property Seller (FNMA/FRE)")]
        PropertySeller = 16
    }
}