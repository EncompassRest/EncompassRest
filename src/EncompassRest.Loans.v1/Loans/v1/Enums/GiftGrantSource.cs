using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// GiftGrantSource
    /// </summary>
    public enum GiftGrantSource
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
        /// Borrower
        /// </summary>
        Borrower = 2,
        /// <summary>
        /// Federal Agency
        /// </summary>
        [Description("Federal Agency")]
        FederalAgency = 3,
        /// <summary>
        /// Local Agency
        /// </summary>
        [Description("Local Agency")]
        LocalAgency = 4,
        /// <summary>
        /// Other
        /// </summary>
        Other = 5,
        /// <summary>
        /// Relative
        /// </summary>
        Relative = 6,
        /// <summary>
        /// Religious Nonprofit
        /// </summary>
        [Description("Religious Nonprofit")]
        ReligiousNonprofit = 7,
        /// <summary>
        /// State Agency
        /// </summary>
        [Description("State Agency")]
        StateAgency = 8,
        /// <summary>
        /// Unmarried Partner
        /// </summary>
        [Description("Unmarried Partner")]
        UnmarriedPartner = 9,
        /// <summary>
        /// Institutional - Retired
        /// </summary>
        [Description("Institutional - Retired")]
        Institutional = 10,
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 11,
        /// <summary>
        /// Non Parent Relative - Retired
        /// </summary>
        [Description("Non Parent Relative - Retired")]
        NonParentRelative = 12,
        /// <summary>
        /// Parent
        /// </summary>
        Parent = 13,
        /// <summary>
        /// Unrelated Friend
        /// </summary>
        [Description("Unrelated Friend")]
        UnrelatedFriend = 14,
        /// <summary>
        /// Property Seller
        /// </summary>
        [Description("Property Seller")]
        PropertySeller = 15
    }
}