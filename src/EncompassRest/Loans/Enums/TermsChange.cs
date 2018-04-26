using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// TermsChange
    /// </summary>
    public enum TermsChange
    {
        /// <summary>
        /// are not
        /// </summary>
        [Description("are not")]
        AreNot = 0,
        /// <summary>
        /// are
        /// </summary>
        [Description("are")]
        Are = 1
    }
}