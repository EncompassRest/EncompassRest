using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieRelatedLoanLienPosition
    /// </summary>
    public enum FreddieRelatedLoanLienPosition
    {
        /// <summary>
        /// Second Lien
        /// </summary>
        [EnumMember(Value = "Second Lien")]
        SecondLien = 2,
        /// <summary>
        /// Third Lien
        /// </summary>
        [EnumMember(Value = "Third Lien")]
        ThirdLien = 3,
        /// <summary>
        /// Fourth Lien
        /// </summary>
        [EnumMember(Value = "Fourth Lien")]
        FourthLien = 4
    }
}