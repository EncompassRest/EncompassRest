using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// YNOrExempt
    /// </summary>
    public enum YNOrExempt
    {
        /// <summary>
        /// Yes
        /// </summary>
        [Description("Yes")]
        Y = 0,
        /// <summary>
        /// No
        /// </summary>
        [Description("No")]
        N = 1,
        /// <summary>
        /// 1111. Exempt
        /// </summary>
        [Description("1111. Exempt")]
        Exempt = 2
    }
}