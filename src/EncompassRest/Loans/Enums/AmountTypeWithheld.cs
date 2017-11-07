using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AmountTypeWithheld
    {
        Escrow = 0,
        [EnumMember(Value = "Earmarked Account")]
        EarmarkedAccount = 1
    }
}