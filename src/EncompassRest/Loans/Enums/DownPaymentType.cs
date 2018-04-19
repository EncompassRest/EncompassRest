using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// DownPaymentType
    /// </summary>
    public enum DownPaymentType
    {
        /// <summary>
        /// Bridge Loan
        /// </summary>
        [Description("Bridge Loan")]
        BridgeLoan = 0,
        /// <summary>
        /// Cash On Hand
        /// </summary>
        [Description("Cash On Hand")]
        CashOnHand = 1,
        /// <summary>
        /// Checking/Savings
        /// </summary>
        [Description("Checking/Savings")]
        CheckingSavings = 2,
        /// <summary>
        /// Deposit On Sales Contract
        /// </summary>
        [Description("Deposit On Sales Contract")]
        DepositOnSalesContract = 3,
        /// <summary>
        /// Equity On Pending Sale
        /// </summary>
        [Description("Equity On Pending Sale")]
        EquityOnPendingSale = 4,
        /// <summary>
        /// Equity On Sold Property
        /// </summary>
        [Description("Equity On Sold Property")]
        EquityOnSoldProperty = 5,
        /// <summary>
        /// Equity On Subject Property
        /// </summary>
        [Description("Equity On Subject Property")]
        EquityOnSubjectProperty = 6,
        /// <summary>
        /// Gift Funds
        /// </summary>
        [Description("Gift Funds")]
        GiftFunds = 7,
        /// <summary>
        /// Life Insurance Cash Value
        /// </summary>
        [Description("Life Insurance Cash Value")]
        LifeInsuranceCashValue = 8,
        /// <summary>
        /// Lot Equity
        /// </summary>
        [Description("Lot Equity")]
        LotEquity = 9,
        /// <summary>
        /// Other Type Of Down Payment
        /// </summary>
        [Description("Other Type Of Down Payment")]
        OtherTypeOfDownPayment = 10,
        /// <summary>
        /// Rent With Option To Purchase
        /// </summary>
        [Description("Rent With Option To Purchase")]
        RentWithOptionToPurchase = 11,
        /// <summary>
        /// Retirement Funds
        /// </summary>
        [Description("Retirement Funds")]
        RetirementFunds = 12,
        /// <summary>
        /// Sale Of Chattel
        /// </summary>
        [Description("Sale Of Chattel")]
        SaleOfChattel = 13,
        /// <summary>
        /// Secured Borrowed Funds
        /// </summary>
        [Description("Secured Borrowed Funds")]
        SecuredBorrowedFunds = 14,
        /// <summary>
        /// Stocks And Bonds
        /// </summary>
        [Description("Stocks And Bonds")]
        StocksAndBonds = 15,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [Description("Sweat Equity")]
        SweatEquity = 16,
        /// <summary>
        /// Trade Equity
        /// </summary>
        [Description("Trade Equity")]
        TradeEquity = 17,
        /// <summary>
        /// Trust Funds
        /// </summary>
        [Description("Trust Funds")]
        TrustFunds = 18,
        /// <summary>
        /// Unsecured Borrowed Funds
        /// </summary>
        [Description("Unsecured Borrowed Funds")]
        UnsecuredBorrowedFunds = 19,
        /// <summary>
        /// FHA - Gift - Source N/A
        /// </summary>
        [Description("FHA - Gift - Source N/A")]
        FHAGiftSourceNA = 20,
        /// <summary>
        /// FHA - Gift - Source Relative
        /// </summary>
        [Description("FHA - Gift - Source Relative")]
        FHAGiftSourceRelative = 21,
        /// <summary>
        /// FHA - Gift - Source Government Assistance
        /// </summary>
        [Description("FHA - Gift - Source Government Assistance")]
        FHAGiftSourceGovernmentAssistance = 22,
        /// <summary>
        /// FHA - Gift - Source Nonprofit/Religious/Community - Seller Funded
        /// </summary>
        [Description("FHA - Gift - Source Nonprofit/Religious/Community - Seller Funded")]
        FHAGiftSourceNonprofitSellerFunded = 23,
        /// <summary>
        /// FHA - Gift - Source Nonprofit/Religious/Community - Non-Seller Funded
        /// </summary>
        [Description("FHA - Gift - Source Nonprofit/Religious/Community - Non-Seller Funded")]
        FHAGiftSourceNonprofitNonSellerFunded = 24,
        /// <summary>
        /// FHA - Gift - Source Employer
        /// </summary>
        [Description("FHA - Gift - Source Employer")]
        FHAGiftSourceEmployer = 25
    }
}