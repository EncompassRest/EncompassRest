using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AssetType
    {
        CheckingAccount = 0,
        SavingsAccount = 1,
        MutualFund = 2,
        OtherLiquidAssets = 3,
        PendingNetSaleProceedsFromRealEstateAssets = 4,
        CertificateOfDepositTimeDeposit = 5,
        MoneyMarketFund = 6,
        TrustAccount = 7,
        RetirementFund = 8,
        GiftsTotal = 9,
        GiftsNotDeposited = 10,
        GiftOfEquity = 11,
        BridgeLoanNotDeposited = 12,
        SecuredBorrowedFundsNotDeposited = 13,
        CashDepositOnSalesContract = 14,
        CashOnHand = 15,
        NetWorthOfBusinessOwned = 16,
        OtherNonLiquidAssets = 17,
        NetEquity = 18
    }
}