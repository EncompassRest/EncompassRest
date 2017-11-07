using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum MilestoneCurrentName
    {
        Started = 0,
        [EnumMember(Value = "Sent to processing")]
        SentToProcessing = 1,
        Submitted = 2,
        Approved = 3,
        [EnumMember(Value = "Doc signed")]
        DocSigned = 4,
        Funded = 5,
        Completed = 6
    }
}