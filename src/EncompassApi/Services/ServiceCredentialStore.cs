using System.Runtime.Serialization;

namespace EncompassApi.Services
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