using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ATRQMStatus
    {
        [EnumMember(Value = "Meets Standard")]
        MeetsStandard = 0,
        [EnumMember(Value = "Not Meet")]
        NotMeet = 1,
        [EnumMember(Value = "Review Needed")]
        ReviewNeeded = 2
    }
}