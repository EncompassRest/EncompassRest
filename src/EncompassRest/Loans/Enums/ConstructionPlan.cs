using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ConstructionPlan
    {
        [EnumMember(Value = "First Submission")]
        FirstSubmission = 0,
        [EnumMember(Value = "Repeat Case")]
        RepeatCase = 1
    }
}