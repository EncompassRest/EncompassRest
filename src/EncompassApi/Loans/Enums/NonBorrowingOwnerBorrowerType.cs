using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// NonBorrowingOwnerBorrowerType
    /// </summary>
    public enum NonBorrowingOwnerBorrowerType
    {
        /// <summary>
        /// Title only
        /// </summary>
        [EnumMember(Value = "Title only")]
        TitleOnly = 0,
        /// <summary>
        /// Title Only Trustee
        /// </summary>
        [EnumMember(Value = "Title Only Trustee")]
        TitleOnlyTrustee = 1,
        /// <summary>
        /// Title Only Settlor Trustee
        /// </summary>
        [EnumMember(Value = "Title Only Settlor Trustee")]
        TitleOnlySettlorTrustee = 2,
        /// <summary>
        /// Non Title Spouse
        /// </summary>
        [EnumMember(Value = "Non Title Spouse")]
        NonTitleSpouse = 3
    }
}