using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ServiceType
    {
        [EnumMember(Value = "Title - Settlement and Closing")]
        TitleSettlementAndClosing = 0,
        [EnumMember(Value = "Title - Insurance")]
        TitleInsurance = 1,
        [EnumMember(Value = "Escrow - Settlement and Closing")]
        EscrowSettlementAndClosing = 2,
        [EnumMember(Value = "Escrow - Insurance")]
        EscrowInsurance = 3
    }
}