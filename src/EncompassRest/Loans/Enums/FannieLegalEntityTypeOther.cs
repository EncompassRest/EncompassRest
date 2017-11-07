using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieLegalEntityTypeOther
    {
        [EnumMember(Value = "LandTrust And Beneficiary Is Individual")]
        LandTrustAndBeneficiaryIsIndividual = 0,
        LivingTrust = 1
    }
}