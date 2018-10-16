using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ClosingCostSourceType
    /// </summary>
    public enum ClosingCostSourceType
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Community Non-Profit
        /// </summary>
        [Description("Community Non-Profit")]
        CommunityNonProfit = 1,
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
        /// Other
        /// </summary>
        Other = 6,
        /// <summary>
        /// Property Seller
        /// </summary>
        [Description("Property Seller")]
        PropertySeller = 7,
        /// <summary>
        /// Relative
        /// </summary>
        Relative = 8,
        /// <summary>
        /// Religious Non-Profit
        /// </summary>
        [Description("Religious Non-Profit")]
        ReligiousNonProfit = 9,
        /// <summary>
        /// State Agency
        /// </summary>
        [Description("State Agency")]
        StateAgency = 10
    }
}