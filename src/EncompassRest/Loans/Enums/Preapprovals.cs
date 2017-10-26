using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Preapprovals
    {
        [EnumMember(Value = "Preapproval was requested")]
        PreapprovalWasRequested = 0,
        [EnumMember(Value = "Preapproval was not requested")]
        PreapprovalWasNotRequested = 1,
        [EnumMember(Value = "Not Applicable")]
        NotApplicable = 2
    }
}