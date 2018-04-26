using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.AUS
{
    public enum AUSRequestType
    {
        [EnumMember(Value = "newOrder")]
        NewOrder = 0,
        [EnumMember(Value = "reissue")]
        Reissue = 1
    }
}