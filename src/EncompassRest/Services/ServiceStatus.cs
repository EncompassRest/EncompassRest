using System.Runtime.Serialization;

namespace EncompassRest.Services
{
    public enum ServiceStatus
    {
        [EnumMember(Value = "success")]
        Success = 0
    }
}