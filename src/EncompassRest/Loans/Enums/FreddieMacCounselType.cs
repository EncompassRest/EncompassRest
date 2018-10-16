using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMacCounselType
    /// </summary>
    public enum FreddieMacCounselType
    {
        /// <summary>
        /// A: Not Counseled
        /// </summary>
        [Description("A: Not Counseled")]
        A = 0,
        /// <summary>
        /// B: Lender
        /// </summary>
        [Description("B: Lender")]
        B = 1,
        /// <summary>
        /// C: Third Party
        /// </summary>
        [Description("C: Third Party")]
        C = 2,
        /// <summary>
        /// D: HUD Approved Agency
        /// </summary>
        [Description("D: HUD Approved Agency")]
        D = 3
    }
}