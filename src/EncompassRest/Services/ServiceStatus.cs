using System.Runtime.Serialization;

namespace EncompassRest.Services
{
    public enum ServiceStatus
    {
        [EnumMember(Value = "pending")]
        Pending = 0,
        [EnumMember(Value = "success")]
        Success = 1,
        [EnumMember(Value = "error")]
        Error = 2
    }
}