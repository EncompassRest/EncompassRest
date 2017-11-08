using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HudLoanDataPropertyType
    {
        [EnumMember(Value = "1 Unit")]
        n1Unit = 0,
        [EnumMember(Value = "2 Units")]
        n2Units = 1,
        [EnumMember(Value = "3-4 Units")]
        n34Units = 2,
        Condominium = 3,
        Cooperative = 4,
        ManufacturedHousing = 5
    }
}