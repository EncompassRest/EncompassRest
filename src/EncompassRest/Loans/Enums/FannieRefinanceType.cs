using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieRefinanceType
    {
        [EnumMember(Value = "Disaster Response")]
        DisasterResponse = 0,
        [EnumMember(Value = "DU Refi Plus")]
        DURefiPlus = 1,
        [EnumMember(Value = "Refi Plus")]
        RefiPlus = 2
    }
}