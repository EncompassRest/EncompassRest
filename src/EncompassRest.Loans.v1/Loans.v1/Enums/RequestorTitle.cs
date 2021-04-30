using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RequestorTitle
    /// </summary>
    public enum RequestorTitle
    {
        /// <summary>
        /// CEO
        /// </summary>
        CEO = 0,
        /// <summary>
        /// CFO
        /// </summary>
        CFO = 1,
        /// <summary>
        /// Managing Member
        /// </summary>
        [EnumMember(Value = "Managing Member")]
        ManagingMember = 2,
        /// <summary>
        /// Member Manager
        /// </summary>
        [EnumMember(Value = "Member Manager")]
        MemberManager = 3,
        /// <summary>
        /// Owner
        /// </summary>
        Owner = 4,
        /// <summary>
        /// Partner
        /// </summary>
        Partner = 5,
        /// <summary>
        /// Partnership
        /// </summary>
        Partnership = 6,
        /// <summary>
        /// President
        /// </summary>
        President = 7,
        /// <summary>
        /// Secretary
        /// </summary>
        Secretary = 8,
        /// <summary>
        /// Treasurer
        /// </summary>
        Treasurer = 9,
        /// <summary>
        /// Vice President
        /// </summary>
        [EnumMember(Value = "Vice President")]
        VicePresident = 10
    }
}