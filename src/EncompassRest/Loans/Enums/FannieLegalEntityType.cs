using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieLegalEntityType
    {
        Corporation = 0,
        [EnumMember(Value = "Government Entity")]
        GovernmentEntity = 1,
        [EnumMember(Value = "Joint Venture")]
        JointVenture = 2,
        [EnumMember(Value = "Limited Liability Company")]
        LimitedLiabilityCompany = 3,
        [EnumMember(Value = "Limited Partnership")]
        LimitedPartnership = 4,
        [EnumMember(Value = "Nonprofit Corporation")]
        NonprofitCorporation = 5,
        Other = 6,
        Partnership = 7
    }
}