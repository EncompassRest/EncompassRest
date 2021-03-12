using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FannieLegalEntityType
    /// </summary>
    public enum FannieLegalEntityType
    {
        /// <summary>
        /// Corporation
        /// </summary>
        Corporation = 0,
        /// <summary>
        /// Government Entity
        /// </summary>
        [EnumMember(Value = "Government Entity")]
        GovernmentEntity = 1,
        /// <summary>
        /// Joint Venture
        /// </summary>
        [EnumMember(Value = "Joint Venture")]
        JointVenture = 2,
        /// <summary>
        /// Limited Liability Company
        /// </summary>
        [EnumMember(Value = "Limited Liability Company")]
        LimitedLiabilityCompany = 3,
        /// <summary>
        /// Limited Partnership
        /// </summary>
        [EnumMember(Value = "Limited Partnership")]
        LimitedPartnership = 4,
        /// <summary>
        /// Nonprofit Corporation
        /// </summary>
        [EnumMember(Value = "Nonprofit Corporation")]
        NonprofitCorporation = 5,
        /// <summary>
        /// Other (Retired 8-25-14)
        /// </summary>
        [Description("Other (Retired 8-25-14)")]
        Other = 6,
        /// <summary>
        /// Partnership
        /// </summary>
        Partnership = 7
    }
}