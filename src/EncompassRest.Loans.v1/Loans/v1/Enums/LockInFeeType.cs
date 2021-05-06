using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LockInFeeType
    /// </summary>
    public enum LockInFeeType
    {
        /// <summary>
        /// Lock In Fee to Be Charged
        /// </summary>
        [Description("Lock In Fee to Be Charged")]
        Charged = 0,
        /// <summary>
        /// Lock In Fee Refundable
        /// </summary>
        [Description("Lock In Fee Refundable")]
        Refundable = 1
    }
}