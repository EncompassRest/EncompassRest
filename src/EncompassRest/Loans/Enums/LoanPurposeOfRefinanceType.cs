using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanPurposeOfRefinanceType
    {
        FullDocumentation = 0,
        InterestRateReductionRefinanceLoan = 1,
        StreamlineWithAppraisal = 2,
        StreamlineWithoutAppraisal = 3,
        HOPEForHomeowners = 4,
        PriorFHA = 5
    }
}