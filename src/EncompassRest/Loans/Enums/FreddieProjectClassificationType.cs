using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieProjectClassificationType
    {
        [EnumMember(Value = "Condominium Project Manager Review")]
        CondominiumProjectManagerReview = 0,
        [EnumMember(Value = "Exempt From Review")]
        ExemptFromReview = 1,
        [EnumMember(Value = "FHA_Approved")]
        FHAApproved = 2,
        [EnumMember(Value = "Full Review")]
        FullReview = 3,
        [EnumMember(Value = "Project Eligibility Review Service")]
        ProjectEligibilityReviewService = 4,
        [EnumMember(Value = "Streamlined Review")]
        StreamlinedReview = 5
    }
}