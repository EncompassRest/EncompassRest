using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InterestCalculationBasisType
    {
        AverageBalance = 0,
        DailyLoanBalance = 1,
        EndOfPeriod = 2
    }
}