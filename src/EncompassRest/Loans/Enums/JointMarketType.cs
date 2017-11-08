using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum JointMarketType
    {
        [EnumMember(Value = "We do not engage in joint marketing")]
        WeDoNotEngageInJointMarketing = 0,
        [EnumMember(Value = "We share personal information with joint marketing partners")]
        WeSharePersonalInformationWithJointMarketingPartners = 1
    }
}