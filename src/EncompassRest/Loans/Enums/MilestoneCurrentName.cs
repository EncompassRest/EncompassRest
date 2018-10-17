using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// MilestoneCurrentName
    /// </summary>
    public enum MilestoneCurrentName
    {
        /// <summary>
        /// Started
        /// </summary>
        Started = 0,
        /// <summary>
        /// Sent to processing
        /// </summary>
        [EnumMember(Value = "Sent to processing")]
        SentToProcessing = 1,
        /// <summary>
        /// Submitted
        /// </summary>
        Submitted = 2,
        /// <summary>
        /// Approved
        /// </summary>
        Approved = 3,
        /// <summary>
        /// Doc signed
        /// </summary>
        [EnumMember(Value = "Doc signed")]
        DocSigned = 4,
        /// <summary>
        /// Funded
        /// </summary>
        Funded = 5,
        /// <summary>
        /// Completed
        /// </summary>
        Completed = 6
    }
}