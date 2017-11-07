using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TrstSamePtyTypDesc
    {
        Title = 0,
        Escrow = 1,
        [EnumMember(Value = "Encompass Trustee")]
        EncompassTrustee = 2,
        [EnumMember(Value = "Buyer's Attorney")]
        BuyersAttorney = 3,
        [EnumMember(Value = "User Input")]
        UserInput = 4
    }
}