using System.Runtime.Serialization;

namespace EncompassApi.Company.Users
{
    /// <summary>
    /// SubordinateLoanAccess
    /// </summary>
    public enum SubordinateLoanAccess
    {
        /// <summary>
        /// ReadOnly
        /// </summary>
        [EnumMember(Value = "readOnly")]
        ReadOnly = 0,
        /// <summary>
        /// ReadWrite
        /// </summary>
        [EnumMember(Value = "readWrite")]
        ReadWrite = 1
    }
}