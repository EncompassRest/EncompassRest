using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ExistingLoanProvidedByLicenseeType
    /// </summary>
    public enum ExistingLoanProvidedByLicenseeType
    {
        /// <summary>
        /// Originated by the same broker or affiliate/related entity of the broker
        /// </summary>
        [EnumMember(Value = "Originated by the same broker or affiliate/related entity of the broker")]
        OriginatedByTheSameBrokerOrAffiliateRelatedEntityOfTheBroker = 0,
        /// <summary>
        /// Originated by the same broker and is funded by the same creditor
        /// </summary>
        [EnumMember(Value = "Originated by the same broker and is funded by the same creditor")]
        OriginatedByTheSameBrokerAndIsFundedByTheSameCreditor = 1,
        /// <summary>
        /// Made or is currently held by the same creditor or an affiliate of the creditor
        /// </summary>
        [EnumMember(Value = "Made or is currently held by the same creditor or an affiliate of the creditor")]
        MadeOrIsCurrentlyHeldByTheSameCreditorOrAnAffiliateOfTheCreditor = 2
    }
}