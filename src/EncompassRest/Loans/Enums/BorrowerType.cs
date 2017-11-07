using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BorrowerType
    {
        Individual = 0,
        [EnumMember(Value = "Co-signer")]
        CoSigner = 1,
        [EnumMember(Value = "Title only")]
        TitleOnly = 2,
        [EnumMember(Value = "Non Title Spouse")]
        NonTitleSpouse = 3,
        Trustee = 4,
        [EnumMember(Value = "Title Only Trustee")]
        TitleOnlyTrustee = 5,
        [EnumMember(Value = "Settlor Trustee")]
        SettlorTrustee = 6,
        Settlor = 7,
        [EnumMember(Value = "Title Only Settlor Trustee")]
        TitleOnlySettlorTrustee = 8,
        Officer = 9
    }
}