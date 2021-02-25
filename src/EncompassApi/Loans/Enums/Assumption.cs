using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// Assumption
    /// </summary>
    public enum Assumption
    {
        /// <summary>
        /// will allow, under certain conditions, this person to assume this loan on the original terms.
        /// </summary>
        [Description("will allow, under certain conditions, this person to assume this loan on the original terms.")]
        WillAllowAssumption = 0,
        /// <summary>
        /// will not allow assumption of this loan on the original terms.
        /// </summary>
        [Description("will not allow assumption of this loan on the original terms.")]
        WillNotAllowAssumption = 1
    }
}