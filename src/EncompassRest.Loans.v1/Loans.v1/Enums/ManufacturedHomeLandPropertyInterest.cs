using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ManufacturedHomeLandPropertyInterest
    /// </summary>
    public enum ManufacturedHomeLandPropertyInterest
    {
        /// <summary>
        /// 1. Direct ownership
        /// </summary>
        [Description("1. Direct ownership")]
        [EnumMember(Value = "Direct ownership")]
        DirectOwnership = 0,
        /// <summary>
        /// 2. Indirect ownership
        /// </summary>
        [Description("2. Indirect ownership")]
        [EnumMember(Value = "Indirect ownership")]
        IndirectOwnership = 1,
        /// <summary>
        /// 3. Paid leasehold
        /// </summary>
        [Description("3. Paid leasehold")]
        [EnumMember(Value = "Paid leasehold")]
        PaidLeasehold = 2,
        /// <summary>
        /// 4. Unpaid leasehold
        /// </summary>
        [Description("4. Unpaid leasehold")]
        [EnumMember(Value = "Unpaid leasehold")]
        UnpaidLeasehold = 3,
        /// <summary>
        /// 5. Not applicable
        /// </summary>
        [Description("5. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 4,
        /// <summary>
        /// 1111. Exempt
        /// </summary>
        [Description("1111. Exempt")]
        Exempt = 5
    }
}