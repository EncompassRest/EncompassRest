using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IndexLookbackPeriod
    {
        [EnumMember(Value = "30 days")]
        n30Days = 0,
        [EnumMember(Value = "45 days")]
        n45Days = 1,
        [EnumMember(Value = "First Business Day")]
        FirstBusinessDay = 2
    }
}