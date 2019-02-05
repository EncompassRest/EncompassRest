using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OtherAssetType
    /// </summary>
    public enum OtherAssetType
    {
        /// <summary>
        /// Earnest Money Cash Deposit Toward Purchase
        /// </summary>
        [Description("Earnest Money Cash Deposit Toward Purchase")]
        EarnestMoneyCashDepositTowardPurchase = 0,
        /// <summary>
        /// Employer Assistance
        /// </summary>
        [Description("Employer Assistance")]
        EmployerAssistance = 1,
        /// <summary>
        /// Pending Net Sale Proceeds From Real Estate Assets
        /// </summary>
        [Description("Pending Net Sale Proceeds From Real Estate Assets")]
        PendingNetSaleProceedsFromRealEstateAssets = 2,
        /// <summary>
        /// Proceeds From Sale Of Non Real Estate Asset
        /// </summary>
        [Description("Proceeds From Sale Of Non Real Estate Asset")]
        ProceedsFromSaleOfNonRealEstateAsset = 3,
        /// <summary>
        /// Proceeds From Secured Loan
        /// </summary>
        [Description("Proceeds From Secured Loan")]
        ProceedsFromSecuredLoan = 4,
        /// <summary>
        /// Proceeds From Unsecured Loan
        /// </summary>
        [Description("Proceeds From Unsecured Loan")]
        ProceedsFromUnsecuredLoan = 5,
        /// <summary>
        /// Rent Credit
        /// </summary>
        [Description("Rent Credit")]
        LeasePurchaseCredit = 6,
        /// <summary>
        /// Other
        /// </summary>
        Other = 7,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [Description("Sweat Equity")]
        SweatEquity = 8,
        /// <summary>
        /// Trade Equity From Property Swap
        /// </summary>
        [Description("Trade Equity From Property Swap")]
        TradeEquityFromPropertySwap = 9
    }
}