using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SourceOfFunds
    /// </summary>
    public enum SourceOfFunds
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
        /// Federal Agency (FNMA/FRE)
        /// </summary>
        [Description("Federal Agency (FNMA/FRE)")]
        FederalAgency = 2,
        /// <summary>
        /// Institutional (FNMA Retired)
        /// </summary>
        [Description("Institutional (FNMA Retired)")]
        Institutional = 3,
        /// <summary>
        /// Lender (FNMA/FRE)
        /// </summary>
        [Description("Lender (FNMA/FRE)")]
        Lender = 4,
        /// <summary>
        /// Local Agency (FNMA/FRE)
        /// </summary>
        [Description("Local Agency (FNMA/FRE)")]
        LocalAgency = 5,
        /// <summary>
        /// Other (FNMA/FRE)
        /// </summary>
        [Description("Other (FNMA/FRE)")]
        Other = 6,
        /// <summary>
        /// Non Parent Relative (FNMA Retired)
        /// </summary>
        [Description("Non Parent Relative (FNMA Retired)")]
        NonParentRelative = 7,
        /// <summary>
        /// Parent (FNMA/FRE)
        /// </summary>
        [Description("Parent (FNMA/FRE)")]
        Parent = 8,
        /// <summary>
        /// Relative (FNMA/FRE)
        /// </summary>
        [Description("Relative (FNMA/FRE)")]
        Relative = 9,
        /// <summary>
        /// Religious Nonprofit (FNMA/FRE)
        /// </summary>
        [Description("Religious Nonprofit (FNMA/FRE)")]
        ReligiousNonprofit = 10,
        /// <summary>
        /// State Agency (FNMA/FRE)
        /// </summary>
        [Description("State Agency (FNMA/FRE)")]
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
        /// Property Seller (FNMA/FRE)
        /// </summary>
        [Description("Property Seller (FNMA/FRE)")]
        PropertySeller = 15
    }
}