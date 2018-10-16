using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// YNOrOther
    /// </summary>
    public enum YNOrOther
    {
        /// <summary>
        /// No
        /// </summary>
        [Description("No")]
        N = 0,
        /// <summary>
        /// Yes
        /// </summary>
        [Description("Yes")]
        Y = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}