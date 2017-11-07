using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CommitmentType
    {
        [EnumMember(Value = "Best Efforts")]
        BestEfforts = 0,
        Mandatory = 1
    }
}