using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ConstructionPlan
    /// </summary>
    public enum ConstructionPlan
    {
        /// <summary>
        /// First Submission
        /// </summary>
        [EnumMember(Value = "First Submission")]
        FirstSubmission = 0,
        /// <summary>
        /// Repeat Case
        /// </summary>
        [EnumMember(Value = "Repeat Case")]
        RepeatCase = 1
    }
}