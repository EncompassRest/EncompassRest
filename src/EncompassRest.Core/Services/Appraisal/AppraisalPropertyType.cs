using System.Runtime.Serialization;

namespace EncompassRest.Services.Appraisal
{
    /// <summary>
    /// AppraisalPropertyType
    /// </summary>
    public enum AppraisalPropertyType
    {
        /// <summary>
        /// 2 to 4 Unit Building
        /// </summary>
        [EnumMember(Value = "2 to 4 Unit Building")]
        n2to4UnitBuilding = 0,
        /// <summary>
        /// 5+ Unit Building
        /// </summary>
        [EnumMember(Value = "5+ Unit Building")]
        n5PlusUnitBuilding = 1,
        /// <summary>
        /// Agricultural
        /// </summary>
        Agricultural = 2,
        /// <summary>
        /// Apartment
        /// </summary>
        Apartment = 3,
        /// <summary>
        /// Assembly/Meeting Place
        /// </summary>
        [EnumMember(Value = "Assembly/Meeting Place")]
        AssemblyMeetingPlace = 4,
        /// <summary>
        /// Attached
        /// </summary>
        Attached = 5,
        /// <summary>
        /// Commercial (Non-Residential)
        /// </summary>
        [EnumMember(Value = "Commercial (Non-Residential)")]
        CommercialNonResidential = 6,
        /// <summary>
        /// Commercial (other)
        /// </summary>
        [EnumMember(Value = "Commercial (other)")]
        CommercialOther = 7,
        /// <summary>
        /// Condominium
        /// </summary>
        Condominium = 8,
        /// <summary>
        /// Condotel
        /// </summary>
        Condotel = 9,
        /// <summary>
        /// Cooperative
        /// </summary>
        Cooperative = 10,
        /// <summary>
        /// Detached
        /// </summary>
        Detached = 11,
        /// <summary>
        /// Detached PUD
        /// </summary>
        [EnumMember(Value = "Detached PUD")]
        DetachedPUD = 12,
        /// <summary>
        /// Duplex
        /// </summary>
        Duplex = 13,
        /// <summary>
        /// Healthcare
        /// </summary>
        Healthcare = 14,
        /// <summary>
        /// Industrial
        /// </summary>
        Industrial = 15,
        /// <summary>
        /// Lodging &amp; Hospitality
        /// </summary>
        [EnumMember(Value = "Lodging & Hospitality")]
        LodgingAndHospitality = 16,
        /// <summary>
        /// Manufactured Home
        /// </summary>
        [EnumMember(Value = "Manufactured Home")]
        ManufacturedHome = 17,
        /// <summary>
        /// Mixed Use (Residential)
        /// </summary>
        [EnumMember(Value = "Mixed Use (Residential)")]
        MixedUseResidential = 18,
        /// <summary>
        /// Mobile Home (Moveable)
        /// </summary>
        [EnumMember(Value = "Mobile Home (Moveable)")]
        MobileHomeMoveable = 19,
        /// <summary>
        /// Mobile Home (Permanent)
        /// </summary>
        [EnumMember(Value = "Mobile Home (Permanent)")]
        MobileHomePermanent = 20,
        /// <summary>
        /// Modular Home
        /// </summary>
        [EnumMember(Value = "Modular Home")]
        ModularHome = 21,
        /// <summary>
        /// Multi Family Residence
        /// </summary>
        [EnumMember(Value = "Multi Family Residence")]
        MultiFamilyResidence = 22,
        /// <summary>
        /// Office
        /// </summary>
        Office = 23,
        /// <summary>
        /// Other
        /// </summary>
        Other = 24,
        /// <summary>
        /// Planned Unit Development
        /// </summary>
        [EnumMember(Value = "Planned Unit Development")]
        PlannedUnitDevelopment = 25,
        /// <summary>
        /// Platted
        /// </summary>
        Platted = 26,
        /// <summary>
        /// Quad
        /// </summary>
        Quad = 27,
        /// <summary>
        /// Retail/Restaurant
        /// </summary>
        [EnumMember(Value = "Retail/Restaurant")]
        RetailRestaurant = 28,
        /// <summary>
        /// Senior Housing
        /// </summary>
        [EnumMember(Value = "Senior Housing")]
        SeniorHousing = 29,
        /// <summary>
        /// Shopping Center
        /// </summary>
        [EnumMember(Value = "Shopping Center")]
        ShoppingCenter = 30,
        /// <summary>
        /// Single Family
        /// </summary>
        [EnumMember(Value = "Single Family")]
        SingleFamily = 31,
        /// <summary>
        /// Special Purpose
        /// </summary>
        [EnumMember(Value = "Special Purpose")]
        SpecialPurpose = 32,
        /// <summary>
        /// Sports &amp; Entertainment
        /// </summary>
        [EnumMember(Value = "Sports & Entertainment")]
        SportsAndEntertainment = 33,
        /// <summary>
        /// Townhouse
        /// </summary>
        Townhouse = 34,
        /// <summary>
        /// Triplex
        /// </summary>
        Triplex = 35,
        /// <summary>
        /// UnPlatted
        /// </summary>
        UnPlatted = 36,
        /// <summary>
        /// Vacant Land
        /// </summary>
        [EnumMember(Value = "Vacant Land")]
        VacantLand = 37,
        /// <summary>
        /// Vacant Lot
        /// </summary>
        [EnumMember(Value = "Vacant Lot")]
        VacantLot = 38
    }
}