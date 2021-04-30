using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RiskAssessmentType
    /// </summary>
    public enum RiskAssessmentType
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
        /// LP
        /// </summary>
        LP = 2,
        /// <summary>
        /// LQA
        /// </summary>
        LQA = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4
    }
}