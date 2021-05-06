using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LicenseAuthType
    /// </summary>
    public enum LicenseAuthType
    {
        /// <summary>
        /// Private
        /// </summary>
        Private = 0,
        /// <summary>
        /// Public Federal
        /// </summary>
        [EnumMember(Value = "Public Federal")]
        PublicFederal = 1,
        /// <summary>
        /// Public Local
        /// </summary>
        [EnumMember(Value = "Public Local")]
        PublicLocal = 2,
        /// <summary>
        /// Public State
        /// </summary>
        [EnumMember(Value = "Public State")]
        PublicState = 3
    }
}