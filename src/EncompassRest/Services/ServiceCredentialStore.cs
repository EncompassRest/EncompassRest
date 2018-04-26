using System.Runtime.Serialization;

namespace EncompassRest.Services
{
    public enum ServiceCredentialStore
    {
        [EnumMember(Value = "user")]
        User = 0,
        [EnumMember(Value = "company")]
        Company = 1
    }
}