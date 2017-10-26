using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieRelatedLoanType
    {
        Conventional = 0,
        [EnumMember(Value = "USDA Rural Housing")]
        USDARuralHousing = 1
    }
}