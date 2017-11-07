using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BorContingentLiabilitiesLiabilityDescription
    {
        [EnumMember(Value = "FHA Assumed Mortgage Payment")]
        FHAAssumedMortgagePayment = 0,
        [EnumMember(Value = "VA Assumed Mortgage Payment")]
        VAAssumedMortgagePayment = 1,
        [EnumMember(Value = "Conventional Assumed Mortgage Payment")]
        ConventionalAssumedMortgagePayment = 2
    }
}