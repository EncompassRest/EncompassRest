using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanRepaymentType
    {
        NoNegativeAmortization = 0,
        ScheduledAmortization = 1,
        InterestOnly = 2,
        PossibleNegativeAmortization = 3,
        ScheduledNegativeAmortization = 4
    }
}