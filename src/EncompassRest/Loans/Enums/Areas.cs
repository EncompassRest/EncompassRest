using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Areas
    {
        [EnumMember(Value = "Targeted Area")]
        TargetedArea = 0,
        [EnumMember(Value = "Non-Targeted Area")]
        NonTargetedArea = 1
    }
}