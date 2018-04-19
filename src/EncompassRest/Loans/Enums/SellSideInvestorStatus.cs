using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SellSideInvestorStatus
    /// </summary>
    public enum SellSideInvestorStatus
    {
        /// <summary>
        /// Assigned - Bulk
        /// </summary>
        [Description("Assigned - Bulk")]
        AssignedBulk = 0,
        /// <summary>
        /// Assigned - Flow
        /// </summary>
        [Description("Assigned - Flow")]
        AssignedFlow = 1,
        /// <summary>
        /// Shipped
        /// </summary>
        Shipped = 2,
        /// <summary>
        /// Purchased
        /// </summary>
        Purchased = 3,
        /// <summary>
        /// Rejected
        /// </summary>
        Rejected = 4,
        /// <summary>
        /// Unassigned
        /// </summary>
        [Description("Unassigned")]
        [EnumMember(Value = "")]
        Unassigned = 5
    }
}