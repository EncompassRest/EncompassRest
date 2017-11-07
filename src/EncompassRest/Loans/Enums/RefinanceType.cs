using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RefinanceType
    {
        CashOutRefinance = 0,
        RegularRefinance = 1,
        StreamlineWithAppraisal = 2,
        StreamlineWithoutAppraisal = 3
    }
}