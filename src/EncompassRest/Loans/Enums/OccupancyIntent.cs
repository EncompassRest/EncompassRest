using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum OccupancyIntent
    {
        [EnumMember(Value = "Will Occupy")]
        WillOccupy = 0,
        [EnumMember(Value = "Will Not Occupy")]
        WillNotOccupy = 1,
        [EnumMember(Value = "Currently Occupy")]
        CurrentlyOccupy = 2
    }
}