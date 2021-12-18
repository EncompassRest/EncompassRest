using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BorrLenderPaid
    /// </summary>
    public enum BorrLenderPaid
    {
        /// <summary>
        /// Lender
        /// </summary>
        [Description("Lender")]
        [EnumMember(Value = "Lender Paid")]
        LenderPaid = 0,
        /// <summary>
        /// Borrower
        /// </summary>
        [Description("Borrower")]
        [EnumMember(Value = "Borrower Paid")]
        BorrowerPaid = 1,
        /// <summary>
        /// Exempt
        /// </summary>
        Exempt = 2
    }
}