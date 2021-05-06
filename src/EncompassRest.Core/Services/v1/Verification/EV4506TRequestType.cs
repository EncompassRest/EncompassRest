using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.Verification
{
    /// <summary>
    /// EV4506TRequestType
    /// </summary>
    public enum EV4506TRequestType
    {
        /// <summary>
        /// newRequest
        /// </summary>
        [EnumMember(Value = "newRequest")]
        NewRequest = 0,
        /// <summary>
        /// update
        /// </summary>
        [EnumMember(Value = "update")]
        Update = 1,
        /// <summary>
        /// statusQuery
        /// </summary>
        [EnumMember(Value = "statusQuery")]
        StatusQuery = 2,
        /// <summary>
        /// changePassword
        /// </summary>
        [EnumMember(Value = "changePassword")]
        ChangePassword = 3,
        /// <summary>
        /// forgotPassword
        /// </summary>
        [EnumMember(Value = "forgotPassword")]
        ForgotPassword = 4
    }
}