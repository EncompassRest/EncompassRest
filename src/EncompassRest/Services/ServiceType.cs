using System.Runtime.Serialization;

namespace EncompassRest.Services
{
    public enum ServiceType
    {
        [EnumMember(Value = "CREDITIQ")]
        Credit = 0,
        [EnumMember(Value = "VERIF")]
        Verification = 1,
        AUS = 3,
        [EnumMember(Value = "APPRAISAL")]
        Appraisal = 4,
        [EnumMember(Value = "FLOOD")]
        Flood = 5
    }
}