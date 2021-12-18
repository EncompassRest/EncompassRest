using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OtherPropertyType
    /// </summary>
    public enum OtherPropertyType
    {
        /// <summary>
        /// 1 unit
        /// </summary>
        [Description("1 unit")]
        [EnumMember(Value = "1 Unit")]
        n1Unit = 0,
        /// <summary>
        /// 2-4 units
        /// </summary>
        [Description("2-4 units")]
        [EnumMember(Value = "2-4 Units")]
        n24Units = 1,
        /// <summary>
        /// Condominium
        /// </summary>
        Condominium = 2,
        /// <summary>
        /// PUD
        /// </summary>
        PUD = 3,
        /// <summary>
        /// Co-op
        /// </summary>
        [Description("Co-op")]
        Cooperative = 4,
        /// <summary>
        /// Manufactured Single Wide
        /// </summary>
        [Description("Manufactured Single Wide")]
        [EnumMember(Value = "Manufactured Housing Single Wide")]
        ManufacturedHousingSingleWide = 5,
        /// <summary>
        /// Manufactured Multiwide
        /// </summary>
        [Description("Manufactured Multiwide")]
        [EnumMember(Value = "Manufactured Housing Multiwide")]
        ManufacturedHousingMultiwide = 6,
        /// <summary>
        /// Detached Condominium
        /// </summary>
        [EnumMember(Value = "Detached Condominium")]
        DetachedCondominium = 7
    }
}