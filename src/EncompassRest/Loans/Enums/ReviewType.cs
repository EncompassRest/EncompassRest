using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ReviewType
    {
        Full = 0,
        [EnumMember(Value = "Drive By")]
        DriveBy = 1,
        Desk = 2
    }
}