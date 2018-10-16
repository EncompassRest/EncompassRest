using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// DownPaymentFundsType
    /// </summary>
    public enum DownPaymentFundsType
    {
        /// <summary>
        /// Brdige Loan
        /// </summary>
        [EnumMember(Value = "Brdige Loan")]
        BrdigeLoan = 0,
        /// <summary>
        /// Cash or Other Equity
        /// </summary>
        [EnumMember(Value = "Cash or Other Equity")]
        CashOrOtherEquity = 1,
        /// <summary>
        /// Cash On Hand
        /// </summary>
        [EnumMember(Value = "Cash On Hand")]
        CashOnHand = 2,
        /// <summary>
        /// Checking Savings
        /// </summary>
        [EnumMember(Value = "Checking Savings")]
        CheckingSavings = 3,
        /// <summary>
        /// Contribution
        /// </summary>
        Contribution = 4,
        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Credit Card")]
        CreditCard = 5,
        /// <summary>
        /// Deposit On Sales Contract
        /// </summary>
        [EnumMember(Value = "Deposit On Sales Contract")]
        DepositOnSalesContract = 6,
        /// <summary>
        /// Equity On Pending Sale
        /// </summary>
        [EnumMember(Value = "Equity On Pending Sale")]
        EquityOnPendingSale = 7,
        /// <summary>
        /// Equity On Sold Property
        /// </summary>
        [EnumMember(Value = "Equity On Sold Property")]
        EquityOnSoldProperty = 8,
        /// <summary>
        /// Equity On Subject Property
        /// </summary>
        [EnumMember(Value = "Equity On Subject Property")]
        EquityOnSubjectProperty = 9,
        /// <summary>
        /// Forgivable Secured Loan
        /// </summary>
        [EnumMember(Value = "Forgivable Secured Loan")]
        ForgivableSecuredLoan = 10,
        /// <summary>
        /// Gift Funds
        /// </summary>
        [EnumMember(Value = "Gift Funds")]
        GiftFunds = 11,
        /// <summary>
        /// Housing Relocation
        /// </summary>
        [EnumMember(Value = "Housing Relocation")]
        HousingRelocation = 12,
        /// <summary>
        /// Life Insurance Cash Value
        /// </summary>
        [EnumMember(Value = "Life Insurance Cash Value")]
        LifeInsuranceCashValue = 13,
        /// <summary>
        /// Lot Equity
        /// </summary>
        [EnumMember(Value = "Lot Equity")]
        LotEquity = 14,
        /// <summary>
        /// Other
        /// </summary>
        Other = 15,
        /// <summary>
        /// Pledged Collateral
        /// </summary>
        [EnumMember(Value = "Pledged Collateral")]
        PledgedCollateral = 16,
        /// <summary>
        /// Premium Funds
        /// </summary>
        [EnumMember(Value = "Premium Funds")]
        PremiumFunds = 17,
        /// <summary>
        /// Rent With Option To Purchase
        /// </summary>
        [EnumMember(Value = "Rent With Option To Purchase")]
        RentWithOptionToPurchase = 18,
        /// <summary>
        /// Retirement Funds
        /// </summary>
        [EnumMember(Value = "Retirement Funds")]
        RetirementFunds = 19,
        /// <summary>
        /// Sale of Chattel
        /// </summary>
        [EnumMember(Value = "Sale of Chattel")]
        SaleOfChattel = 20,
        /// <summary>
        /// Sales Price Adjustment
        /// </summary>
        [EnumMember(Value = "Sales Price Adjustment")]
        SalesPriceAdjustment = 21,
        /// <summary>
        /// Secondary Financing
        /// </summary>
        [EnumMember(Value = "Secondary Financing")]
        SecondaryFinancing = 22,
        /// <summary>
        /// Secured Borrowed Funds
        /// </summary>
        [EnumMember(Value = "Secured Borrowed Funds")]
        SecuredBorrowedFunds = 23,
        /// <summary>
        /// Stocks And Bonds
        /// </summary>
        [EnumMember(Value = "Stocks And Bonds")]
        StocksAndBonds = 24,
        /// <summary>
        /// Sweat Equity
        /// </summary>
        [EnumMember(Value = "Sweat Equity")]
        SweatEquity = 25,
        /// <summary>
        /// Trade Equity
        /// </summary>
        [EnumMember(Value = "Trade Equity")]
        TradeEquity = 26,
        /// <summary>
        /// Trust Funds
        /// </summary>
        [EnumMember(Value = "Trust Funds")]
        TrustFunds = 27,
        /// <summary>
        /// Unsedured Borrowed Funds
        /// </summary>
        [EnumMember(Value = "Unsedured Borrowed Funds")]
        UnseduredBorrowedFunds = 28
    }
}