using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ServicingStatus
    {
        [EnumMember(Value = "Not Servicing")]
        NotServicing = 0,
        Current = 1,
        [EnumMember(Value = "Past Due")]
        PastDue = 2,
        Foreclosure = 3,
        [EnumMember(Value = "Servicing Released")]
        ServicingReleased = 4
    }
}