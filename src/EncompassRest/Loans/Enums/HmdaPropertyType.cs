using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HmdaPropertyType
    {
        [EnumMember(Value = "One-to-fourFamily")]
        OneToFourFamily = 0,
        ManufacturedHousing = 1,
        MultifamilyDwelling = 2
    }
}