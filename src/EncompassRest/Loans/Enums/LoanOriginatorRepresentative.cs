using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanOriginatorRepresentative
    /// </summary>
    public enum LoanOriginatorRepresentative
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