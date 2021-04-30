using System.Runtime.Serialization;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// User Rights Type
    /// </summary>
    public enum UserRightsType
    {
        /// <summary>
        /// Assigned
        /// </summary>
        [EnumMember(Value = "assignedRights")]
        Assigned = 0,
        /// <summary>
        /// Effective
        /// </summary>
        [EnumMember(Value = "effectiveRights")]
        Effective = 1
    }
}