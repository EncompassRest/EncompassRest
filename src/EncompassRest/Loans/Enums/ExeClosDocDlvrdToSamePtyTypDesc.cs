using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ExeClosDocDlvrdToSamePtyTypDesc
    {
        [EnumMember(Value = "Lender Info Tab")]
        LenderInfoTab = 0,
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 1,
        [EnumMember(Value = "Encompass Lender File Contact")]
        EncompassLenderFileContact = 2,
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 3,
        [EnumMember(Value = "User Input")]
        UserInput = 4
    }
}