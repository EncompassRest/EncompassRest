using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieLegalEntityTypeOther
    {
        [EnumMember(Value = "Illinois LandTrust")]
        IllinoisLandTrust = 0,
        LandTrust = 1,
        [EnumMember(Value = "Living Trust")]
        LivingTrust = 2,
        [EnumMember(Value = "Native American Tribe Or Tribal Organization")]
        NativeAmericanTribeOrTribalOrganization = 3
    }
}