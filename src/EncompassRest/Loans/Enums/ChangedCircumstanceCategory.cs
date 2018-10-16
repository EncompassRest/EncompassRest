using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ChangedCircumstanceCategory
    /// </summary>
    public enum ChangedCircumstanceCategory
    {
        /// <summary>
        /// Cannot Decrease
        /// </summary>
        [EnumMember(Value = "Cannot Decrease")]
        CannotDecrease = 0,
        /// <summary>
        /// Cannot Increase
        /// </summary>
        [EnumMember(Value = "Cannot Increase")]
        CannotIncrease = 1,
        /// <summary>
        /// Cannot Increase > 10%
        /// </summary>
        [EnumMember(Value = "Cannot Increase > 10%")]
        CannotIncrease10 = 2
    }
}