using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SubmissionOfApplication
    {
        [EnumMember(Value = "Submitted directly to your institution")]
        SubmittedDirectlyToYourInstitution = 0,
        [EnumMember(Value = "Not submitted directly to your institution")]
        NotSubmittedDirectlyToYourInstitution = 1,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 2
    }
}