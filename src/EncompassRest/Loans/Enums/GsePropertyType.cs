using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GsePropertyType
    {
        SingleFamily = 0,
        Condominium = 1,
        Townhouse = 2,
        Cooperative = 3,
        TwoToFourUnitProperty = 4,
        MultifamilyMoreThanFourUnits = 5,
        ManufacturedMobileHome = 6,
        CommercialNonResidential = 7,
        HomeAndBusinessCombined = 8,
        MixedUseResidential = 9,
        Farm = 10,
        Land = 11
    }
}