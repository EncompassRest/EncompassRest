using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RecSamePtyTypeDesc
    {
        [EnumMember(Value = "Lender Info Tab")]
        LenderInfoTab = 0,
        Title = 1,
        Escrow = 2,
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 3,
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 4,
        Investor = 5,
        [EnumMember(Value = "User Input")]
        UserInput = 6
    }
}