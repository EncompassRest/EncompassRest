using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ClosingCostFundsType
    /// </summary>
    public enum ClosingCostFundsType
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
        /// Cash Or Other Equity
        /// </summary>
        [Description("Cash Or Other Equity")]
        CashOrOtherEquity = 2,
        /// <summary>
        /// Checking Savings
        /// </summary>
        [Description("Checking Savings")]
        CheckingSavings = 3,
        /// <summary>
        /// Contribution
        /// </summary>
        Contribution = 4,
        /// <summary>
        /// Credit Card
        /// </summary>
        [Description("Credit Card")]
        CreditCard = 5,
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
        /// Grant
        /// </summary>
        Grant = 8,
        /// <summary>
        /// Life Insurance Cash Value
        /// </summary>
        [Description("Life Insurance Cash Value")]
        LifeInsuranceCashValue = 9,
        /// <summary>
        /// Lot Equity
        /// </summary>
        [Description("Lot Equity")]
        LotEquity = 10,
        /// <summary>
        /// Other
        /// </summary>
        Other = 11,
        /// <summary>
        /// Premium Funds
        /// </summary>
        [Description("Premium Funds")]
        PremiumFunds = 12,
        /// <summary>
        /// Rent With Option To Purchase
        /// </summary>
        [Description("Rent With Option To Purchase")]
        RentWithOptionToPurchase = 13,
        /// <summary>
        /// Retirement Funds
        /// </summary>
        [Description("Retirement Funds")]
        RetirementFunds = 14,
        /// <summary>
        /// Sale Of Chattel
        /// </summary>
        [Description("Sale Of Chattel")]
        SaleOfChattel = 15,
        /// <summary>
        /// Secured Loan
        /// </summary>
        [Description("Secured Loan")]
        SecuredLoan = 16,
        /// <summary>
        /// Stocks And Bonds
        /// </summary>
        [Description("Stocks And Bonds")]
        StocksAndBonds = 17,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [Description("Sweat Equity")]
        SweatEquity = 18,
        /// <summary>
        /// Trade Equity
        /// </summary>
        [Description("Trade Equity")]
        TradeEquity = 19,
        /// <summary>
        /// Trust Funds
        /// </summary>
        [Description("Trust Funds")]
        TrustFunds = 20,
        /// <summary>
        /// Unsecured Borrowed Funds
        /// </summary>
        [Description("Unsecured Borrowed Funds")]
        UnsecuredBorrowedFunds = 21,
        /// <summary>
        /// Equity On Sold Property
        /// </summary>
        [Description("Equity On Sold Property")]
        EquityOnSoldProperty = 22
    }
}