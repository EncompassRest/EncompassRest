using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HmdaAge
    /// </summary>
    public enum HmdaAge
    {
        /// <summary>
        /// 8888. Not applicable
        /// </summary>
        [Description("8888. Not applicable")]
        [EnumMember(Value = "8888")]
        n8888 = 8888,
        /// <summary>
        /// 9999. No Co-Applicant
        /// </summary>
        [Description("9999. No Co-Applicant")]
        [EnumMember(Value = "9999")]
        n9999 = 9999
    }
}