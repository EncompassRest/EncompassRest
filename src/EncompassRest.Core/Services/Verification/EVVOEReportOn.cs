using System.Runtime.Serialization;

namespace EncompassRest.Services.Verification
{
    /// <summary>
    /// EVVOEReportOn
    /// </summary>
    public enum EVVOEReportOn
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Co-Borrower
        /// </summary>
        [EnumMember(Value = "Co-Borrower")]
        CoBorrower = 1
    }
}