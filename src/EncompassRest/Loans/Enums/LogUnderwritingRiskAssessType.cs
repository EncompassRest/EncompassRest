using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LogUnderwritingRiskAssessType
    /// </summary>
    public enum LogUnderwritingRiskAssessType
    {
        /// <summary>
        /// Manual Underwriting
        /// </summary>
        [EnumMember(Value = "Manual Underwriting")]
        ManualUnderwriting = 0,
        /// <summary>
        /// DU
        /// </summary>
        DU = 1,
        /// <summary>
        /// Early Check
        /// </summary>
        [Description("Early Check")]
        EarlyCheck = 2,
        /// <summary>
        /// LPA
        /// </summary>
        [Description("LPA")]
        LP = 3,
        /// <summary>
        /// LQA
        /// </summary>
        LQA = 4,
        /// <summary>
        /// Other
        /// </summary>
        Other = 5
    }
}