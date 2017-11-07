using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ExistingLoanProvidedByLicenseeType
    {
        [EnumMember(Value = "Originated by the same broker or affiliate/related entity of the broker")]
        OriginatedByTheSameBrokerOrAffiliateRelatedEntityOfTheBroker = 0,
        [EnumMember(Value = "Originated by the same broker and is funded by the same creditor")]
        OriginatedByTheSameBrokerAndIsFundedByTheSameCreditor = 1,
        [EnumMember(Value = "Made or is currently held by the same creditor or an affiliate of the creditor")]
        MadeOrIsCurrentlyHeldByTheSameCreditorOrAnAffiliateOfTheCreditor = 2
    }
}