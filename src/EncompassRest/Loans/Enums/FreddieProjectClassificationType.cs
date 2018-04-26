using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieProjectClassificationType
    /// </summary>
    public enum FreddieProjectClassificationType
    {
        /// <summary>
        /// Condominium Project Manager Review
        /// </summary>
        [EnumMember(Value = "Condominium Project Manager Review")]
        CondominiumProjectManagerReview = 0,
        /// <summary>
        /// Exempt From Review
        /// </summary>
        [EnumMember(Value = "Exempt From Review")]
        ExemptFromReview = 1,
        /// <summary>
        /// FHA_Approved
        /// </summary>
        [EnumMember(Value = "FHA_Approved")]
        FHAApproved = 2,
        /// <summary>
        /// Full Review
        /// </summary>
        [EnumMember(Value = "Full Review")]
        FullReview = 3,
        /// <summary>
        /// Project Eligibility Review Service
        /// </summary>
        [EnumMember(Value = "Project Eligibility Review Service")]
        ProjectEligibilityReviewService = 4,
        /// <summary>
        /// Streamlined Review
        /// </summary>
        [EnumMember(Value = "Streamlined Review")]
        StreamlinedReview = 5
    }
}