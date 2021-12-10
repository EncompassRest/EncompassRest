using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannieRelatedLoanLienPosition
    /// </summary>
    public enum FannieRelatedLoanLienPosition
    {
        /// <summary>
        /// Second Lien
        /// </summary>
        [EnumMember(Value = "Second Lien")]
        SecondLien = 2
    }
}