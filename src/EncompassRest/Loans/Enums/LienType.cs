using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
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