using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// BorrowerType
    /// </summary>
    public enum BorrowerType
    {
        /// <summary>
        /// Individual
        /// </summary>
        Individual = 0,
        /// <summary>
        /// Co-signer
        /// </summary>
        [EnumMember(Value = "Co-signer")]
        CoSigner = 1,
        /// <summary>
        /// Title only
        /// </summary>
        [EnumMember(Value = "Title only")]
        TitleOnly = 2,
        /// <summary>
        /// Non Title Spouse
        /// </summary>
        [EnumMember(Value = "Non Title Spouse")]
        NonTitleSpouse = 3,
        /// <summary>
        /// Trustee
        /// </summary>
        Trustee = 4,
        /// <summary>
        /// Title Only Trustee
        /// </summary>
        [EnumMember(Value = "Title Only Trustee")]
        TitleOnlyTrustee = 5,
        /// <summary>
        /// Settlor Trustee
        /// </summary>
        [EnumMember(Value = "Settlor Trustee")]
        SettlorTrustee = 6,
        /// <summary>
        /// Settlor
        /// </summary>
        Settlor = 7,
        /// <summary>
        /// Title Only Settlor Trustee
        /// </summary>
        [EnumMember(Value = "Title Only Settlor Trustee")]
        TitleOnlySettlorTrustee = 8,
        /// <summary>
        /// Officer
        /// </summary>
        Officer = 9
    }
}