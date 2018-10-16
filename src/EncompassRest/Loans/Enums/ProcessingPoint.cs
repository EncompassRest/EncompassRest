using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ProcessingPoint
    /// </summary>
    public enum ProcessingPoint
    {
        /// <summary>
        /// Prequal (No URLA)
        /// </summary>
        [EnumMember(Value = "Prequal (No URLA)")]
        PrequalNoURLA = 0,
        /// <summary>
        /// Application/Processing
        /// </summary>
        [EnumMember(Value = "Application/Processing")]
        ApplicationProcessing = 1,
        /// <summary>
        /// Underwriting
        /// </summary>
        Underwriting = 2,
        /// <summary>
        /// Final Disposition
        /// </summary>
        [EnumMember(Value = "Final Disposition")]
        FinalDisposition = 3,
        /// <summary>
        /// Post-Closing QC
        /// </summary>
        [EnumMember(Value = "Post-Closing QC")]
        PostClosingQC = 4
    }
}