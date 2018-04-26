using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SctyIstrmtPrepBySamePtyTypDesc
    /// </summary>
    public enum SctyIstrmtPrepBySamePtyTypDesc
    {
        /// <summary>
        /// Lender Info Tab
        /// </summary>
        [EnumMember(Value = "Lender Info Tab")]
        LenderInfoTab = 0,
        /// <summary>
        /// Encompass Closer
        /// </summary>
        [EnumMember(Value = "Encompass Closer")]
        EncompassCloser = 1,
        /// <summary>
        /// Encompass Prepared By
        /// </summary>
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 2,
        /// <summary>
        /// Encompass Lender File Contacts
        /// </summary>
        [EnumMember(Value = "Encompass Lender File Contacts")]
        EncompassLenderFileContacts = 3,
        /// <summary>
        /// Buyer's Attorney
        /// </summary>
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 4,
        /// <summary>
        /// User Input
        /// </summary>
        [EnumMember(Value = "User Input")]
        UserInput = 5
    }
}