using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMacPropertyType
    /// </summary>
    public enum FreddieMacPropertyType
    {
        /// <summary>
        /// 2 to 4 Family
        /// </summary>
        [Description("2 to 4 Family")]
        [EnumMember(Value = "2")]
        n2 = 2,
        /// <summary>
        /// Low-rise Condo (up to 4)
        /// </summary>
        [Description("Low-rise Condo (up to 4)")]
        C = 100,
        /// <summary>
        /// High rise Condo (5 or more)
        /// </summary>
        [Description("High rise Condo (5 or more)")]
        B = 101,
        /// <summary>
        /// Single Family Detached PUD
        /// </summary>
        [Description("Single Family Detached PUD")]
        D = 102,
        /// <summary>
        /// Single Family Attached
        /// </summary>
        [Description("Single Family Attached")]
        T = 103,
        /// <summary>
        /// Single Family Attached PUD
        /// </summary>
        [Description("Single Family Attached PUD")]
        P = 104,
        /// <summary>
        /// Single Family Detached
        /// </summary>
        [Description("Single Family Detached")]
        S = 105,
        /// <summary>
        /// Multifamily
        /// </summary>
        [Description("Multifamily")]
        M = 106,
        /// <summary>
        /// Cooperative
        /// </summary>
        [Description("Cooperative")]
        A = 107,
        /// <summary>
        /// Manufactured Home Singlewide
        /// </summary>
        [Description("Manufactured Home Singlewide")]
        F = 108,
        /// <summary>
        /// Manufactured Home Multiwide
        /// </summary>
        [Description("Manufactured Home Multiwide")]
        G = 109
    }
}