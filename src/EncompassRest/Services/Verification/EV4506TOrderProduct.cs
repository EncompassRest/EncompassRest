using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Verification
{
    public enum EV4506TOrderProduct
    {
        [EnumMember(Value = "0")]
        NoOrder = 0,
        [EnumMember(Value = "1")]
        Order = 1
    }
}