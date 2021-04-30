using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// WhoPaidCompensation
    /// </summary>
    public enum WhoPaidCompensation
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