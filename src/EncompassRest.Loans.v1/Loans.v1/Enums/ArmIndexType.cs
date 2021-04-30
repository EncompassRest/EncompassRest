using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ArmIndexType
    /// </summary>
    public enum ArmIndexType
    {
        /// <summary>
        /// Weekly Average Constant Maturing Treasury
        /// </summary>
        [Description("Weekly Average Constant Maturing Treasury")]
        WeeklyAverageConstantMaturingTreasury = 0,
        /// <summary>
        /// Monthly Average Constant Maturing Treasury
        /// </summary>
        [Description("Monthly Average Constant Maturing Treasury")]
        MonthlyAverageConstantMaturingTreasury = 1,
        /// <summary>
        /// Weekly Average Treasury Auction Average Investment Yield
        /// </summary>
        [Description("Weekly Average Treasury Auction Average Investment Yield")]
        WeeklyAverageTreasuryAuctionAverageInvestmentYield = 2,
        /// <summary>
        /// Weekly Average Treasury Auction Average Bond Discount Yield
        /// </summary>
        [Description("Weekly Average Treasury Auction Average Bond Discount Yield")]
        WeeklyAverageTreasuryAuctionAverageBondDiscountYield = 3,
        /// <summary>
        /// Weekly Average Secondary Market Treasury BillInvestment Yield
        /// </summary>
        [Description("Weekly Average Secondary Market Treasury BillInvestment Yield")]
        WeeklyAverageSecondaryMarketTreasuryBillInvestmentYield = 4,
        /// <summary>
        /// Daily Certificate Of Deposit Rate
        /// </summary>
        [Description("Daily Certificate Of Deposit Rate")]
        DailyCertificateOfDepositRate = 5,
        /// <summary>
        /// Weekly Average Certificate Of Deposit Rate
        /// </summary>
        [Description("Weekly Average Certificate Of Deposit Rate")]
        WeeklyAverageCertificateOfDepositRate = 6,
        /// <summary>
        /// Weekly Average Prime Rate
        /// </summary>
        [Description("Weekly Average Prime Rate")]
        WeeklyAveragePrimeRate = 7,
        /// <summary>
        /// Treasury Bill Daily Value
        /// </summary>
        [Description("Treasury Bill Daily Value")]
        TreasuryBillDailyValue = 8,
        /// <summary>
        /// Eleventh District Cost Of Funds
        /// </summary>
        [Description("Eleventh District Cost Of Funds")]
        EleventhDistrictCostOfFunds = 9,
        /// <summary>
        /// National Monthly Median Cost Of Funds
        /// </summary>
        [Description("National Monthly Median Cost Of Funds")]
        NationalMonthlyMedianCostOfFunds = 10,
        /// <summary>
        /// Wall Street Journal LIBOR
        /// </summary>
        [Description("Wall Street Journal LIBOR")]
        WallStreetJournalLIBOR = 11,
        /// <summary>
        /// FNM_LIBOR
        /// </summary>
        [EnumMember(Value = "FNM_LIBOR")]
        FNMLIBOR = 12,
        /// <summary>
        /// 30-Day Average SOFR
        /// </summary>
        [Description("30-Day Average SOFR")]
        [EnumMember(Value = "30DayAverageSOFR")]
        n30DayAverageSOFR = 13
    }
}