using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FloorVerbiage
    /// </summary>
    public enum FloorVerbiage
    {
        /// <summary>
        /// My interest rate will never be less than the start rate or [floor].
        /// </summary>
        [EnumMember(Value = "My interest rate will never be less than the start rate or [floor].")]
        MyInterestRateWillNeverBeLessThanTheStartRateOrFloor = 0,
        /// <summary>
        /// or less than [floor].
        /// </summary>
        [EnumMember(Value = "or less than [floor].")]
        OrLessThanFloor = 1,
        /// <summary>
        /// My interest rate will never be less than the margin or [floor].
        /// </summary>
        [EnumMember(Value = "My interest rate will never be less than the margin or [floor].")]
        MyInterestRateWillNeverBeLessThanTheMarginOrFloor = 2,
        /// <summary>
        /// or less than the Margin.
        /// </summary>
        [EnumMember(Value = "or less than the Margin.")]
        OrLessThanTheMargin = 3
    }
}