using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SctyIstrmtPrepBySamePtyTypDesc
    {
        [EnumMember(Value = "Lender Info Tab")]
        LenderInfoTab = 0,
        [EnumMember(Value = "Encompass Closer")]
        EncompassCloser = 1,
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 2,
        [EnumMember(Value = "Encompass Lender File Contacts")]
        EncompassLenderFileContacts = 3,
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 4,
        [EnumMember(Value = "User Input")]
        UserInput = 5
    }
}