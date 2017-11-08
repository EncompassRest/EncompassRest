using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum OtherPropertyType
    {
        [EnumMember(Value = "1 Unit")]
        n1Unit = 0,
        [EnumMember(Value = "2-4 Units")]
        n24Units = 1,
        Condominium = 2,
        PUD = 3,
        Cooperative = 4,
        [EnumMember(Value = "Manufactured Housing Single Wide")]
        ManufacturedHousingSingleWide = 5,
        [EnumMember(Value = "Manufactured Housing Multiwide")]
        ManufacturedHousingMultiwide = 6
    }
}