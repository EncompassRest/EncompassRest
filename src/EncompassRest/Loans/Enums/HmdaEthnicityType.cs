using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HmdaEthnicityType
    {
        [EnumMember(Value = "Hispanic or Latino")]
        HispanicOrLatino = 0,
        [EnumMember(Value = "Not Hispanic or Latino")]
        NotHispanicOrLatino = 1,
        [EnumMember(Value = "Information not provided")]
        InformationNotProvided = 2,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 3
    }
}