using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// YNOrNA
    /// </summary>
    public enum YNOrNA
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
        /// Not Applicable
        /// </summary>
        [Description("Not Applicable")]
        [EnumMember(Value = "N/A")]
        NA = 2
    }
}