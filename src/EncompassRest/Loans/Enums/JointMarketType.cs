using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// JointMarketType
    /// </summary>
    public enum JointMarketType
    {
        /// <summary>
        /// We do not engage in joint marketing
        /// </summary>
        [EnumMember(Value = "We do not engage in joint marketing")]
        WeDoNotEngageInJointMarketing = 0,
        /// <summary>
        /// We share personal information with joint marketing partners
        /// </summary>
        [EnumMember(Value = "We share personal information with joint marketing partners")]
        WeSharePersonalInformationWithJointMarketingPartners = 1
    }
}