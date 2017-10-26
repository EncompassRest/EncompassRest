using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum MortgageType
    {
        FHA = 0,
        [EnumMember(Value = "Rural Housing Service")]
        RuralHousingService = 1,
        FmHA = 2,
        Uninsured = 3,
        VA = 4,
        Insured = 5
    }
}