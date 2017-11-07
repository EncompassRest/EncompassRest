using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ClosInstrLndCntcInfoSamePtyTypDesc
    {
        Lender = 0,
        Branch = 1,
        [EnumMember(Value = "Encompass Prepared By")]
        EncompassPreparedBy = 2,
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 3,
        [EnumMember(Value = "User Input")]
        UserInput = 4
    }
}