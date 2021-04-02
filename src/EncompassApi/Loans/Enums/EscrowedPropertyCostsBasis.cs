using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// EscrowedPropertyCostsBasis
    /// </summary>
    public enum EscrowedPropertyCostsBasis
    {
        /// <summary>
        /// Consummation Date
        /// </summary>
        [Description("Consummation Date")]
        ConsummationDate = 0,
        /// <summary>
        /// 1st Payment Date
        /// </summary>
        [Description("1st Payment Date")]
        [EnumMember(Value = "1stPaymentDate")]
        n1stPaymentDate = 1
    }
}