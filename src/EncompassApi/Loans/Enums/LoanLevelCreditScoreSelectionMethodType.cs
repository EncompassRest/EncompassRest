using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// LoanLevelCreditScoreSelectionMethodType
    /// </summary>
    public enum LoanLevelCreditScoreSelectionMethodType
    {
        /// <summary>
        /// Average Then Average
        /// </summary>
        [Description("Average Then Average")]
        AverageThenAverage = 0,
        /// <summary>
        /// Middle Or Lower Then Average
        /// </summary>
        [Description("Middle Or Lower Then Average")]
        MiddleOrLowerThenAverage = 1,
        /// <summary>
        /// Middle Or Lower Then Lowest
        /// </summary>
        [Description("Middle Or Lower Then Lowest")]
        MiddleOrLowerThenLowest = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3
    }
}