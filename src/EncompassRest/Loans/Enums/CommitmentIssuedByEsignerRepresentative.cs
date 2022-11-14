using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CommitmentIssuedByEsignerRepresentative
    /// </summary>
    public enum CommitmentIssuedByEsignerRepresentative
    {
        /// <summary>
        /// Roles
        /// </summary>
        Roles = 0,
        /// <summary>
        /// Custom File Contacts
        /// </summary>
        [EnumMember(Value = "Custom File Contacts")]
        CustomFileContacts = 1
    }
}