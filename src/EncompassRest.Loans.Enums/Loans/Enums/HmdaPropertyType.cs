using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HmdaPropertyType
    /// </summary>
    public enum HmdaPropertyType
    {
        /// <summary>
        /// One-to-fourFamily
        /// </summary>
        [EnumMember(Value = "One-to-fourFamily")]
        OneToFourFamily = 0,
        /// <summary>
        /// Manufactured Housing
        /// </summary>
        [Description("Manufactured Housing")]
        ManufacturedHousing = 1,
        /// <summary>
        /// Multifamily Dwelling
        /// </summary>
        [Description("Multifamily Dwelling")]
        MultifamilyDwelling = 2
    }
}