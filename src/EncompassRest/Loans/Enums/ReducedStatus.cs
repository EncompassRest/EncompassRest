using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ReducedStatus
    {
        [EnumMember(Value = "did not change")]
        DidNotChange = 0,
        [EnumMember(Value = "increased")]
        Increased = 1,
        [EnumMember(Value = "decreased")]
        Decreased = 2
    }
}