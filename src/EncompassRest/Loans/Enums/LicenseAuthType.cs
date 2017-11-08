using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LicenseAuthType
    {
        Private = 0,
        [EnumMember(Value = "Public Federal")]
        PublicFederal = 1,
        [EnumMember(Value = "Public Local")]
        PublicLocal = 2,
        [EnumMember(Value = "Public State")]
        PublicState = 3
    }
}