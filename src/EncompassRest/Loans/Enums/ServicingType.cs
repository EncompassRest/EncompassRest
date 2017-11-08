using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ServicingType
    {
        [EnumMember(Value = "Service Retained")]
        ServiceRetained = 0,
        [EnumMember(Value = "Service Released")]
        ServiceReleased = 1
    }
}