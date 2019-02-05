using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// YNOrPartiallyExempt
    /// </summary>
    public enum YNOrPartiallyExempt
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
        /// 1111 Partially Exempt
        /// </summary>
        [Description("1111 Partially Exempt")]
        [EnumMember(Value = "Partially Exempt")]
        PartiallyExempt = 2
    }
}