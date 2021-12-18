using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PurchaseCreditSource
    /// </summary>
    public enum PurchaseCreditSource
    {
        /// <summary>
        /// Borrower Paid Outside Closing
        /// </summary>
        [Description("Borrower Paid Outside Closing")]
        BorrowerPaidOutsideClosing = 0,
        /// <summary>
        /// Builder Developer
        /// </summary>
        [Description("Builder Developer")]
        BuilderDeveloper = 1,
        /// <summary>
        /// Employer
        /// </summary>
        Employer = 2,
        /// <summary>
        /// Federal Agency
        /// </summary>
        [Description("Federal Agency")]
        FederalAgency = 3,
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
        /// Non-Parent Relative
        /// </summary>
        [Description("Non-Parent Relative")]
        NonParentRelative = 6,
        /// <summary>
        /// Parent
        /// </summary>
        Parent = 7,
        /// <summary>
        /// Property Seller - Retired
        /// </summary>
        [Description("Property Seller - Retired")]
        PropertySeller = 8,
        /// <summary>
        /// Real Estate Agent
        /// </summary>
        [Description("Real Estate Agent")]
        RealEstateAgent = 9,
        /// <summary>
        /// State Agency
        /// </summary>
        [Description("State Agency")]
        StateAgency = 10,
        /// <summary>
        /// Unrelated Friend
        /// </summary>
        [Description("Unrelated Friend")]
        UnrelatedFriend = 11,
        /// <summary>
        /// Employer Affiliate
        /// </summary>
        [Description("Employer Affiliate")]
        EmployerAffiliate = 12,
        /// <summary>
        /// Lender Affiliate
        /// </summary>
        [Description("Lender Affiliate")]
        LenderAffiliate = 13,
        /// <summary>
        /// Other Interested Party
        /// </summary>
        [Description("Other Interested Party")]
        OtherInterestedParty = 14
    }
}