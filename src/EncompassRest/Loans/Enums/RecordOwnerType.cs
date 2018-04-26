using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// RecordOwnerType
    /// </summary>
    public enum RecordOwnerType
    {
        /// <summary>
        /// B
        /// </summary>
        [Description("B")]
        Borrower = 0,
        /// <summary>
        /// C
        /// </summary>
        [Description("C")]
        Coborrower = 1
    }
}