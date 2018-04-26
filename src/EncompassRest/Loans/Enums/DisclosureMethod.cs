using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// DisclosureMethod
    /// </summary>
    public enum DisclosureMethod
    {
        /// <summary>
        /// U.S. Mail
        /// </summary>
        [EnumMember(Value = "U.S. Mail")]
        USMail = 0,
        /// <summary>
        /// eFolder eDisclosures
        /// </summary>
        [EnumMember(Value = "eFolder eDisclosures")]
        EFolderEDisclosures = 1,
        /// <summary>
        /// Fax
        /// </summary>
        Fax = 2,
        /// <summary>
        /// In Person
        /// </summary>
        [EnumMember(Value = "In Person")]
        InPerson = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4
    }
}