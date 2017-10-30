using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IndexLookbackPeriod
    {
        [EnumMember(Value = "First Business Day")]
        FirstBusinessDay = 1,
        [EnumMember(Value = "30 days")]
        n30Days = 30,
        [EnumMember(Value = "45 days")]
        n45Days = 45
    }
}