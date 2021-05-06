using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
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