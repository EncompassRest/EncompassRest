using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RefinancePurpose
    {
        CashOutDebtConsolidation = 0,
        CashOutHomeImprovement = 1,
        CashOutLimited = 2,
        CashOutOther = 3,
        CashOutOriginalLender = 4,
        ChangeInRateTerm = 5,
        NoCashOutOther = 6,
        NoCashOutFHAStreamlinedRefinance = 7,
        NoCashOutFREOwnedRefinance = 8,
        NoCashOutStreamlinedRefinance = 9,
        NoCashOutOriginalLender = 10
    }
}