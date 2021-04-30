using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LienType
    /// </summary>
    public enum LienType
    {
        /// <summary>
        /// First
        /// </summary>
        [Description("First")]
        FirstLien = 1,
        /// <summary>
        /// Second
        /// </summary>
        [Description("Second")]
        SecondLien = 2
    }
}