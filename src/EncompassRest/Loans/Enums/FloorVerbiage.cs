using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FloorVerbiage
    {
        [EnumMember(Value = "My interest rate will never be less than the start rate or [floor].")]
        MyInterestRateWillNeverBeLessThanTheStartRateOrFloor = 0,
        [EnumMember(Value = "or less than [floor].")]
        OrLessThanFloor = 1,
        [EnumMember(Value = "My interest rate will never be less than the margin or [floor].")]
        MyInterestRateWillNeverBeLessThanTheMarginOrFloor = 2,
        [EnumMember(Value = "or less than the Margin.")]
        OrLessThanTheMargin = 3
    }
}