using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieLegalEntityType
    {
        Estate = 0,
        [EnumMember(Value = "Government Entity")]
        GovernmentEntity = 1,
        [EnumMember(Value = "Limited Liability Company")]
        LimitedLiabilityCompany = 2,
        [EnumMember(Value = "Limited Partnership")]
        LimitedPartnership = 3,
        [EnumMember(Value = "Joint Venture")]
        JointVenture = 4,
        [EnumMember(Value = "Nonprofit Corporation")]
        NonprofitCorporation = 5,
        Other = 6
    }
}