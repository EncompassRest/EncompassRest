using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InterestRateImpactedStatus
    {
        [EnumMember(Value = "Decreases Interest Rate")]
        DecreasesInterestRate = 0,
        [EnumMember(Value = "Increases Interest Rate")]
        IncreasesInterestRate = 1,
        [EnumMember(Value = "Has no impact on Loan Terms")]
        HasNoImpactOnLoanTerms = 2
    }
}