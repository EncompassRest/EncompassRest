using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// DisclosureDeliveredBy
    /// </summary>
    public enum DisclosureDeliveredBy
    {
        /// <summary>
        /// In Person
        /// </summary>
        [EnumMember(Value = "In Person")]
        InPerson = 0,
        /// <summary>
        /// By Fax
        /// </summary>
        [EnumMember(Value = "By Fax")]
        ByFax = 1,
        /// <summary>
        /// By E-Mail
        /// </summary>
        [EnumMember(Value = "By E-Mail")]
        ByEMail = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3
    }
}