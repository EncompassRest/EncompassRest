using System.Runtime.Serialization;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// PeerLoanAccess
    /// </summary>
    public enum PeerLoanAccess
    {
        /// <summary>
        /// ViewOnly
        /// </summary>
        [EnumMember(Value = "viewOnly")]
        ViewOnly = 0,
        /// <summary>
        /// Edit
        /// </summary>
        [EnumMember(Value = "edit")]
        Edit = 1,
        /// <summary>
        /// Disabled
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled = 2
    }
}