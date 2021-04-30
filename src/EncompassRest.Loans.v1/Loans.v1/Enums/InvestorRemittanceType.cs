using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// InvestorRemittanceType
    /// </summary>
    public enum InvestorRemittanceType
    {
        /// <summary>
        /// Actual Interest Actual Principal
        /// </summary>
        [Description("Actual Interest Actual Principal")]
        ActualInterestActualPrincipal = 0,
        /// <summary>
        /// Scheduled Interest Actual Principal
        /// </summary>
        [Description("Scheduled Interest Actual Principal")]
        ScheduledInterestActualPrincipal = 1,
        /// <summary>
        /// Scheduled Interest Scheduled Principal
        /// </summary>
        [Description("Scheduled Interest Scheduled Principal")]
        ScheduledInterestScheduledPrincipal = 2
    }
}