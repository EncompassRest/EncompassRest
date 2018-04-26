using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// Preapprovals
    /// </summary>
    public enum Preapprovals
    {
        /// <summary>
        /// 1. Preapproval requested
        /// </summary>
        [Description("1. Preapproval requested")]
        [EnumMember(Value = "Preapproval was requested")]
        PreapprovalWasRequested = 0,
        /// <summary>
        /// 2. Preapproval not requested
        /// </summary>
        [Description("2. Preapproval not requested")]
        [EnumMember(Value = "Preapproval was not requested")]
        PreapprovalWasNotRequested = 1,
        /// <summary>
        /// 3. Not Applicable
        /// </summary>
        [Description("3. Not Applicable")]
        [EnumMember(Value = "Not Applicable")]
        NotApplicable = 2
    }
}