using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// TypeOfStructure
    /// </summary>
    public enum TypeOfStructure
    {
        /// <summary>
        /// Conventional Construction
        /// </summary>
        [Description("Conventional Construction")]
        Conventional = 0,
        /// <summary>
        /// Singlewide M/H
        /// </summary>
        [Description("Singlewide M/H")]
        Singlewide = 1,
        /// <summary>
        /// Doublewide M/H
        /// </summary>
        [Description("Doublewide M/H")]
        Doublewide = 2,
        /// <summary>
        /// M/H Lot Only
        /// </summary>
        [Description("M/H Lot Only")]
        LotOnly = 3,
        /// <summary>
        /// Prefabricated Home
        /// </summary>
        [Description("Prefabricated Home")]
        PrefabricatedHome = 4,
        /// <summary>
        /// Condominium Conversion
        /// </summary>
        [Description("Condominium Conversion")]
        Condominium = 5
    }
}