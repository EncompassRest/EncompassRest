using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ArmIndexType
    {
        WeeklyAverageConstantMaturingTreasury = 0,
        MonthlyAverageConstantMaturingTreasury = 1,
        WeeklyAverageTreasuryAuctionAverageInvestmentYield = 2,
        WeeklyAverageTreasuryAuctionAverageBondDiscountYield = 3,
        WeeklyAverageSecondaryMarketTreasuryBillInvestmentYield = 4,
        DailyCertificateOfDepositRate = 5,
        WeeklyAverageCertificateOfDepositRate = 6,
        WeeklyAveragePrimeRate = 7,
        TreasuryBillDailyValue = 8,
        EleventhDistrictCostOfFunds = 9,
        NationalMonthlyMedianCostOfFunds = 10,
        WallStreetJournalLIBOR = 11,
        [EnumMember(Value = "FNM_LIBOR")]
        FNMLIBOR = 12
    }
}