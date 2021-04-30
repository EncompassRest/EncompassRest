using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// InterestCalculationBasisType
    /// </summary>
    public enum InterestCalculationBasisType
    {
        /// <summary>
        /// Average Balance
        /// </summary>
        [Description("Average Balance")]
        AverageBalance = 0,
        /// <summary>
        /// Daily Loan Balance
        /// </summary>
        [Description("Daily Loan Balance")]
        DailyLoanBalance = 1,
        /// <summary>
        /// End of Period
        /// </summary>
        [Description("End of Period")]
        EndOfPeriod = 2
    }
}