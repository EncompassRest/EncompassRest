using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FhaVaLoanPurposeOfLoan
    {
        PurchaseManufacturedHomeAndLot = 0,
        RefinanceManufacturedHomeLotLoan = 1,
        PurchaseHomePrevOccupied = 2,
        Refinance = 3,
        PurchaseExistingCondoUnit = 4,
        PurchaseNewCondoUnit = 5,
        RefinanceManufacturedHomeToBuyLot = 6,
        PurchaseHomeNotPrevOccupied = 7,
        PurchaseManufacturedHome = 8,
        FinanceCoOpPurchase = 9,
        ConstructionHome = 10,
        FinanceImprovement = 11
    }
}