using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NmlsPropertyType
    /// </summary>
    public enum NmlsPropertyType
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