using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.AUS
{
    public enum AUSConditionType
    {
        [EnumMember(Value = "preliminary")]
        Preliminary = 0,
        [EnumMember(Value = "underwriting")]
        Underwriting = 1
    }
}