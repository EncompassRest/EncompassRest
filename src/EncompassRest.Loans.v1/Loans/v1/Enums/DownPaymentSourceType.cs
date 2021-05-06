using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// DownPaymentSourceType
    /// </summary>
    public enum DownPaymentSourceType
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
        /// ReligiousNonProfit
        /// </summary>
        ReligiousNonProfit = 7,
        /// <summary>
        /// State Agency
        /// </summary>
        [Description("State Agency")]
        StateAgency = 8,
        /// <summary>
        /// Originating Lender
        /// </summary>
        [Description("Originating Lender")]
        OriginatingLender = 9
    }
}