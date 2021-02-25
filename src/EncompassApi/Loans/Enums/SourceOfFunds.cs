using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
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
        /// Institutional
        /// </summary>
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
        /// Non Parent Relative
        /// </summary>
        [Description("Non Parent Relative")]
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
        UnmarriedPartner = 13
    }
}