using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Verification
{
    public enum EV4506TRequestType
    {
        [EnumMember(Value = "newRequest")]
        NewRequest = 0,
        [EnumMember(Value = "update")]
        Update = 1,
        [EnumMember(Value = "statusQuery")]
        StatusQuery = 2,
        [EnumMember(Value = "changePassword")]
        ChangePassword = 3,
        [EnumMember(Value = "forgotPassword")]
        ForgotPassword = 4
    }
}