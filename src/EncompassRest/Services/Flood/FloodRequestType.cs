using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Flood
{
    public enum FloodRequestType
    {
        [EnumMember(Value = "newRequest")]
        NewRequest = 0
    }
}