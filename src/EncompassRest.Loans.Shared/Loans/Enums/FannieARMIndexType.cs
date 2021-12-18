using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannieARMIndexType
    /// </summary>
    public enum FannieARMIndexType
    {
        /// <summary>
        /// 6MonthTreasuryBillAuctionHighMonthlyAverage
        /// </summary>
        [EnumMember(Value = "6MonthTreasuryBillAuctionHighMonthlyAverage")]
        n6MonthTreasuryBillAuctionHighMonthlyAverage = 0,
        /// <summary>
        /// 1YearTreasuryConstantMaturitiesMonthlyAverage
        /// </summary>
        [EnumMember(Value = "1YearTreasuryConstantMaturitiesMonthlyAverage")]
        n1YearTreasuryConstantMaturitiesMonthlyAverage = 1,
        /// <summary>
        /// 3YearTreasuryConstantMaturitiesMonthlyAverage
        /// </summary>
        [EnumMember(Value = "3YearTreasuryConstantMaturitiesMonthlyAverage")]
        n3YearTreasuryConstantMaturitiesMonthlyAverage = 2,
        /// <summary>
        /// 5YearTreasuryConstantMaturitiesMonthlyAverage
        /// </summary>
        [EnumMember(Value = "5YearTreasuryConstantMaturitiesMonthlyAverage")]
        n5YearTreasuryConstantMaturitiesMonthlyAverage = 3,
        /// <summary>
        /// NationalAverageContractMortgageRateForThePurchaseOfPreviouslyOccupiedHomes
        /// </summary>
        NationalAverageContractMortgageRateForThePurchaseOfPreviouslyOccupiedHomes = 4,
        /// <summary>
        /// 6MonthTreasuryBillAuctionHighDiscountRate
        /// </summary>
        [EnumMember(Value = "6MonthTreasuryBillAuctionHighDiscountRate")]
        n6MonthTreasuryBillAuctionHighDiscountRate = 5,
        /// <summary>
        /// 1YearTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "1YearTreasuryConstantMaturitiesWeeklyAverage")]
        n1YearTreasuryConstantMaturitiesWeeklyAverage = 6,
        /// <summary>
        /// 3YearTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "3YearTreasuryConstantMaturitiesWeeklyAverage")]
        n3YearTreasuryConstantMaturitiesWeeklyAverage = 7,
        /// <summary>
        /// 5YearTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "5YearTreasuryConstantMaturitiesWeeklyAverage")]
        n5YearTreasuryConstantMaturitiesWeeklyAverage = 8,
        /// <summary>
        /// 6MonthMoneyMarketComBankWeekly
        /// </summary>
        [EnumMember(Value = "6MonthMoneyMarketComBankWeekly")]
        n6MonthMoneyMarketComBankWeekly = 9,
        /// <summary>
        /// FHLBB11thDistrictCostOfFundsMonthlyAverage
        /// </summary>
        FHLBB11thDistrictCostOfFundsMonthlyAverage = 10,
        /// <summary>
        /// 10YearTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "10YearTreasuryConstantMaturitiesWeeklyAverage")]
        n10YearTreasuryConstantMaturitiesWeeklyAverage = 11,
        /// <summary>
        /// NationalMonthlyMedianCostOfFundsRateMonthlyAverage (Retired 8-25-14)
        /// </summary>
        [Description("NationalMonthlyMedianCostOfFundsRateMonthlyAverage (Retired 8-25-14)")]
        NationalMonthlyMedianCostOfFundsRateMonthlyAverage = 12,
        /// <summary>
        /// 6MonthTreasuryBillAuctionHighInvestmentRate
        /// </summary>
        [EnumMember(Value = "6MonthTreasuryBillAuctionHighInvestmentRate")]
        n6MonthTreasuryBillAuctionHighInvestmentRate = 13,
        /// <summary>
        /// 11thDistrictDailyGuarRate30DayCom5Yr
        /// </summary>
        [EnumMember(Value = "11thDistrictDailyGuarRate30DayCom5Yr")]
        n11thDistrictDailyGuarRate30DayCom5Yr = 14,
        /// <summary>
        /// 5YearFHLBNYAdvanceRateDaily
        /// </summary>
        [EnumMember(Value = "5YearFHLBNYAdvanceRateDaily")]
        n5YearFHLBNYAdvanceRateDaily = 15,
        /// <summary>
        /// 6MonthTreasuryBillSecondaryMarketWeeklyAverage
        /// </summary>
        [EnumMember(Value = "6MonthTreasuryBillSecondaryMarketWeeklyAverage")]
        n6MonthTreasuryBillSecondaryMarketWeeklyAverage = 16,
        /// <summary>
        /// 2YearTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "2YearTreasuryConstantMaturitiesWeeklyAverage")]
        n2YearTreasuryConstantMaturitiesWeeklyAverage = 17,
        /// <summary>
        /// CumulativeAverageforthePrevious4WeeksWeeklyAverage (Retired 2Q-2016)
        /// </summary>
        [Description("CumulativeAverageforthePrevious4WeeksWeeklyAverage (Retired 2Q-2016)")]
        CumulativeAverageforthePrevious4WeeksWeeklyAverage = 18,
        /// <summary>
        /// CumulativeAverageforthePrevious4WeeksWeeklyAverage6MonthAuctionHighInvestmentRate
        /// </summary>
        CumulativeAverageforthePrevious4WeeksWeeklyAverage6MonthAuctionHighInvestmentRate = 19,
        /// <summary>
        /// CumulativeAverageforthePrevious26WeeksWeeklyAverage
        /// </summary>
        CumulativeAverageforthePrevious26WeeksWeeklyAverage = 20,
        /// <summary>
        /// CumulativeAverageforthePrevious4WeeksWeeklyAverage6MonthAuctionHighDiscRate
        /// </summary>
        CumulativeAverageforthePrevious4WeeksWeeklyAverage6MonthAuctionHighDiscRate = 21,
        /// <summary>
        /// 1MonthWallStreetJournalLIBORRateMonthly
        /// </summary>
        [EnumMember(Value = "1MonthWallStreetJournalLIBORRateMonthly")]
        n1MonthWallStreetJournalLIBORRateMonthly = 22,
        /// <summary>
        /// FHFB11thDistrictCOFCumulativeAverageForThePrevious12Months
        /// </summary>
        FHFB11thDistrictCOFCumulativeAverageForThePrevious12Months = 23,
        /// <summary>
        /// WallStreetJournalPrimeRate
        /// </summary>
        WallStreetJournalPrimeRate = 24,
        /// <summary>
        /// 1YearTreasuryBill364DayDiscountRate (Retired 2Q-2016)
        /// </summary>
        [Description("1YearTreasuryBill364DayDiscountRate (Retired 2Q-2016)")]
        [EnumMember(Value = "1YearTreasuryBill364DayDiscountRate")]
        n1YearTreasuryBill364DayDiscountRate = 25,
        /// <summary>
        /// 1YearTreasuryBill364DayDiscountRateMonthly
        /// </summary>
        [EnumMember(Value = "1YearTreasuryBill364DayDiscountRateMonthly")]
        n1YearTreasuryBill364DayDiscountRateMonthly = 26,
        /// <summary>
        /// 1YearTreasuryBill364DayDiscountRateWeeklyAuctionAverage
        /// </summary>
        [EnumMember(Value = "1YearTreasuryBill364DayDiscountRateWeeklyAuctionAverage")]
        n1YearTreasuryBill364DayDiscountRateWeeklyAuctionAverage = 27,
        /// <summary>
        /// 7YearTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "7YearTreasuryConstantMaturitiesWeeklyAverage")]
        n7YearTreasuryConstantMaturitiesWeeklyAverage = 28,
        /// <summary>
        /// 1YearFHLBBostonAdvanceRateDaily
        /// </summary>
        [EnumMember(Value = "1YearFHLBBostonAdvanceRateDaily")]
        n1YearFHLBBostonAdvanceRateDaily = 29,
        /// <summary>
        /// FederalReserve6MonthCDRateDaily
        /// </summary>
        FederalReserve6MonthCDRateDaily = 30,
        /// <summary>
        /// SemiAnnualCOFforCaliforniaSemiannualAverage
        /// </summary>
        SemiAnnualCOFforCaliforniaSemiannualAverage = 31,
        /// <summary>
        /// 6MonthCDsSecondaryMarketWeeklyAverage
        /// </summary>
        [EnumMember(Value = "6MonthCDsSecondaryMarketWeeklyAverage")]
        n6MonthCDsSecondaryMarketWeeklyAverage = 32,
        /// <summary>
        /// CumulativeAverageForThePrevious12MonthOfThe6MonthTBillMonthlyAverage
        /// </summary>
        CumulativeAverageForThePrevious12MonthOfThe6MonthTBillMonthlyAverage = 33,
        /// <summary>
        /// Blend50PercentFRM50PercentWeekly1YearTreasurySecurityWeeklyAverage
        /// </summary>
        Blend50PercentFRM50PercentWeekly1YearTreasurySecurityWeeklyAverage = 34,
        /// <summary>
        /// Blend75PercentFRM25PercentWeekly1YearTreasurySecurityWeeklyAverage
        /// </summary>
        Blend75PercentFRM25PercentWeekly1YearTreasurySecurityWeeklyAverage = 35,
        /// <summary>
        /// 6MonthCDsSecondaryMarketMonthlyAverage
        /// </summary>
        [EnumMember(Value = "6MonthCDsSecondaryMarketMonthlyAverage")]
        n6MonthCDsSecondaryMarketMonthlyAverage = 36,
        /// <summary>
        /// CumulativeAverageForThePrevious12Months1YearTreasurySecurityMonthlyAverage
        /// </summary>
        CumulativeAverageForThePrevious12Months1YearTreasurySecurityMonthlyAverage = 37,
        /// <summary>
        /// 6MonthWallStreetJournalLIBORRateMonthlyAverage
        /// </summary>
        [EnumMember(Value = "6MonthWallStreetJournalLIBORRateMonthlyAverage")]
        n6MonthWallStreetJournalLIBORRateMonthlyAverage = 38,
        /// <summary>
        /// SemiAnnualCOFforthe11thDistrictSemiannualAverage
        /// </summary>
        SemiAnnualCOFforthe11thDistrictSemiannualAverage = 39,
        /// <summary>
        /// NationalAverageCOFRatioforSAIFInsuredInstitutionsQuarterlyAverage (Retired 2Q-2016)
        /// </summary>
        [Description("NationalAverageCOFRatioforSAIFInsuredInstitutionsQuarterlyAverage (Retired 2Q-2016)")]
        NationalAverageCOFRatioforSAIFInsuredInstitutionsQuarterlyAverage = 40,
        /// <summary>
        /// QuarterlyAverageOfTheFederalCOFI
        /// </summary>
        QuarterlyAverageOfTheFederalCOFI = 41,
        /// <summary>
        /// MonthlyAverageOfTheWeeklyAverage1YearTreasurySecurityMonthlyAverage
        /// </summary>
        MonthlyAverageOfTheWeeklyAverage1YearTreasurySecurityMonthlyAverage = 42,
        /// <summary>
        /// NationalAverageEffectiveRateoOfAllMortgageloansMonthlyAverage
        /// </summary>
        NationalAverageEffectiveRateoOfAllMortgageloansMonthlyAverage = 43,
        /// <summary>
        /// WallStreetJournal6MonthLIBOR
        /// </summary>
        WallStreetJournal6MonthLIBOR = 44,
        /// <summary>
        /// FreddieMac30Year60DayRequiredNetYieldsDaily
        /// </summary>
        FreddieMac30Year60DayRequiredNetYieldsDaily = 45,
        /// <summary>
        /// 6MonthWallStreetJournalLIBORRateDaily
        /// </summary>
        [EnumMember(Value = "6MonthWallStreetJournalLIBORRateDaily")]
        n6MonthWallStreetJournalLIBORRateDaily = 46,
        /// <summary>
        /// 1MonthWallStreetJournalLIBORRateDaily
        /// </summary>
        [EnumMember(Value = "1MonthWallStreetJournalLIBORRateDaily")]
        n1MonthWallStreetJournalLIBORRateDaily = 47,
        /// <summary>
        /// 3MonthWallStreetJournalLIBORRateMonthly
        /// </summary>
        [EnumMember(Value = "3MonthWallStreetJournalLIBORRateMonthly")]
        n3MonthWallStreetJournalLIBORRateMonthly = 48,
        /// <summary>
        /// 1MonthCDRateSecondaryMarketWeeklyAverage
        /// </summary>
        [EnumMember(Value = "1MonthCDRateSecondaryMarketWeeklyAverage")]
        n1MonthCDRateSecondaryMarketWeeklyAverage = 49,
        /// <summary>
        /// 6MonthBritishBankersAssociationLIBORRateMonthly
        /// </summary>
        [EnumMember(Value = "6MonthBritishBankersAssociationLIBORRateMonthly")]
        n6MonthBritishBankersAssociationLIBORRateMonthly = 50,
        /// <summary>
        /// 6MonthTBillAuctionHighDiscountRate
        /// </summary>
        [EnumMember(Value = "6MonthTBillAuctionHighDiscountRate")]
        n6MonthTBillAuctionHighDiscountRate = 51,
        /// <summary>
        /// 3MonthBritishBankersAssociationLIBORRateMonthly
        /// </summary>
        [EnumMember(Value = "3MonthBritishBankersAssociationLIBORRateMonthly")]
        n3MonthBritishBankersAssociationLIBORRateMonthly = 52,
        /// <summary>
        /// 1MonthBritishBankersAssociationLIBORRateMonthly
        /// </summary>
        [EnumMember(Value = "1MonthBritishBankersAssociationLIBORRateMonthly")]
        n1MonthBritishBankersAssociationLIBORRateMonthly = 53,
        /// <summary>
        /// 1YearTreasuryConstantMaturitiesMonthlyAverageCumulativeAveragefortheprevious12MonthsMonthlyAverage
        /// </summary>
        [EnumMember(Value = "1YearTreasuryConstantMaturitiesMonthlyAverageCumulativeAveragefortheprevious12MonthsMonthlyAverage")]
        n1YearTreasuryConstantMaturitiesMonthlyAverageCumulativeAveragefortheprevious12MonthsMonthlyAverage = 54,
        /// <summary>
        /// 30year60DayConventionalFixedRateDaily
        /// </summary>
        [EnumMember(Value = "30year60DayConventionalFixedRateDaily")]
        n30year60DayConventionalFixedRateDaily = 55,
        /// <summary>
        /// 1YearWallStreetJournalLIBORRateDaily
        /// </summary>
        [EnumMember(Value = "1YearWallStreetJournalLIBORRateDaily")]
        n1YearWallStreetJournalLIBORRateDaily = 56,
        /// <summary>
        /// FreddieMacCostofFunds
        /// </summary>
        FreddieMacCostofFunds = 57,
        /// <summary>
        /// 12MonthRollingAverageOfThe3MonthCD
        /// </summary>
        [EnumMember(Value = "12MonthRollingAverageOfThe3MonthCD")]
        n12MonthRollingAverageOfThe3MonthCD = 58,
        /// <summary>
        /// 6MonthTreasuryConstantMaturitiesWeeklyAverage
        /// </summary>
        [EnumMember(Value = "6MonthTreasuryConstantMaturitiesWeeklyAverage")]
        n6MonthTreasuryConstantMaturitiesWeeklyAverage = 59,
        /// <summary>
        /// 30DayFRMConvPostedYieldAA
        /// </summary>
        [EnumMember(Value = "30DayFRMConvPostedYieldAA")]
        n30DayFRMConvPostedYieldAA = 60,
        /// <summary>
        /// 30DayFRMConvPostedYieldSA
        /// </summary>
        [EnumMember(Value = "30DayFRMConvPostedYieldSA")]
        n30DayFRMConvPostedYieldSA = 61,
        /// <summary>
        /// 60DayFRMConvPostedYieldAA
        /// </summary>
        [EnumMember(Value = "60DayFRMConvPostedYieldAA")]
        n60DayFRMConvPostedYieldAA = 62,
        /// <summary>
        /// 60DayFRMConvPostedYieldSA
        /// </summary>
        [EnumMember(Value = "60DayFRMConvPostedYieldSA")]
        n60DayFRMConvPostedYieldSA = 63,
        /// <summary>
        /// 6MonthTreasuryConstantMaturitySecDaily
        /// </summary>
        [EnumMember(Value = "6MonthTreasuryConstantMaturitySecDaily")]
        n6MonthTreasuryConstantMaturitySecDaily = 64,
        /// <summary>
        /// 3MonthWallStreetJournalLIBORrateDaily
        /// </summary>
        [EnumMember(Value = "3MonthWallStreetJournalLIBORrateDaily")]
        n3MonthWallStreetJournalLIBORrateDaily = 65,
        /// <summary>
        /// WellsFargoPrimeRateOnBloomberg
        /// </summary>
        WellsFargoPrimeRateOnBloomberg = 66,
        /// <summary>
        /// 1MonthBritishBankersAssociationLIBOROnBloomberg
        /// </summary>
        [EnumMember(Value = "1MonthBritishBankersAssociationLIBOROnBloomberg")]
        n1MonthBritishBankersAssociationLIBOROnBloomberg = 67,
        /// <summary>
        /// 3MonthBritishBankersAssociationLIBOROnBloomberg
        /// </summary>
        [EnumMember(Value = "3MonthBritishBankersAssociationLIBOROnBloomberg")]
        n3MonthBritishBankersAssociationLIBOROnBloomberg = 68,
        /// <summary>
        /// 1YearWallStreetJournalLIBORRateMonthly
        /// </summary>
        [EnumMember(Value = "1YearWallStreetJournalLIBORRateMonthly")]
        n1YearWallStreetJournalLIBORRateMonthly = 69,
        /// <summary>
        /// 10YearTreasuryConstantMaturityMonthly
        /// </summary>
        [EnumMember(Value = "10YearTreasuryConstantMaturityMonthly")]
        n10YearTreasuryConstantMaturityMonthly = 70,
        /// <summary>
        /// 1YearCMTMonthlyLast4WeeksofWeekly
        /// </summary>
        [EnumMember(Value = "1YearCMTMonthlyLast4WeeksofWeekly")]
        n1YearCMTMonthlyLast4WeeksofWeekly = 71,
        /// <summary>
        /// 5YearCMTMonthlyLast4WeeksofWeekly
        /// </summary>
        [EnumMember(Value = "5YearCMTMonthlyLast4WeeksofWeekly")]
        n5YearCMTMonthlyLast4WeeksofWeekly = 72,
        /// <summary>
        /// 1MonthTreasuryConstantMaturityWeekly
        /// </summary>
        [EnumMember(Value = "1MonthTreasuryConstantMaturityWeekly")]
        n1MonthTreasuryConstantMaturityWeekly = 73,
        /// <summary>
        /// 6MonthBritishBankersLIBORDaily
        /// </summary>
        [EnumMember(Value = "6MonthBritishBankersLIBORDaily")]
        n6MonthBritishBankersLIBORDaily = 74,
        /// <summary>
        /// WellsFargoCostofSavingsMonthly
        /// </summary>
        WellsFargoCostofSavingsMonthly = 75,
        /// <summary>
        /// 30-Day Average SOFR
        /// </summary>
        [Description("30-Day Average SOFR")]
        [EnumMember(Value = "SOFR_30DayAvg")]
        SOFR30DayAvg = 76
    }
}