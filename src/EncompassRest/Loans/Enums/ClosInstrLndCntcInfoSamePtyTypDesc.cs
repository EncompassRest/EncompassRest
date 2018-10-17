using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ClosInstrLndCntcInfoSamePtyTypDesc
    /// </summary>
    public enum ClosInstrLndCntcInfoSamePtyTypDesc
    {
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 0,
        /// <summary>
        /// Branch
        /// </summary>
        Branch = 1,
        /// <summary>
        /// Encompass Prepared By
        /// </summary>
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 2,
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