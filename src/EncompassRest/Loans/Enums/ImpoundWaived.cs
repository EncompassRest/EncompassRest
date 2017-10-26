using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ImpoundWaived
    {
        Waived = 0,
        [EnumMember(Value = "Not Waived")]
        NotWaived = 1
    }
}