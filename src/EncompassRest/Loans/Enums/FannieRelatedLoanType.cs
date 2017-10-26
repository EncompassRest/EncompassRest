using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieRelatedLoanType
    {
        Conventional = 0,
        FHA = 1,
        [EnumMember(Value = "USDA Rural Housing")]
        USDARuralHousing = 2,
        VA = 3
    }
}