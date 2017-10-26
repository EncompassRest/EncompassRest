using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DownPaymentFundsType
    {
        [EnumMember(Value = "Brdige Loan")]
        BrdigeLoan = 0,
        [EnumMember(Value = "Cash or Other Equity")]
        CashOrOtherEquity = 1,
        [EnumMember(Value = "Cash On Hand")]
        CashOnHand = 2,
        [EnumMember(Value = "Checking Savings")]
        CheckingSavings = 3,
        Contribution = 4,
        [EnumMember(Value = "Credit Card")]
        CreditCard = 5,
        [EnumMember(Value = "Deposit On Sales Contract")]
        DepositOnSalesContract = 6,
        [EnumMember(Value = "Equity On Pending Sale")]
        EquityOnPendingSale = 7,
        [EnumMember(Value = "Equity On Sold Property")]
        EquityOnSoldProperty = 8,
        [EnumMember(Value = "Equity On Subject Property")]
        EquityOnSubjectProperty = 9,
        [EnumMember(Value = "Forgivable Secured Loan")]
        ForgivableSecuredLoan = 10,
        [EnumMember(Value = "Gift Funds")]
        GiftFunds = 11,
        [EnumMember(Value = "Housing Relocation")]
        HousingRelocation = 12,
        [EnumMember(Value = "Life Insurance Cash Value")]
        LifeInsuranceCashValue = 13,
        [EnumMember(Value = "Lot Equity")]
        LotEquity = 14,
        Other = 15,
        [EnumMember(Value = "Pledged Collateral")]
        PledgedCollateral = 16,
        [EnumMember(Value = "Premium Funds")]
        PremiumFunds = 17,
        [EnumMember(Value = "Rent With Option To Purchase")]
        RentWithOptionToPurchase = 18,
        [EnumMember(Value = "Retirement Funds")]
        RetirementFunds = 19,
        [EnumMember(Value = "Sale of Chattel")]
        SaleOfChattel = 20,
        [EnumMember(Value = "Sales Price Adjustment")]
        SalesPriceAdjustment = 21,
        [EnumMember(Value = "Secondary Financing")]
        SecondaryFinancing = 22,
        [EnumMember(Value = "Secured Borrowed Funds")]
        SecuredBorrowedFunds = 23,
        [EnumMember(Value = "Stocks And Bonds")]
        StocksAndBonds = 24,
        [EnumMember(Value = "Sweat Equity")]
        SweatEquity = 25,
        [EnumMember(Value = "Trade Equity")]
        TradeEquity = 26,
        [EnumMember(Value = "Trust Funds")]
        TrustFunds = 27,
        [EnumMember(Value = "Unsedured Borrowed Funds")]
        UnseduredBorrowedFunds = 28
    }
}