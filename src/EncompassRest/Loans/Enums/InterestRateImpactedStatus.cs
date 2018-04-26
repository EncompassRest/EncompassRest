using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// InterestRateImpactedStatus
    /// </summary>
    public enum InterestRateImpactedStatus
    {
        /// <summary>
        /// Decreases Interest Rate
        /// </summary>
        [EnumMember(Value = "Decreases Interest Rate")]
        DecreasesInterestRate = 0,
        /// <summary>
        /// Increases Interest Rate
        /// </summary>
        [EnumMember(Value = "Increases Interest Rate")]
        IncreasesInterestRate = 1,
        /// <summary>
        /// Has no impact on Loan Terms
        /// </summary>
        [EnumMember(Value = "Has no impact on Loan Terms")]
        HasNoImpactOnLoanTerms = 2
    }
}