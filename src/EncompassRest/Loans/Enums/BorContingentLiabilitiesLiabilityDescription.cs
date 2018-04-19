using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BorContingentLiabilitiesLiabilityDescription
    /// </summary>
    public enum BorContingentLiabilitiesLiabilityDescription
    {
        /// <summary>
        /// FHA Assumed Mortgage Payment
        /// </summary>
        [EnumMember(Value = "FHA Assumed Mortgage Payment")]
        FHAAssumedMortgagePayment = 0,
        /// <summary>
        /// VA Assumed Mortgage Payment
        /// </summary>
        [EnumMember(Value = "VA Assumed Mortgage Payment")]
        VAAssumedMortgagePayment = 1,
        /// <summary>
        /// Conventional Assumed Mortgage Payment
        /// </summary>
        [EnumMember(Value = "Conventional Assumed Mortgage Payment")]
        ConventionalAssumedMortgagePayment = 2
    }
}