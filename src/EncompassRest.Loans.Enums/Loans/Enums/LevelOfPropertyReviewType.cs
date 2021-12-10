using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LevelOfPropertyReviewType
    /// </summary>
    public enum LevelOfPropertyReviewType
    {
        /// <summary>
        /// Exterior / Interior
        /// </summary>
        [Description("Exterior / Interior")]
        [EnumMember(Value = "Exterior/Interior")]
        ExteriorInterior = 0,
        /// <summary>
        /// Exterior Only
        /// </summary>
        [EnumMember(Value = "Exterior Only")]
        ExteriorOnly = 1,
        /// <summary>
        /// No Appraisal
        /// </summary>
        [EnumMember(Value = "No Appraisal")]
        NoAppraisal = 2
    }
}