using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ExeClosDocDlvrdToSamePtyTypDesc
    /// </summary>
    public enum ExeClosDocDlvrdToSamePtyTypDesc
    {
        /// <summary>
        /// Lender Info Tab
        /// </summary>
        [EnumMember(Value = "Lender Info Tab")]
        LenderInfoTab = 0,
        /// <summary>
        /// Encompass Prepared By
        /// </summary>
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 1,
        /// <summary>
        /// Encompass Lender File Contact
        /// </summary>
        [EnumMember(Value = "Encompass Lender File Contact")]
        EncompassLenderFileContact = 2,
        /// <summary>
        /// Buyer's Attorney
        /// </summary>
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 3,
        /// <summary>
        /// User Input
        /// </summary>
        [EnumMember(Value = "User Input")]
        UserInput = 4
    }
}