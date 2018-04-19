using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PrtAdtlDateHud1
    /// </summary>
    public enum PrtAdtlDateHud1
    {
        /// <summary>
        /// Disbursement Date
        /// </summary>
        [Description("Disbursement Date")]
        DisbDate = 0,
        /// <summary>
        /// ClosingDate
        /// </summary>
        ClosingDate = 1
    }
}