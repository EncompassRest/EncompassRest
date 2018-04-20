using System.Runtime.Serialization;

namespace EncompassRest.Loans.Milestones
{
    public enum MilestoneAction
    {
        [EnumMember(Value = "finish")]
        Finish = 0,
        [EnumMember(Value = "unfinish")]
        Unfinish = 1
    }
}