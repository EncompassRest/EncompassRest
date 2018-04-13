using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Appraisal
{
    public enum AppraisalPropertyType
    {
        [EnumMember(Value = "2 to 4 Unit Building")]
        n2to4UnitBuilding = 0,
        [EnumMember(Value = "5+ Unit Building")]
        n5PlusUnitBuilding = 1,
        Agricultural = 2,
        Apartment = 3,
        [EnumMember(Value = "Assembly/Meeting Place")]
        AssemblyMeetingPlace = 4,
        Attached = 5,
        [EnumMember(Value = "Commercial (Non-Residential)")]
        CommercialNonResidential = 6,
        [EnumMember(Value = "Commercial (other)")]
        CommercialOther = 7,
        Condominium = 8,
        Condotel = 9,
        Cooperative = 10,
        Detached = 11,
        [EnumMember(Value = "Detached PUD")]
        DetachedPUD = 12,
        Duplex = 13,
        Healthcare = 14,
        Industrial = 15,
        [EnumMember(Value = "Lodging & Hospitality")]
        LodgingAndHospitality = 16,
        [EnumMember(Value = "Manufactured Home")]
        ManufacturedHome = 17,
        [EnumMember(Value = "Mixed Use (Residential)")]
        MixedUseResidential = 18,
        [EnumMember(Value = "Mobile Home (Moveable)")]
        MobileHomeMoveable = 19,
        [EnumMember(Value = "Mobile Home (Permanent)")]
        MobileHomePermanent = 20,
        [EnumMember(Value = "Modular Home")]
        ModularHome = 21,
        [EnumMember(Value = "Multi Family Residence")]
        MultiFamilyResidence = 22,
        Office = 23,
        Other = 24,
        [EnumMember(Value = "Planned Unit Development")]
        PlannedUnitDevelopment = 25,
        Platted = 26,
        Quad = 27,
        [EnumMember(Value = "Retail/Restaurant")]
        RetailRestaurant = 28,
        [EnumMember(Value = "Senior Housing")]
        SeniorHousing = 29,
        [EnumMember(Value = "Shopping Center")]
        ShoppingCenter = 30,
        [EnumMember(Value = "Single Family")]
        SingleFamily = 31,
        [EnumMember(Value = "Special Purpose")]
        SpecialPurpose = 32,
        [EnumMember(Value = "Sports & Entertainment")]
        SportsAndEntertainment = 33,
        Townhouse = 34,
        Triplex = 35,
        UnPlatted = 36,
        [EnumMember(Value = "Vacant Land")]
        VacantLand = 37,
        [EnumMember(Value = "Vacant Lot")]
        VacantLot = 38
    }
}