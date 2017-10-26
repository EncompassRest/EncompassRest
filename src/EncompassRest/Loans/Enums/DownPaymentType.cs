using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DownPaymentType
    {
        BridgeLoan = 0,
        CashOnHand = 1,
        CheckingSavings = 2,
        DepositOnSalesContract = 3,
        EquityOnPendingSale = 4,
        EquityOnSoldProperty = 5,
        EquityOnSubjectProperty = 6,
        GiftFunds = 7,
        LifeInsuranceCashValue = 8,
        LotEquity = 9,
        OtherTypeOfDownPayment = 10,
        RentWithOptionToPurchase = 11,
        RetirementFunds = 12,
        SaleOfChattel = 13,
        SecuredBorrowedFunds = 14,
        StocksAndBonds = 15,
        SweatEquity = 16,
        TradeEquity = 17,
        TrustFunds = 18,
        UnsecuredBorrowedFunds = 19,
        FHAGiftSourceNA = 20,
        FHAGiftSourceRelative = 21,
        FHAGiftSourceGovernmentAssistance = 22,
        FHAGiftSourceNonprofitSellerFunded = 23,
        FHAGiftSourceNonprofitNonSellerFunded = 24,
        FHAGiftSourceEmployer = 25
    }
}