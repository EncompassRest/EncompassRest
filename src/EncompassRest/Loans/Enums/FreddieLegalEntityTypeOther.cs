using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieLegalEntityTypeOther
    /// </summary>
    public enum FreddieLegalEntityTypeOther
    {
        /// <summary>
        /// Illinois LandTrust
        /// </summary>
        [EnumMember(Value = "Illinois LandTrust")]
        IllinoisLandTrust = 0,
        /// <summary>
        /// LandTrust
        /// </summary>
        LandTrust = 1,
        /// <summary>
        /// Living Trust
        /// </summary>
        [EnumMember(Value = "Living Trust")]
        LivingTrust = 2,
        /// <summary>
        /// Native American Tribe Or Tribal Organization
        /// </summary>
        [EnumMember(Value = "Native American Tribe Or Tribal Organization")]
        NativeAmericanTribeOrTribalOrganization = 3
    }
}