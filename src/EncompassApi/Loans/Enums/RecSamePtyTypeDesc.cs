using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RecSamePtyTypeDesc
    /// </summary>
    public enum RecSamePtyTypeDesc
    {
        /// <summary>
        /// Lender Info Tab
        /// </summary>
        [EnumMember(Value = "Lender Info Tab")]
        LenderInfoTab = 0,
        /// <summary>
        /// Title
        /// </summary>
        Title = 1,
        /// <summary>
        /// Escrow
        /// </summary>
        Escrow = 2,
        /// <summary>
        /// Encompass Prepared By
        /// </summary>
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 3,
        /// <summary>
        /// Buyer's Attorney
        /// </summary>
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 4,
        /// <summary>
        /// Investor
        /// </summary>
        Investor = 5,
        /// <summary>
        /// User Input
        /// </summary>
        [EnumMember(Value = "User Input")]
        UserInput = 6
    }
}