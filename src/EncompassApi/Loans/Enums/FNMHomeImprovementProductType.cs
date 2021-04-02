using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FNMHomeImprovementProductType
    /// </summary>
    public enum FNMHomeImprovementProductType
    {
        /// <summary>
        /// Actual Actual Biweekly
        /// </summary>
        [Description("Actual Actual Biweekly")]
        ActualActualBiweekly = 0,
        /// <summary>
        /// Construction To Permanent
        /// </summary>
        [Description("Construction To Permanent")]
        ConstructionToPermanent = 1,
        /// <summary>
        /// Daily SimpleInterest Cash Conventional
        /// </summary>
        [Description("Daily SimpleInterest Cash Conventional")]
        DailySimpleInterestCashConventional = 2,
        /// <summary>
        /// Daily Simple Interest MBS
        /// </summary>
        [Description("Daily Simple Interest MBS")]
        DailySimpleInterestMBS = 3,
        /// <summary>
        /// Government TitleI
        /// </summary>
        [Description("Government TitleI")]
        GovernmentTitleI = 4
    }
}