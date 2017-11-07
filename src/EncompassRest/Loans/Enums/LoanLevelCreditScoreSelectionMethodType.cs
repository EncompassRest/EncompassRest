using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanLevelCreditScoreSelectionMethodType
    {
        AverageThenAverage = 0,
        MiddleOrLowerThenAverage = 1,
        MiddleOrLowerThenLowest = 2,
        Other = 3
    }
}