using System.Runtime.Serialization;

namespace EncompassRest.Services.v1
{
    /// <summary>
    /// ServiceCredentialStore
    /// </summary>
    public enum ServiceCredentialStore
    {
        /// <summary>
        /// user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 0,
        /// <summary>
        /// company
        /// </summary>
        [EnumMember(Value = "company")]
        Company = 1
    }
}