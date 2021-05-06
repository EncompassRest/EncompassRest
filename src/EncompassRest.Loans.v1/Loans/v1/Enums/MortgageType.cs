using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// MortgageType
    /// </summary>
    public enum MortgageType
    {
        /// <summary>
        /// FHA
        /// </summary>
        FHA = 0,
        /// <summary>
        /// Rural Housing Service
        /// </summary>
        [EnumMember(Value = "Rural Housing Service")]
        RuralHousingService = 1,
        /// <summary>
        /// FarmersHomeAdministration
        /// </summary>
        [Description("FarmersHomeAdministration")]
        FmHA = 2,
        /// <summary>
        /// Conventional Uninsured
        /// </summary>
        [Description("Conventional Uninsured")]
        Uninsured = 3,
        /// <summary>
        /// VA
        /// </summary>
        VA = 4,
        /// <summary>
        /// Conventional Insured
        /// </summary>
        [Description("Conventional Insured")]
        Insured = 5
    }
}