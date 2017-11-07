using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InvestorRemittanceType
    {
        ActualInterestActualPrincipal = 0,
        ScheduledInterestActualPrincipal = 1,
        ScheduledInterestScheduledPrincipal = 2
    }
}