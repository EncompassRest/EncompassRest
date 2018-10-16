using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieDownPaymentType
    /// </summary>
    public enum FreddieDownPaymentType
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
        /// Checking Savings
        /// </summary>
        [Description("Checking Savings")]
        CheckingSavings = 2,
        /// <summary>
        /// Equity On Subject Property
        /// </summary>
        [Description("Equity On Subject Property")]
        EquityOnSubjectProperty = 3,
        /// <summary>
        /// Gift Funds
        /// </summary>
        [Description("Gift Funds")]
        GiftFunds = 4,
        /// <summary>
        /// Life Insurance Cash Value
        /// </summary>
        [Description("Life Insurance Cash Value")]
        LifeInsuranceCashValue = 5,
        /// <summary>
        /// Lot Equity
        /// </summary>
        [Description("Lot Equity")]
        LotEquity = 6,
        /// <summary>
        /// Other Type Of Down Payment
        /// </summary>
        [Description("Other Type Of Down Payment")]
        OtherTypeOfDownPayment = 7,
        /// <summary>
        /// Rent With Option To Purchase
        /// </summary>
        [Description("Rent With Option To Purchase")]
        RentWithOptionToPurchase = 8,
        /// <summary>
        /// Retirement Funds
        /// </summary>
        [Description("Retirement Funds")]
        RetirementFunds = 9,
        /// <summary>
        /// Sale Of Chattel
        /// </summary>
        [Description("Sale Of Chattel")]
        SaleOfChattel = 10,
        /// <summary>
        /// Secured Borrowed Funds
        /// </summary>
        [Description("Secured Borrowed Funds")]
        SecuredBorrowedFunds = 11,
        /// <summary>
        /// Stocks And Bonds
        /// </summary>
        [Description("Stocks And Bonds")]
        StocksAndBonds = 12,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [Description("Sweat Equity")]
        SweatEquity = 13,
        /// <summary>
        /// Trade Equity
        /// </summary>
        [Description("Trade Equity")]
        TradeEquity = 14,
        /// <summary>
        /// Trust Funds
        /// </summary>
        [Description("Trust Funds")]
        TrustFunds = 15,
        /// <summary>
        /// Unsecured Borrowed Funds
        /// </summary>
        [Description("Unsecured Borrowed Funds")]
        UnsecuredBorrowedFunds = 16
    }
}