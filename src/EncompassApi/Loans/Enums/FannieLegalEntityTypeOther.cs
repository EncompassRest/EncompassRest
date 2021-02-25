using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FannieLegalEntityTypeOther
    /// </summary>
    public enum FannieLegalEntityTypeOther
    {
        /// <summary>
        /// LandTrust And Beneficiary Is Individual
        /// </summary>
        [EnumMember(Value = "LandTrust And Beneficiary Is Individual")]
        LandTrustAndBeneficiaryIsIndividual = 0,
        /// <summary>
        /// LivingTrust
        /// </summary>
        LivingTrust = 1
    }
}