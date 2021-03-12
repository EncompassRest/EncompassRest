using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// GsePropertyType
    /// </summary>
    public enum GsePropertyType
    {
        /// <summary>
        /// Single Family
        /// </summary>
        [Description("Single Family")]
        SingleFamily = 0,
        /// <summary>
        /// Condominium
        /// </summary>
        Condominium = 1,
        /// <summary>
        /// Townhouse
        /// </summary>
        Townhouse = 2,
        /// <summary>
        /// Cooperative
        /// </summary>
        Cooperative = 3,
        /// <summary>
        /// 2 to 4 Units
        /// </summary>
        [Description("2 to 4 Units")]
        TwoToFourUnitProperty = 4,
        /// <summary>
        /// Multi-Family+4
        /// </summary>
        [Description("Multi-Family+4")]
        MultifamilyMoreThanFourUnits = 5,
        /// <summary>
        /// Mobile Home
        /// </summary>
        [Description("Mobile Home")]
        ManufacturedMobileHome = 6,
        /// <summary>
        /// Commercial
        /// </summary>
        [Description("Commercial")]
        CommercialNonResidential = 7,
        /// <summary>
        /// Home And Business Combined
        /// </summary>
        [Description("Home And Business Combined")]
        HomeAndBusinessCombined = 8,
        /// <summary>
        /// Mixed Use
        /// </summary>
        [Description("Mixed Use")]
        MixedUseResidential = 9,
        /// <summary>
        /// Farm
        /// </summary>
        Farm = 10,
        /// <summary>
        /// Land
        /// </summary>
        Land = 11
    }
}